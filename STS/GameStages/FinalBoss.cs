using System;
using System.Drawing;
using System.Windows.Forms;

namespace STS
{   
    public partial class FinalBoss : Form
    {
        Podatki p;
        Weapons selectedWeapon;
        Armor selectedArmor;
        Boss selectedBoss;
        Random r = new Random();
        int x, defense, yy, xx, fireCount;
        bool enemyDefeated, fireAttack;
        string dmgOutput;

        //Function that checks if the enemy's been slain, resets extra weapon values and gives the player coins and experience points
        public void isClear()
        {
            p.enemyHP = 0;
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;

            p.playerHP += p.y;
            p.coins = p.coins + 50;

            lblCoins.Text = "Coins: " + p.coins;

            yy = r.Next(10);
            if (yy >= 0 && yy <= 6)
            {
                yy = r.Next(0, selectedBoss.dropTable.Length - 1);
                xx = r.Next(1, 4);
                p.inventory.addItem(selectedBoss.dropTable[yy], xx);
            }
            else
            {
                yy = 2;
                xx = 1;
                p.inventory.addItem(selectedBoss.dropTable[yy], xx);               
            }

            p.inventory.showItem(yy + 6);
            lblCleared.Text = "You've cleared the final boss!" + Environment.NewLine + Environment.NewLine + "You got " + xx + "x " + p.inventory.itemShow;

            btnAttack.Enabled = btnDefend.Enabled = btnPotion.Enabled = btnReturn.Enabled = false;
            pbCleared.Visible = btnCleared.Visible = lblCleared.Visible = true;          
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
                x = p.str / 2 + r.Next(selectedWeapon.weaponDmgMin, selectedWeapon.weaponDmgMax + 1);

                p.enemyHP = p.enemyHP - x;
                lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
                dmgOutput = "You dealt: " + x + " damage";
                txtDmgOutput.AppendText(dmgOutput);
                txtDmgOutput.AppendText(Environment.NewLine);
            }

            if (p.enemyHP < 1)
            {                
                enemyDefeated = true;
                isClear();
            }
        }

        //Enemy attack function
        public void enemyAttack()
        {
            x = r.Next(10);
            if (x == 0)
            {
                dmgOutput = "Enemy attack missed...";
                txtDmgOutput.AppendText(dmgOutput);
                txtDmgOutput.AppendText(Environment.NewLine);
                p.y = 0;
            }
            else
            {
                p.y = r.Next(selectedBoss.minDmgBoss, selectedBoss.maxDmgBoss + 1);

                if (p.defend == true)
                {
                    p.y = p.y - defense;
                    p.defend = false;
                }

                p.y = p.y - p.def / 2 - selectedArmor.armorDefense / 3;

                if (p.y < 0)
                    p.y = 0;

                if (enemyDefeated != true)
                    p.playerHP -= p.y;

                lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
                dmgOutput = "Enemy dealt: " + p.y + " damage";
                if (p.y == 0)
                    dmgOutput = "Enemy attack missed";

                txtDmgOutput.AppendText(dmgOutput);
                txtDmgOutput.AppendText(Environment.NewLine);
            }

            if (p.playerHP < 1)
            {
                p.exp = p.exp - 10;
                if (p.exp < 0)
                    p.exp = 0;

                MessageBox.Show("Gitgud");

                Home m = new Home(selectedWeapon, selectedArmor, ref p);
                m.Width = this.Width;
                m.Height = this.Height;
                m.StartPosition = FormStartPosition.Manual;
                m.Location = new Point(this.Location.X, this.Location.Y);
                this.Visible = false;
                m.ShowDialog();
            }
        }

        //Function that updates which items you have
        public void updateItems()
        {
            btnPotion.Text = "HP Pots: " + p.items.healthPot.itemQuantity;
        }

        //Function that unlocks items that you do have
        public void unlockItems()
        {
            if (p.items.healthPot.itemQuantity > 0)
                btnPotion.Enabled = true;
        }

        public FinalBoss(Weapons weapon, Armor armor, Boss boss, ref Podatki p)
        {
            InitializeComponent();
            this.p = p;

            p.items.healthPot.itemQuantity = 3;
            unlockItems();
            updateItems();
            p.playerHP = p.playerMaxHP;
            selectedBoss = boss;
            selectedArmor = armor;
            selectedWeapon = weapon;
            pbPlayer.BackgroundImage = selectedArmor.armorImage;
            pbSword.BackgroundImage = selectedWeapon.weaponImage;
            lblLevel.Text = "Level: " + p.level;
            lblCoins.Text = "Coins: " + p.coins;
            p.enemyMaxHP = p.bosses.zavr.bossMaxHP;
            p.enemyHP = p.enemyMaxHP;
            lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
        }

        private void btnPotion_Click(object sender, EventArgs e)
        {
            if (p.items.healthPot.itemQuantity > 0)
            {
                p.items.healthPot.decrementQuantity(1);
                updateItems();
                p.playerHP += 40;
                if (p.playerHP > p.playerMaxHP)
                    p.playerHP = p.playerMaxHP;
                lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;

                if (p.items.healthPot.itemQuantity == 0)
                    btnPotion.Enabled = false;
            }
        }

        private void btnCleared_Click(object sender, EventArgs e)
        {
            Home m = new Home(selectedWeapon, selectedArmor, ref p);
            m.Width = this.Width;
            m.Height = this.Height;
            m.StartPosition = FormStartPosition.Manual;
            m.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            m.ShowDialog();
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
            if (selectedWeapon == p.weapons.dinoS && fireAttack == false)
            {
                yy = r.Next(10);
                if (yy != 0 && yy != 1)
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
        private void btnDefend_Click(object sender, EventArgs e)
        {
            p.defend = true;
            defense = selectedArmor.armorDefense / 2;
            enemyAttack();
            x = r.Next(10);
            if (x >= 0 && x <= 2)
            {
                p.enemyHP = p.enemyHP - (int)p.y;
                lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
                if (p.y != 0)
                {
                    dmgOutput = "You parried, dealing: " + (int)p.y + " damage";
                    txtDmgOutput.AppendText(dmgOutput);
                    txtDmgOutput.AppendText(Environment.NewLine);
                }
            }

            if (p.enemyHP < 1)
            {
                enemyDefeated = true;
                isClear();
            }
        }
    }
}
