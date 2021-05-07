using System;
using System.Drawing;
using System.Windows.Forms;

namespace STS
{
    public partial class Map : Form
    {
        Podatki p;
        Weapons selectedWeapon;
        Armor selectedArmor;
        Boss boss;
        Mob mob1, mob2, mob3, specialMob;

        //Function for checking whether the player's unlocked the required items to go to the next stage
        public void checkIfLevelUnlocked()
        {
            if (p.weapons.pickleS.isUnlocked == true && p.armors.pickleA.isUnlocked == true)
            {
                btnMidGrind.Enabled = true;
                btnStage2.Enabled = true;
            }

            if (p.weapons.goblinS.isUnlocked == true && p.armors.goblinA.isUnlocked == true)
            {
                btnHighGrind.Enabled = true;
                btnStage3.Enabled = true;
            }

            if (p.weapons.monkeM.isUnlocked == true && p.armors.monkeA.isUnlocked == true)
            {
                btnFinalBoss.Enabled = true;
                btnEndless.Enabled = true;
            }
        }

        //Function that sends the player to the main stage
        public void startMain()
        {
            STS s = new STS(selectedWeapon, selectedArmor, boss, mob1, mob2, mob3, specialMob, ref p);
            s.Width = this.Width;
            s.Height = this.Height;
            s.StartPosition = FormStartPosition.Manual;
            s.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            s.ShowDialog();
        }

        //Function that sends the player to the grind stage
        public void startGrind()
        {
            Grind s = new Grind(selectedWeapon, selectedArmor, ref p);
            s.Width = this.Width;
            s.Height = this.Height;
            s.StartPosition = FormStartPosition.Manual;
            s.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            s.ShowDialog();
        } 

        public Map(Weapons sword, Armor armor, ref Podatki p)
        {
            InitializeComponent();
            this.p = p;

            checkIfLevelUnlocked();
            selectedArmor = armor;
            selectedWeapon = sword;
        }

        //Function that sends the player to the endless stage
        private void btnEndless_Click(object sender, EventArgs e)
        {
            Endless s = new Endless(selectedWeapon, selectedArmor, ref p);
            s.Width = this.Width;
            s.Height = this.Height;
            s.StartPosition = FormStartPosition.Manual;
            s.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            s.ShowDialog();
        }

        //Buttons that set the stage rank, so that the grind stage selects correct enemies
        private void btnLowGrind_Click(object sender, EventArgs e)
        {
            p.stageRank = 1;
            startGrind();
        }
        private void btnMidGrind_Click(object sender, EventArgs e)
        {
            p.stageRank = 2;
            startGrind();
        }
        private void btnHighGrind_Click(object sender, EventArgs e)
        {
            p.stageRank = 3;
            startGrind();
        }

        //Return to the home screen
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

        //Stage buttons that send over the correct enemies for the stage
        private void btnFinalBoss_Click(object sender, EventArgs e)
        {
            boss = p.bosses.zavr;
            FinalBoss m = new FinalBoss(selectedWeapon, selectedArmor, boss, ref p);
            m.Width = this.Width;
            m.Height = this.Height;
            m.StartPosition = FormStartPosition.Manual;
            m.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            m.ShowDialog();
        }

        private void btnHunting_Click(object sender, EventArgs e)
        {
            Hunting m = new Hunting(selectedWeapon, selectedArmor, ref p);
            m.Width = this.Width;
            m.Height = this.Height;
            m.StartPosition = FormStartPosition.Manual;
            m.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            m.ShowDialog();
        }

        private void btnStage1_Click(object sender, EventArgs e)
        {
            boss = p.bosses.menacingPikl;
            mob1 = p.mobs.pikle;
            mob2 = p.mobs.pikle;
            mob3 = p.mobs.jerry;
            specialMob = p.mobs.jerry;
            p.expAdd = 0;
            startMain();
        }

        private void btnStage2_Click(object sender, EventArgs e)
        {
            boss = p.bosses.goblinKing;
            mob1 = p.mobs.smolGoblin;
            mob2 = p.mobs.spearGoblin;
            mob3 = p.mobs.spaceGoblin;
            specialMob = p.mobs.cyclops;
            p.expAdd = 2;
            startMain();
        }

        private void btnStage3_Click(object sender, EventArgs e)
        {
            boss = p.bosses.smolMonkeBoss;
            mob1 = p.mobs.coolMonke;
            mob2 = p.mobs.strongMonke;
            mob3 = p.mobs.crossbowMonke;
            specialMob = p.mobs.gorilla;
            p.expAdd = 5;
            startMain();
        }
    }
}
