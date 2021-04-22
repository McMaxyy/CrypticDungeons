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
    public partial class Map : Form
    {
        Podatki p;
        Weapons selectedWeapon;
        Armor selectedArmor;
        Boss boss;
        Mob mob1, mob2, mob3, specialMob;

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
                btnEndless.Enabled = true;
            }
        }

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

        

        public Map(Weapons sword, Armor armor, ref Podatki p)
        {
            InitializeComponent();
            this.p = p;

            checkIfLevelUnlocked();
            selectedArmor = armor;
            selectedWeapon = sword;
        }

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
