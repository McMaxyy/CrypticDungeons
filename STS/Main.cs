using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS
{
    public partial class STS : Form
    {

        int yy, defense, extraExp;
        bool enemyDefeated;
        Weapons selectedWeapon;
        Armor selectedArmor;
        Boss selectedBoss;
        Mob selectedMob, availableMob1, availableMob2, availableMob3, specialMob;        
        Podatki p;
        Random r = new Random();
        
        //Show and hide stage or skip window
        public void showStage()
        {
            lblStats.Text = "Str: " + p.str + " | Def: " + p.def;
            btnAttack.Enabled = btnDefend.Enabled = btnFlee.Enabled = true;

            lblDmg1.Text = "You dealt: ";
            lblDmg2.Text = "Enemy dealt: ";
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
            lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
            lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox || x is Button || x is Label && x.Visible == false)
                {
                    if (x != pbSkip && x != btnSkip && x != lblSkip && x != lblLost && x != btnRestart && x != pbCleared && x != lblCleared && x != btnCleared &&
                        x != pbLevelUp && x != btnLevelUp && x != lblLevelUp && x != lblStrDef && x != lblPoints && x != btnStr && x != btnDef)
                    {
                        x.Visible = true;
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Visible == true)
                {
                    if ((string)x.Tag != "Stage")
                    {
                        x.Visible = false;
                    }
                }
            }
            btnBoss.Visible = btnStart.Visible = false;
        }

        public void skipStage()
        {
            p.skipped = true;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox || x is Button || x is Label && x.Visible == true)
                {
                    x.Visible = false;
                }
            }
            btnSkip.Visible = true;
            lblSkip.Visible = true;
            pbSkip.Visible = true;
        }
        public void hideStage()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox || x is Button || x is Label  && x.Visible == true)
                {
                    if ((string)x.Tag == "Stage")
                    {
                        x.Visible = false;
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox || x is Button || x is Label && x.Visible == false)
                {
                    if ((string)x.Tag != "Stage")
                    {
                        x.Visible = true;
                    }
                }
            }
        }

        //Check if the player has cleared the stage
        public void stageIsClear()
        {
            btnAttack.Enabled = btnDefend.Enabled = btnFlee.Enabled = false;            

            if (p.n == 1)
            {
                btnBattle1.Enabled = btnRand1.Enabled = btnRand2.Enabled = false;
                btnBattle2.Enabled = btnRand3.Enabled = btnRand4.Enabled = true;
                if (p.skipped == false)
                {
                    pbCleared.Visible = btnCleared.Visible = lblCleared.Visible = true;                   
                    if (p.level == p.newLevel)
                    {
                        levelUp();
                    }

                lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;                    
                }
            }
            else if (p.n == 2)
            {
                btnBattle2.Enabled = btnRand3.Enabled = btnRand4.Enabled = false;
                btnBattle3.Enabled = btnRand5.Enabled = btnRand6.Enabled = true;
                if (p.skipped == false)
                {
                    pbCleared.Visible = btnCleared.Visible = lblCleared.Visible = true;
                    if (p.level == p.newLevel)
                    {
                        levelUp();
                    }
                      
                    lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
                }
            }
            else if (p.n == 3)
            {
                btnBattle3.Enabled = btnRand5.Enabled = btnRand6.Enabled = false;
                btnBoss.Enabled = true;
                p.bossStage = true;
                if (p.skipped == false)
                {
                    pbCleared.Visible = btnCleared.Visible = lblCleared.Visible = true;
                    if (p.level == p.newLevel)
                    {
                        levelUp();
                    }

                    lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
                }
            }
            else if (p.n == 4)
            {
                yy = r.Next(0, selectedBoss.dropTable.Length);
                p.inventory.addItem(selectedBoss.dropTable[yy], 2);


                /*if (yy == 1)
                    p.weapons.ironS.isUnlocked = true;
                else if (yy == 2)
                    p.armors.ironA.isUnlocked = true;*/

                if (p.level == p.newLevel)
                {
                    btnStr.Enabled = btnDef.Enabled = true;
                    lblPoints.Text = "Unused points: " + p.points;
                    pbLevelUp.Visible = btnDef.Visible = btnStr.Visible = btnLevelUp.Visible = lblStrDef.Visible = lblPoints.Visible = lblLevelUp.Visible = true;
                    p.newLevel++;
                }

                btnLevelUp.Enabled = false;
                lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
                lblYY.Text = yy.ToString();
                btnBoss.Enabled = false;
                lblLost.Text = "You won";
                lblLost.Visible = true;
                btnRestart.Text = "Return to map";
                btnRestart.Visible = true;
                p.cleared = true;
            }
            p.n++;
            p.skipped = false;
        }
        public void stageNotClear()
        {
            lblLost.Visible = true;
            btnRestart.Visible = true;
            btnAttack.Enabled = btnDefend.Enabled = btnFlee.Enabled = false;
            p.bossStage = false;
        }

        //Restart Game
        public void restartGame()
        {
            hideStage();
            btnBattle1.Enabled = btnRand1.Enabled = btnRand2.Enabled = true;
            btnBattle2.Enabled = btnRand3.Enabled = btnRand4.Enabled = false;
            btnBattle3.Enabled = btnRand5.Enabled = btnRand6.Enabled = false;
            btnBoss.Enabled = false;
            btnAttack.Enabled = btnDefend.Enabled = btnFlee.Enabled = true;
            lblLost.Visible = false;
            btnRestart.Visible = false;
            lblLost.Text = "You lost";
            p.n = 1;
            p.playerHP = 30;
            p.enemyHP = 15;
            p.enemyMaxHP = 15;
            pbEnemy.BackgroundImage = Properties.Resources.Pikl;
        }

        //Battle phase
        public void playerAttack()
        {
            int x = 0;

            x = p.str / 2 + r.Next(selectedWeapon.weaponDmgMin, selectedWeapon.weaponDmgMax + 1);        

            p.enemyHP = p.enemyHP - x;
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
            lblDmg1.Text = "You dealt: " + x + " damage";
            lblDmg1.Visible = true;
            lblDmg2.Visible = true;
            if (p.enemyHP < 1)
            {
                p.coins = p.coins + p.newCoins;
                p.exp = p.exp + p.expAdd + 3;
                if (p.exp >= p.maxExp)
                {
                    p.playerMaxHP = p.playerMaxHP + 5;
                    p.exp = p.exp%p.maxExp;
                    p.level++;
                    p.maxExp = p.maxExp * 2;
                    p.points += 2;
                }
                enemyDefeated = true;
                stageIsClear();
            }
        }
        public void enemyAttack()
        {
            /*if (p.enemyMaxHP == 15)
                p.y = r.Next(1, 5);
            else if (p. enemyMaxHP > 15)
                p.y = r.Next(selectedBoss.minDmgBoss, selectedBoss.maxDmgBoss + 1);*/

            if (p.bossStage == true)
                p.y = r.Next(selectedBoss.minDmgBoss, selectedBoss.maxDmgBoss + 1);
            else
                p.y = r.Next(selectedMob.minMobDmg, selectedMob.maxMobDmg + 1);

            if (p.defend == true)
            {
                p.y = p.y - defense;
                p.defend = false;
            }

            p.y = p.y - p.def / 2 - selectedArmor.armorDefense / 3;

            if (p.y < 0)
                p.y = 0;

            //p.h = p.y;

            if (p.t == 1)
                p.playerHP = p.playerHP - p.y;
            lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
            lblDmg2.Text = "Enemy dealt: " + p.y + " damage";   
            if (p.y == 0)
                lblDmg2.Text = "Enemy attack missed";
            if (p.playerHP < 1)
            {
                stageNotClear();
            }
        }
        
        //Level up!
        public void levelUp()
        {
            pbCleared.Visible = btnCleared.Visible = lblCleared.Visible = false;
            btnStr.Enabled = btnDef.Enabled = true;
            lblPoints.Text = "Unused points: " + p.points;
            pbLevelUp.Visible = btnDef.Visible = btnStr.Visible = btnLevelUp.Visible = lblStrDef.Visible = lblPoints.Visible = lblLevelUp.Visible = true;
            p.newLevel++;
        }


        //Mob selection
        public void selectMob()
        {
            yy = r.Next(0, 10);
            if (yy <= 4)
                selectedMob = availableMob1;
            else if (yy > 4 && yy <= 7)
                selectedMob = availableMob2;
            else
                selectedMob = availableMob3;
        }
        public void setMobStats()
        {
            p.newCoins = selectedMob.coinValue;
            p.enemyMaxHP = selectedMob.maxMobHP;
            pbEnemy.BackgroundImage = selectedMob.mobImage;
            p.enemyHP = p.enemyMaxHP;
        }

        
        public STS(Weapons sword, Armor armor, Boss boss, Mob mob1, Mob mob2, Mob mob3, Mob special, ref Podatki p)
        {
            InitializeComponent();

            p.bossStage = false;
            p.playerHP = p.playerMaxHP;           
            this.p = p;
            selectedWeapon = sword;
            selectedArmor = armor;
            selectedBoss = boss;
            availableMob1 = mob1;
            availableMob2 = mob2;
            availableMob3 = mob3;
            specialMob = special;
            pbPlayer.BackgroundImage = selectedArmor.armorImage;
            pbSword.BackgroundImage = selectedWeapon.weaponImage;

            btnLevelUp.Enabled = true;
            p.n = 1;
        }

        private void btnBattle1_Click(object sender, EventArgs e)
        {
            selectMob();
            setMobStats();
            showStage();
        }

        private void btnRand2_Click(object sender, EventArgs e)
        {
            yy = r.Next(0, 10);
            if (yy <= 2)
            {
                skipStage();
            }
            else if (yy > 2 && yy <= 8)
            {
                selectMob();
                setMobStats();
                showStage();
            }
            else
            {
                p.newCoins = specialMob.coinValue;
                p.enemyMaxHP = specialMob.maxMobHP;
                pbEnemy.BackgroundImage = specialMob.mobImage;
                p.enemyHP = p.enemyMaxHP;
                showStage();
            }

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            hideStage();
            stageIsClear();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            playerAttack();
            if (enemyDefeated != true)
            {
                enemyAttack();
            }
            else
                enemyDefeated = false;
        }

        private void btnFlee_Click(object sender, EventArgs e)
        {
            int x = r.Next(1, 11);
            if (x == 1 || x == 2 || x == 3)
            {
                hideStage();
                stageIsClear();
            }
            else
            {
                lblDmg1.Text = "You dealt: ";
                enemyAttack();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (p.cleared == true)
            {
                Home h = new Home(selectedWeapon, selectedArmor, ref p);
                this.Hide();
                h.Show();
            }

            restartGame();
        }

        private void btnBoss_Click(object sender, EventArgs e)
        {
            pbEnemy.BackgroundImage = selectedBoss.bossImage;
            p.enemyMaxHP = selectedBoss.bossMaxHP;
            p.newCoins = selectedBoss.coinValue;

            p.enemyHP = p.enemyMaxHP;

            p.playerHP = p.playerHP + 20;
            if (p.playerHP > p.playerMaxHP)
                p.playerHP = p.playerMaxHP;

            showStage();
        }

        private void btnCleared_Click(object sender, EventArgs e)
        {
            hideStage();
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Home m = new Home(selectedWeapon, selectedArmor, ref p);
            this.Hide();
            m.Show();
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            p.defend = true;
            defense = selectedArmor.armorDefense/2;
            enemyAttack();
        }
    }
}
