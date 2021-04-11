using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS
{
    public partial class STS : Form
    {

        int yy, defense;
        Weapons selectedWeapon;
        Armor selectedArmor;
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
                p.t = 1;
                if (p.skipped == false)
                {
                    pbCleared.Visible = btnCleared.Visible = lblCleared.Visible = true;                   
                    if (p.level == p.newLevel)
                    {
                        pbCleared.Visible = btnCleared.Visible = lblCleared.Visible = false;
                        btnStr.Enabled = btnDef.Enabled = true;
                        lblPoints.Text = "Unused points: " + p.points;
                        pbLevelUp.Visible = btnDef.Visible = btnStr.Visible = btnLevelUp.Visible = lblStrDef.Visible = lblPoints.Visible = lblLevelUp.Visible = true;
                        p.newLevel++;
                    }

                lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;                    
                }
            }
            else if (p.n == 2)
            {
                btnBattle2.Enabled = btnRand3.Enabled = btnRand4.Enabled = false;
                btnBattle3.Enabled = btnRand5.Enabled = btnRand6.Enabled = true;
                p.t = 1;
                if (p.skipped == false)
                {
                    pbCleared.Visible = btnCleared.Visible = lblCleared.Visible = true;
                    if (p.level == p.newLevel)
                    {
                        pbCleared.Visible = btnCleared.Visible = lblCleared.Visible = false;
                        btnStr.Enabled = btnDef.Enabled = true;
                        lblPoints.Text = "Unused points: " + p.points;
                        pbLevelUp.Visible = btnDef.Visible = btnStr.Visible = btnLevelUp.Visible = lblStrDef.Visible = lblPoints.Visible = lblLevelUp.Visible = true;
                        p.newLevel++;
                    }
                      
                    lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
                }
            }
            else if (p.n == 3)
            {
                btnBattle3.Enabled = btnRand5.Enabled = btnRand6.Enabled = false;
                btnBoss.Enabled = true;
                p.t = 1;
                if (p.skipped == false)
                {
                    pbCleared.Visible = btnCleared.Visible = lblCleared.Visible = true;
                    if (p.level == p.newLevel)
                    {
                        pbCleared.Visible = btnCleared.Visible = lblCleared.Visible = false;
                        btnStr.Enabled = btnDef.Enabled = true;
                        lblPoints.Text = "Unused points: " + p.points;
                        pbLevelUp.Visible = btnDef.Visible = btnStr.Visible = btnLevelUp.Visible = lblStrDef.Visible = lblPoints.Visible = lblLevelUp.Visible = true;
                        p.newLevel++;
                    }

                    lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
                }
            }
            else if (p.n == 4)
            {
                yy = r.Next(1, 3);
                if (yy == 1)
                    p.weapons.ironS.isUnlocked = true;
                else if (yy == 2)
                    p.armors.ironA.isUnlocked = true;

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
                p.t = 1;
            }
            p.n++;
            p.skipped = false;
        }
        public void stageNotClear()
        {
            lblLost.Visible = true;
            btnRestart.Visible = true;
            btnAttack.Enabled = btnDefend.Enabled = btnFlee.Enabled = false;
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
            /*switch (selectedWeapon.weaponName)
            {
                case "Wooden Sword":
                    x = p.str + r.Next(p.weapons.woodenS.weaponDmgMin, p.weapons.woodenS.weaponDmgMax + 1);
                    break;
                case "Iron Sword":
                    x = p.str + r.Next(p.weapons.ironS.weaponDmgMin, p.weapons.ironS.weaponDmgMax + 1);
                    break;
            }*/
            x = p.str + r.Next(selectedWeapon.weaponDmgMin, selectedWeapon.weaponDmgMax + 1);

            p.enemyHP = p.enemyHP - x;
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
            lblDmg1.Text = "You dealt: " + x + " damage";
            lblDmg1.Visible = true;
            lblDmg2.Visible = true;
            if (p.enemyHP < 1)
            {
                p.exp += 3;
                if (p.exp >= p.maxExp)
                {
                    p.exp = 0;
                    p.level++;
                    p.maxExp = p.maxExp * 2;
                    p.points += 2;
                }
                p.enemyHP = 15;
                p.t = 0;
                stageIsClear();
            }
        }
        public void enemyAttack()
        {
            while (true)
            {
                if (p.enemyMaxHP == 15 && p.defend == true)
                {
                    p.y = r.Next(1, 5);
                    p.y = p.y - defense;
                    p.defend = false;
                }
                else if (p.enemyMaxHP == 15)
                    p.y = r.Next(1, 5);
                else if (p.enemyMaxHP == 30 && p.defend == true)
                {
                    p.y = r.Next(1, 7);
                    p.y = p.y - defense;
                    p.defend = false;
                }
                else if (p.enemyMaxHP == 30)
                    p.y = r.Next(1, 7);

                p.y = p.y - p.def - selectedArmor.armorDefense / 3;

                if (p.y < 0)
                    p.y = Math.Pow(p.y, 2);

                if (p.y > 0)
                    break;
            }
            /*switch (selectedArmor.armorName)
            {
                case "Bronze Armor":
                    p.y = p.y - (p.armors.BA.armorDefense/3);
                    break;
                case "Iron Armor":
                    p.y = p.y - (p.armors.IA.armorDefense/3);
                    break;
            }*/           
            p.playerHP = p.playerHP - p.y;
            lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
            lblDmg2.Text = "Enemy dealt: " + p.y + " damage";           
            if (p.playerHP < 1)
            {
                stageNotClear();
            }
        }

        //Database
        /*public void changeDB()
        {
            _con = new SqlConnection(@"Data Source = DESKTOP - PP0KUAR\SQLEXPRESS; Initial Catalog = ItemDB; Integrated Security = True");
            _con.Open();
            _cmd = new SqlCommand("UPDATE Weapons SET Unlocked = @a1 WHERE Title = @a2", _con);
        }*/

        //Program start
        public STS(Weapons sword, Armor armor, ref Podatki p)
        {
            InitializeComponent();
            this.p = p;
            selectedWeapon = sword;
            selectedArmor = armor;
            if (selectedArmor.armorName == "Bronze Armor")
                switch (selectedWeapon.weaponName)
                {
                    case "Wooden Sword":
                        pbPlayer.BackgroundImage = Properties.Resources.BronzeArmor_WoodenSword;
                        break;
                    case "Iron Sword":
                        pbPlayer.BackgroundImage = Properties.Resources.BronzeArmor_IronSword;
                        break;
                }
            else if (selectedArmor.armorName == "Iron Armor")
                switch (selectedWeapon.weaponName)
                {
                    case "Wooden Sword":
                        pbPlayer.BackgroundImage = Properties.Resources.IronArmor_WoodenSword;
                        break;
                    case "Iron Sword":
                        pbPlayer.BackgroundImage = Properties.Resources.IronArmor_IronSword;
                        break;
                }
            btnLevelUp.Enabled = true;
        }

        private void btnBattle1_Click(object sender, EventArgs e)
        {
            showStage();
        }

        private void btnRand2_Click(object sender, EventArgs e)
        {
            if (r.Next(1, 3) == 1)
            {
                showStage();
            }
            else
                skipStage();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            hideStage();
            stageIsClear();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            playerAttack();
            if (p.t == 1)
            {
                enemyAttack();
            }
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
                Map m = new Map(ref p);
                this.Hide();
                m.Show();
            }

            restartGame();
        }

        private void btnBoss_Click(object sender, EventArgs e)
        {
            pbEnemy.BackgroundImage = Properties.Resources.MenacingPikl;
            p.enemyMaxHP = 30;
            p.enemyHP = 30;
            p.playerHP = p.playerHP + 20;
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

        private void btnDefend_Click(object sender, EventArgs e)
        {
            p.defend = true;
            /*switch (selectedArmor.armorName)
            {
                case "Bronze Armor":
                    defense = p.armors.BA.armorDefense / 2;
                    break;
                case "Iron Armor":
                    defense = p.armors.IA.armorDefense / 2;
                    break;
            }*/
            defense = selectedArmor.armorDefense/2;
            enemyAttack();
        }
    }
}
