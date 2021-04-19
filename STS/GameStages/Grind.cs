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
    public partial class Grind : Form
    {
        Podatki p;
        Weapons selectedWeapon;
        Armor selectedArmor;
        Random r = new Random();
        Mob selectedMob;
        int x, currentNewExp, extraDmg;
        bool enemyDefeated;
        string dmgOutput;

        public void dropItems()
        {
            x = r.Next(12);
            if (x >= 0 && x <= 2)
                p.items.healthPot.incrementQuantity(1);
            else if (x >= 3 && x <= 5)
                p.items.shield.incrementQuantity(1);
            else if (x >= 6 && x <= 8)
                p.items.bomb.incrementQuantity(1);
            else
                p.items.sword.incrementQuantity(1);

            updateItems();
        }

        public void isClear()
        {
            dmgOutput = "--------------------------------------------------";
            txtDmgOutput.AppendText(dmgOutput);
            txtDmgOutput.AppendText(Environment.NewLine);
            extraDmg = 0;
            dropItems();
            p.coins = p.coins + p.newCoins;
            p.exp = p.exp + currentNewExp;

            if (p.exp >= p.maxExp)
            {
                p.playerMaxHP = p.playerMaxHP + 5;
                p.playerHP += 5;
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
            enemyDefeated = false;
            lblCoins.Text = "Coins: " + p.coins;
            lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
            p.expAdd = 0;
            unlockItems();
        }

        public void playerAttack()
        {
            x = r.Next(10);
            if (x == 0)
            {
                dmgOutput = "Your attack missed...";
                txtDmgOutput.AppendText(dmgOutput);
                txtDmgOutput.AppendText(Environment.NewLine);
                lblDmg1.Text = "Your attack missed...";
            }
            else
            {
                x = extraDmg + p.str / 2 + r.Next(selectedWeapon.weaponDmgMin, selectedWeapon.weaponDmgMax + 1);

                p.enemyHP = p.enemyHP - x;
                lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
                lblDmg1.Text = "You dealt: " + x + " damage";
                dmgOutput = lblDmg1.Text;
                txtDmgOutput.AppendText(dmgOutput);
                txtDmgOutput.AppendText(Environment.NewLine);
            }

            if (p.enemyHP < 1)
            {                
                enemyDefeated = true;                
            }
        }
        public void enemyAttack()
        {
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
            dmgOutput = lblDmg2.Text;
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

        public void selectMob()
        {
            if (p.stageRank == 1)
            {
                Type[] chooseMob = Assembly.GetAssembly(typeof(MobLowRank)).GetTypes().Where(TheType => TheType.IsClass && !TheType.IsAbstract && TheType.GetInterfaces().Contains(typeof(MobLowRank))).ToArray();
                x = r.Next(chooseMob.Length);
                ConstructorInfo ctor = chooseMob[x].GetConstructor(new Type[0]);
                selectedMob = (Mob)ctor.Invoke(new object[] { });
                currentNewExp = 2;
                p.newCoins = selectedMob.coinValue - 1;
            }
            else if (p.stageRank == 2)
            {
                Type[] chooseMob = Assembly.GetAssembly(typeof(MobMidRank)).GetTypes().Where(TheType => TheType.IsClass && !TheType.IsAbstract && TheType.GetInterfaces().Contains(typeof(MobMidRank))).ToArray();
                x = r.Next(chooseMob.Length);
                ConstructorInfo ctor = chooseMob[x].GetConstructor(new Type[0]);
                selectedMob = (Mob)ctor.Invoke(new object[] { });
                currentNewExp = 5;
                if (selectedMob != p.mobs.spaceGoblin)
                    p.newCoins = selectedMob.coinValue - 2;
                else
                    p.newCoins = selectedMob.coinValue - 3;
            }
            pbEnemy.BackgroundImage = selectedMob.mobImage;
        }

        public void setMobStats()
        {                       
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
            btnSword.Text = "Damage: " + p.items.sword.itemQuantity;
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

        public Grind(Weapons weapon, Armor armor, ref Podatki p)
        {
            InitializeComponent();
            this.p = p;

            p.items.healthPot.itemQuantity = 1;
            p.items.bomb.itemQuantity = 0;
            p.items.shield.itemQuantity = 0;
            p.items.sword.itemQuantity = 0;
            unlockItems();
            updateItems();
            p.playerHP = p.playerMaxHP;
            selectedArmor = armor;
            selectedWeapon = weapon;
            selectMob();
            setMobStats();
            pbPlayer.BackgroundImage = selectedArmor.armorImage;
            pbSword.BackgroundImage = selectedWeapon.weaponImage;
            lblLevel.Text = "Level: " + p.level;
            lblCoins.Text = "Coins: " + p.coins;
            lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
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
                if (p.stageRank == 1)
                    p.playerHP += 10;
                else if (p.stageRank == 2)
                    p.playerHP += 15;
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
                if (p.stageRank == 1)
                    p.shields += 6;
                else if (p.stageRank == 2)
                    p.shields += 10;
                lblShields.Text = "(" + p.shields + ")";
            }
        }

        private void btnSword_Click(object sender, EventArgs e)
        {
            if (p.items.sword.itemQuantity > 0)
                p.items.sword.decrementQuantity(1);
            lockItems();
            updateItems();
            if (p.stageRank == 1)
                extraDmg = r.Next(4, 8);
            else if (p.stageRank == 2)
                extraDmg = r.Next(8, 11);

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
                selectMob();
                setMobStats();
            }
        }
    }
}
