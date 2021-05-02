using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace STS
{   
    public partial class Endless : Form
    {
        Podatki p;
        Weapons selectedWeapon;
        Armor selectedArmor;
        Random r = new Random();
        Boss selectedBoss;
        Mob selectedMob;
        int x, bossCount = 0, currentNewExp = 7, extraDmg, yy, fireCount = 0, goblinCount = 0;
        bool enemyDefeated, bossTime, fireAttack, isRageActive;
        string dmgOutput;

        //Function that drops one of the 4 items in this gamemode
        public void dropItems()
        {
            x = r.Next(10);
            if (x >= 0 && x <= 3)
                p.items.healthPot.incrementQuantity(1);
            else if (x >= 4 && x <= 7)
                p.items.shield.incrementQuantity(1);
            else if (x == 8)
                p.items.bomb.incrementQuantity(1);
            else
                p.items.sword.incrementQuantity(1);

            updateItems();
        }

        //Function that checks if the enemy's been slain, resets extra weapon values and gives the player coins and experience points
        public void isClear()
        {
            goblinCount = -1;
            isRageActive = false;
            fireCount = 0;
            fireAttack = false;
            dmgOutput = "--------------------------------------------------";
            txtDmgOutput.AppendText(dmgOutput);
            txtDmgOutput.AppendText(Environment.NewLine);
            extraDmg = 0;
            dropItems();
            p.coins = p.coins + p.newCoins;
            p.exp = p.exp + currentNewExp + p.expAdd;
            p.expAdd = 0;

            if (p.exp >= p.maxExp)
            {
                if (p.maxExp <= 80)
                {
                    p.playerMaxHP = p.playerMaxHP + 5;
                    p.playerHP += 5;
                }
                else
                {
                    p.playerMaxHP = p.playerMaxHP + 10;
                    p.playerHP += 10;
                }

                p.exp = p.exp % p.maxExp;
                p.level++;
                if (p.maxExp < 80)
                    p.maxExp = p.maxExp * 2;
                else if (p.maxExp == 80)
                    p.maxExp = 100;
                else
                    p.maxExp += 50;
                p.points += 2;
                levelUp();
            }
            bossCount++;
            enemyDefeated = false;
            lblCoins.Text = "Coins: " + p.coins;
            lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
            p.expAdd = 0;

            if (bossTime == true)
            {
                bossCount = 0;
                bossTime = false;
            }
            unlockItems();

            if (bossCount == 5)
            {
                bossTime = true;
                selectBoss();
                currentNewExp++;
            }
            else
            {
                selectMob();
                setMobStats();
            }
        }

        //Player attack function
        public void playerAttack()
        {
            x = r.Next(10);
            if (x == 0)
            {
                dmgOutput = "Your attack missed...";
                txtDmgOutput.AppendText(dmgOutput);
                txtDmgOutput.AppendText(Environment.NewLine);
            }
            else
            {
                x = extraDmg + p.str / 2 + r.Next(selectedWeapon.weaponDmgMin, selectedWeapon.weaponDmgMax + 1);

                if (isRageActive == true)
                {
                    x += 3;
                    isRageActive = false;
                }

                p.enemyHP = p.enemyHP - x;
                lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
                dmgOutput = "You dealt: " + x + " damage";
                txtDmgOutput.AppendText(dmgOutput);
                txtDmgOutput.AppendText(Environment.NewLine);
            }

            if (p.enemyHP < 1)
            {                
                enemyDefeated = true;                
            }
        }

        //Enemy attack function
        public void enemyAttack()
        {
            if (bossTime == true)
                p.y = r.Next(selectedBoss.minDmgBoss, selectedBoss.maxDmgBoss + 1);
            else
                p.y = r.Next(selectedMob.minMobDmg, selectedMob.maxMobDmg + 1);

            p.y = p.y - p.def / 2 - selectedArmor.armorDefense / 3;

            if (p.y < 0)
                p.y = 0;

            if (enemyDefeated != true && p.shields > 0)
                p.shields -= p.y;
            else if (enemyDefeated != true)
                p.playerHP -= p.y;

            if (p.shields <= 0)
                p.shields = 0;
            lblShields.Text = "(" + p.shields + ")";
            lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
            dmgOutput = "Enemy dealt: " + p.y + " damage";
            if (p.y == 0)
                dmgOutput = "Enemy attack missed...";
            txtDmgOutput.AppendText(dmgOutput);
            txtDmgOutput.AppendText(Environment.NewLine);
            if (p.playerHP < 1)
            {
                p.exp = p.exp - 5;
                if (p.exp < 0)
                    p.exp = 0;

                Home m = new Home(selectedWeapon, selectedArmor, ref p);
                m.Width = this.Width;
                m.Height = this.Height;
                m.StartPosition = FormStartPosition.Manual;
                m.Location = new Point(this.Location.X, this.Location.Y);
                this.Visible = false;
                m.ShowDialog();
            }
        }

        //Function for selecting a random enemy
        public void selectMob()
        {
            Type[] chooseMob = Assembly.GetAssembly(typeof (Mob)).GetTypes().Where(TheType => TheType.IsClass && !TheType.IsAbstract && TheType.IsSubclassOf(typeof (Mob))).ToArray();
            x = r.Next(chooseMob.Length);
            ConstructorInfo ctor = chooseMob[x].GetConstructor(new Type[0]);
            selectedMob = (Mob)ctor.Invoke(new object[] { });
            pbEnemy.BackgroundImage = selectedMob.mobImage;
        }
        public void selectBoss()
        {
            Type[] chooseMob = Assembly.GetAssembly(typeof(Boss)).GetTypes().Where(TheType => TheType.IsClass && !TheType.IsAbstract && TheType.IsSubclassOf(typeof(Boss))).ToArray();
            x = r.Next(chooseMob.Length);
            ConstructorInfo ctor = chooseMob[x].GetConstructor(new Type[0]);
            selectedBoss = (Boss)ctor.Invoke(new object[] { });

            pbEnemy.BackgroundImage = selectedBoss.bossImage;
            p.enemyMaxHP = selectedBoss.bossMaxHP;
            p.newCoins = selectedBoss.coinValue;
            p.expAdd += 3;
            p.enemyHP = p.enemyMaxHP;
            lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
        }

        //Function for setting enemy stats (health, etc.)
        public void setMobStats()
        {
            if (selectedMob != p.mobs.pikle)
                p.newCoins = selectedMob.coinValue - 2;
            else
                p.newCoins = selectedMob.coinValue - 1;           
            pbEnemy.BackgroundImage = selectedMob.mobImage;
            p.enemyMaxHP = selectedMob.maxMobHP;
            p.enemyHP = p.enemyMaxHP;
            lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
        }

        //Function for when the player levels up
        public void levelUp()
        {
            lblLevel.Text = "Level: " + p.level;
            btnAttack.Enabled = false;
            btnStr.Enabled = btnDef.Enabled = true;
            lblPoints.Text = "Unused points: " + p.points;
            pbLevelUp.Visible = btnDef.Visible = btnStr.Visible = btnLevelUp.Visible = lblStrDef.Visible = lblPoints.Visible = lblLevelUp.Visible = true;
            p.newLevel++;
        }
        
        //Function that updates which items you have
        public void updateItems()
        {
            btnSword.Text = "Damage: " + p.items.sword.itemQuantity;
            btnShield.Text = "Shields: " + p.items.shield.itemQuantity;
            btnBomb.Text = "Bombs: " + p.items.bomb.itemQuantity;
            btnPotion.Text = "HP Pots: " + p.items.healthPot.itemQuantity;
        }

        //Function that locks items that you don't have
        public void lockItems()
        {
            btnPotion.Enabled = false;
            btnBomb.Enabled = false;
            btnShield.Enabled = false;
            btnSword.Enabled = false;
        }

        //Function that unlocks items that you do have
        public void unlockItems()
        {
            if (p.items.healthPot.itemQuantity > 0)
                btnPotion.Enabled = true;
            if (p.items.bomb.itemQuantity > 0)
                btnBomb.Enabled = true;
            if (p.items.shield.itemQuantity > 0)
                btnShield.Enabled = true;
            if (p.items.sword.itemQuantity > 0)
                btnSword.Enabled = true;
        }

        public Endless(Weapons weapon, Armor armor, ref Podatki p)
        {
            InitializeComponent();
            this.p = p;

            p.items.healthPot.itemQuantity = 1;
            p.items.bomb.itemQuantity = 0;
            p.items.shield.itemQuantity = 0;
            p.items.sword.itemQuantity = 0;
            updateItems();
            unlockItems();
            p.expAdd = 0;
            p.playerHP = p.playerMaxHP;
            bossCount = 0;
            selectedArmor = armor;
            selectedWeapon = weapon;
            selectMob();
            setMobStats();
            pbPlayer.BackgroundImage = selectedArmor.armorImage;
            pbSword.BackgroundImage = selectedWeapon.weaponImage;
            lblLevel.Text = "Level: " + p.level;
            lblCoins.Text = "Coins: " + p.coins;
            lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
            selectedBoss = p.bosses.goblinKing;
        }

        //Buttons for adding strength and defense points
        private void btnStr_Click(object sender, EventArgs e)
        {
            if (p.points > 0)
            {
                p.str++;
                p.points--;
                lblPoints.Text = "Unused points: " + p.points;
            }

            if (p.points == 0)
            {
                btnStr.Enabled = btnDef.Enabled = false;
            }
        }
        private void btnDef_Click(object sender, EventArgs e)
        {
            if (p.points > 0)
            {
                p.def++;
                p.points--;
                lblPoints.Text = "Unused points: " + p.points;
            }

            if (p.points == 0)
            {
                btnStr.Enabled = btnDef.Enabled = false;
            }
        }

        //Buttons for using items
        private void btnPotion_Click(object sender, EventArgs e)
        {
            if (p.items.healthPot.itemQuantity > 0)
            {
                p.items.healthPot.decrementQuantity(1);
                lockItems();
                updateItems();
                p.playerHP += 30;
                if (p.playerHP > p.playerMaxHP)
                    p.playerHP = p.playerMaxHP;
                lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
            }
        }
        private void btnBomb_Click(object sender, EventArgs e)
        {
            if (p.items.bomb.itemQuantity > 0)
            {
                p.items.bomb.decrementQuantity(1);
                lockItems();
                updateItems();
                p.enemyHP -= 60;
                lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
                if (p.enemyHP <= 0)
                    playerAttack();
            }
        }
        private void btnShield_Click(object sender, EventArgs e)
        {
            if (p.items.shield.itemQuantity > 0)
            {
                p.items.shield.decrementQuantity(1);
                lockItems();
                updateItems();
                p.shields += 15;
                lblShields.Text = "(" + p.shields + ")";
            }
        }
        private void btnSword_Click(object sender, EventArgs e)
        {
            if (p.items.sword.itemQuantity > 0)
                p.items.sword.decrementQuantity(1);
            lockItems();
            updateItems();
            extraDmg = r.Next(10, 15);
        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            pbLevelUp.Visible = btnDef.Visible = btnStr.Visible = btnLevelUp.Visible = lblStrDef.Visible = lblPoints.Visible = lblLevelUp.Visible = false;
            btnAttack.Enabled = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Home m = new Home(selectedWeapon, selectedArmor, ref p);
            m.Width = this.Width;
            m.Height = this.Height;
            m.StartPosition = FormStartPosition.Manual;
            m.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            m.ShowDialog();
        }

        //Attack button
        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (selectedWeapon == p.weapons.dinoS && fireAttack == false)
            {
                yy = r.Next(10);
                if (yy == 0 || yy == 1)
                {
                    fireAttack = true;
                    fireCount = 3;
                    pbSword.BackgroundImage = Properties.Resources.DinoSwordFire_Equip;
                }
            }

            playerAttack();
            if (enemyDefeated != true)
            {
                enemyAttack();
            }
            else
            {
                isClear();
            }

            if (selectedWeapon == p.weapons.goblinS)
            {
                if (goblinCount == 2)
                {
                    pbSword.BackgroundImage = Properties.Resources.GoblinSwordRage_Equip;
                    goblinCount = -1;
                    isRageActive = true;
                }

                if (goblinCount == 0)
                {
                    pbSword.BackgroundImage = Properties.Resources.GoblinSwordNormal_Equip;
                }
            }
            goblinCount++;

            if (fireAttack == true)
            {
                fireCount--;
                p.enemyHP -= 5;
                lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
                txtDmgOutput.AppendText("Enemy burned for an additional 5 damage");
                txtDmgOutput.AppendText(Environment.NewLine);

                if (p.enemyHP <= 0)
                    isClear();
            }

            if (selectedWeapon == p.weapons.dinoS && fireCount == 0)
            {
                fireAttack = false;
                pbSword.BackgroundImage = Properties.Resources.DinoSword_Equip;
            }
        }
    }
}
