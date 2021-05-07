using System;
using System.Drawing;
using System.Windows.Forms;

namespace STS
{
    public partial class STS : Form
    {
        int yy, xx, defense, goblinCount = 0, specialExp = 0, fireCount = 0, foodDmg = 0;
        bool enemyDefeated, bossStage, isRageActive, specialStage, fireAttack;
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
            if (bossStage == true)
                btnFlee.Enabled = false;

            lblDmg1.Text = "You dealt: ";
            lblDmg2.Text = "Enemy dealt: ";
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
            lblPlayerHP.Text = "HP: " + p.playerHP + "/" + p.playerMaxHP;
            lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox || x is Button || x is Label && x.Visible == false)
                {
                    if (x != pbSkip && x != btnSkip && x != lblSkip && x != lblLost && x != btnRestart && 
                        x != pbCleared && x != lblCleared && x != btnCleared &&
                        x != pbLevelUp && x != btnLevelUp && x != lblLevelUp && x != lblStrDef && 
                        x != lblPoints && x != btnStr && x != btnDef)
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
            p.enemyHP = 0;
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;

            btnAttack.Enabled = btnDefend.Enabled = btnFlee.Enabled = false;
            goblinCount = 0;

            //Add coins, exp, levels, max player HP, points if level up
            p.coins = p.coins + p.newCoins;
            p.exp = p.exp + p.expAdd + 3 + specialExp;
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
            }

            //Check what stage's been completed and unlock the next one + check if level up
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
                btnBattle3.Enabled = btnRand5.Enabled = btnSpecial.Enabled = true;
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
                btnBattle3.Enabled = btnRand5.Enabled = btnSpecial.Enabled = false;
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

                if (specialStage == true && p.stageRank == 2 && p.weapons.monkeM.isUnlocked == false && p.armors.monkeA.isUnlocked == false 
                    && selectedArmor == p.armors.goblinA || selectedArmor == p.armors.pickleA && selectedWeapon == p.weapons.goblinS || selectedWeapon == p.weapons.pickleS)
                    p.inventory.addItem(11, 1);
                else if (specialStage == true && p.stageRank == 3)
                    p.inventory.addItem(11, 1);
            }
            else if (p.n == 4)
            {
                //Drop boss materials to player
                yy = r.Next(0, selectedBoss.dropTable.Length);
                xx = r.Next(1, 4);
                p.inventory.addItem(selectedBoss.dropTable[yy], xx);

                switch (selectedBoss.bossID)
                {
                    case 0:
                        p.inventory.showItem(yy);
                        break;
                    case 1:
                        p.inventory.showItem(yy + 2);
                        break;
                    case 2:
                        p.inventory.showItem(yy + 4);
                        break;
                }

                if (p.level == p.newLevel)
                {
                    btnStr.Enabled = btnDef.Enabled = true;
                    lblPoints.Text = "Unused points: " + p.points;
                    pbLevelUp.Visible = btnDef.Visible = btnStr.Visible = btnLevelUp.Visible = lblStrDef.Visible = lblPoints.Visible = lblLevelUp.Visible = true;
                    p.newLevel++;
                }

                lblYY.Visible = true;
                btnLevelUp.Enabled = false;
                lblExp.Text = "EXP: " + p.exp + "/" + p.maxExp;
                lblYY.Text = "You got: " + xx + "x " + p.inventory.itemShow;
                btnBoss.Enabled = false;
                lblLost.Text = "You won";
                lblLost.Visible = true;
                btnRestart.Visible = true;
                p.cleared = true;
            }
            p.n++;
            p.skipped = false;
            specialExp = 0;
        }
        public void stageNotClear()
        {
            lblLost.Visible = true;
            btnRestart.Visible = true;
            btnAttack.Enabled = btnDefend.Enabled = btnFlee.Enabled = false;
            p.bossStage = false;
            specialExp = 0;
        }

        //Battle phase
        public void playerAttack()
        {
            int x;

            x = p.str / 2 + r.Next(selectedWeapon.weaponDmgMin, selectedWeapon.weaponDmgMax + 1) + foodDmg;
            if (isRageActive == true)
            {
                x += 3;
                isRageActive = false;
            }

            p.enemyHP = p.enemyHP - x;
            lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
            lblDmg1.Text = "You dealt: " + x + " damage";
            lblDmg1.Visible = true;
            lblDmg2.Visible = true;
            if (p.enemyHP < 1)
            {   
                enemyDefeated = true;
                stageIsClear();
            }
        }
        public void enemyAttack()
        {
            if (p.bossStage == true)
                p.y = r.Next(selectedBoss.minDmgBoss, selectedBoss.maxDmgBoss + 1);
            else if (specialStage == true)
                p.y = r.Next(specialMob.minMobDmg, specialMob.maxMobDmg + 1);
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

            xx = (int)p.y;

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

            lblYY.Text = "";
            btnLevelUp.Enabled = true;
            p.n = 1;

            if (p.didPlayerEat == true)
                foodDmg = p.stageRank;
            else
                foodDmg = 0;
        }

        //Battle button
        private void btnBattle1_Click(object sender, EventArgs e)
        {
            selectMob();
            setMobStats();
            showStage();
        }

        //Random "?" button
        private void btnRand2_Click(object sender, EventArgs e)
        {
            yy = r.Next(10);
            if (yy <= 2)
            {
                skipStage();
            }
            else if (yy == 3 && yy == 4)
            {
                p.playerHP += 10;
                if (p.playerHP > p.playerMaxHP)
                    p.playerHP = p.playerMaxHP;

                skipStage();
            }
            else
            {
                selectMob();
                setMobStats();
                showStage();
            }
        }

        //Skip button
        private void btnSkip_Click(object sender, EventArgs e)
        {
            hideStage();
            stageIsClear();
        }

        //Special enemy button
        private void btnSpecial_Click(object sender, EventArgs e)
        {
            specialStage = true;
            p.newCoins = specialMob.coinValue;
            p.enemyMaxHP = specialMob.maxMobHP;
            pbEnemy.BackgroundImage = specialMob.mobImage;
            p.enemyHP = p.enemyMaxHP;
            specialExp = 4;
            showStage();
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
                enemyDefeated = false;

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
                lblDmg1.Text = "You burned the enemy for 5 extra damage";
            }

            if (selectedWeapon == p.weapons.dinoS && fireCount == 0)
            {
                fireAttack = false;
                pbSword.BackgroundImage = Properties.Resources.DinoSword_Equip;
            }
        }

        //Run away button
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

        //Restart button
        private void btnRestart_Click(object sender, EventArgs e)
        {
            bossStage = false;
            Home m = new Home(selectedWeapon, selectedArmor, ref p);
            m.Width = this.Width;
            m.Height = this.Height;
            m.StartPosition = FormStartPosition.Manual;
            m.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            m.ShowDialog();
        }

        //Boss button
        private void btnBoss_Click(object sender, EventArgs e)
        {
            pbEnemy.BackgroundImage = selectedBoss.bossImage;
            p.enemyMaxHP = selectedBoss.bossMaxHP;
            p.newCoins = selectedBoss.coinValue;
            p.expAdd += 2;

            p.enemyHP = p.enemyMaxHP;

            p.playerHP = p.playerHP + 10;
            if (p.playerHP > p.playerMaxHP)
                p.playerHP = p.playerMaxHP;

            bossStage = true;
            showStage();
        }

        private void btnCleared_Click(object sender, EventArgs e)
        {
            hideStage();
        }

        //Buttons for adding player attributes
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
            m.Width = this.Width;
            m.Height = this.Height;
            m.StartPosition = FormStartPosition.Manual;
            m.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            m.ShowDialog();
        }
        
        //Parry button
        private void btnDefend_Click(object sender, EventArgs e)
        {
            p.defend = true;
            defense = selectedArmor.armorDefense/2;
            enemyAttack();
            yy = r.Next(10);
            if (yy >= 0 && yy <= 2)
            {
                p.enemyHP = p.enemyHP - xx;
                lblEnemyHP.Text = "HP: " + p.enemyHP + "/" + p.enemyMaxHP;
                lblDmg1.Text = "You parried, dealing: " + xx + " damage";
            }

            if (p.enemyHP < 1)
            {
                enemyDefeated = true;
                stageIsClear();
            }
        }
    }
}
