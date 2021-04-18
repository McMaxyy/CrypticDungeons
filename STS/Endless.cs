using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        int x, bossCount = 0, currentNewExp = 2, extraDmg;
        bool enemyDefeated, bossTime;

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

        public void isClear()
        {
            extraDmg = 0;
            dropItems();
            p.coins = p.coins + p.newCoins;
            p.exp = p.exp + currentNewExp + p.expAdd;
            p.expAdd = 0;

            if (p.exp >= p.maxExp)
            {
                p.playerMaxHP = p.playerMaxHP + 5;
                p.playerHP += 5;
                p.exp = p.exp % p.maxExp;
                p.level++;
                p.maxExp = p.maxExp * 2;
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
        }

        public void playerAttack()
        {
            x = extraDmg + p.str / 2 + r.Next(selectedWeapon.weaponDmgMin, selectedWeapon.weaponDmgMax + 1);

            p.enemyHP = p.enemyHP - x;
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
            lblDmg1.Text = "You dealt: " + x + " damage";
            if (p.enemyHP < 1)
            {                
                enemyDefeated = true;                
            }
        }
        public void enemyAttack()
        {
            if (p.bossStage == true)
                p.y = r.Next(selectedBoss.minDmgBoss, selectedBoss.maxDmgBoss + 1);
            else
                p.y = r.Next(selectedMob.minMobDmg, selectedMob.maxMobDmg + 1);

            p.y = p.y - p.def / 2 - selectedArmor.armorDefense / 3;

            if (p.y < 0)
                p.y = 0;

            if (p.t == 1 && p.shields > 0)
                p.shields -= p.y;
            else if (p.t == 1)
                p.playerHP -= p.y;

            if (p.shields <= 0)
                p.shields = 0;
            lblShields.Text = "(" + p.shields + ")";
            lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
            lblDmg2.Text = "Enemy dealt: " + p.y + " damage";
            if (p.y == 0)
                lblDmg2.Text = "Enemy attack missed";
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

        public void selectMob()
        {
            Type[] chooseMob = Assembly.GetAssembly(typeof (Mob)).GetTypes().Where(TheType => TheType.IsClass && !TheType.IsAbstract && TheType.IsSubclassOf(typeof (Mob))).ToArray();
            x = r.Next(chooseMob.Length);
            ConstructorInfo ctor = chooseMob[x].GetConstructor(new Type[0]);
            selectedMob = (Mob)ctor.Invoke(new object[] { });
            //MessageBox.Show(selectedMob.mobName);
            pbEnemy.BackgroundImage = selectedMob.mobImage;
        }
        public void selectBoss()
        {
            Type[] chooseMob = Assembly.GetAssembly(typeof(Boss)).GetTypes().Where(TheType => TheType.IsClass && !TheType.IsAbstract && TheType.IsSubclassOf(typeof(Boss))).ToArray();
            x = r.Next(chooseMob.Length);
            ConstructorInfo ctor = chooseMob[x].GetConstructor(new Type[0]);
            selectedBoss = (Boss)ctor.Invoke(new object[] { });
            //MessageBox.Show(selectedMob.mobName);

            pbEnemy.BackgroundImage = selectedBoss.bossImage;
            p.enemyMaxHP = selectedBoss.bossMaxHP;
            p.newCoins = selectedBoss.coinValue;
            p.expAdd += 2;
            p.enemyHP = p.enemyMaxHP;
            lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
        }

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

        public void levelUp()
        {
            lblLevel.Text = "Level: " + p.level;
            btnAttack.Enabled = false;
            btnStr.Enabled = btnDef.Enabled = true;
            lblPoints.Text = "Unused points: " + p.points;
            pbLevelUp.Visible = btnDef.Visible = btnStr.Visible = btnLevelUp.Visible = lblStrDef.Visible = lblPoints.Visible = lblLevelUp.Visible = true;
            p.newLevel++;
        }
        
        public void updateItems()
        {
            btnSword.Text = "WepChange: " + p.items.sword.itemQuantity;
            btnShield.Text = "Shields: " + p.items.shield.itemQuantity;
            btnBomb.Text = "Bombs: " + p.items.bomb.itemQuantity;
            btnPotion.Text = "HP Pots: " + p.items.healthPot.itemQuantity;
        }

        public void lockItems()
        {
            btnPotion.Enabled = false;
            btnBomb.Enabled = false;
            btnShield.Enabled = false;
            btnSword.Enabled = false;
        }

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

            p.items.healthPot.itemQuantity = 0;
            p.items.bomb.itemQuantity = 0;
            p.items.shield.itemQuantity = 0;
            p.items.sword.itemQuantity = 10;
            updateItems();
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

        private void btnPotion_Click(object sender, EventArgs e)
        {
            if (p.items.healthPot.itemQuantity > 0)
            {
                p.items.healthPot.decrementQuantity(1);
                lockItems();
                updateItems();
                p.playerHP += 10;
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
                p.enemyHP -= 40;
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
                p.shields += 6;
                lblShields.Text = "(" + p.shields + ")";
            }
        }

        private void btnSword_Click(object sender, EventArgs e)
        {
            if (p.items.sword.itemQuantity > 0)
                p.items.sword.decrementQuantity(1);
            lockItems();
            updateItems();
            extraDmg = r.Next(5, 8);
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

        private void btnAttack_Click(object sender, EventArgs e)
        {
            playerAttack();
            if (enemyDefeated == false)
            {
                enemyAttack();
            }
            else
            {
                isClear();
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
        }
    }
}
