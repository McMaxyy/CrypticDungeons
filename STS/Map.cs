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

        public void startStage()
        {
            STS s = new STS(selectedWeapon, selectedArmor, boss, mob1, mob2, mob3, specialMob, ref p);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Map(Weapons sword, Armor armor, ref Podatki p)
        {
            InitializeComponent();
            this.p = p;

            selectedArmor = armor;
            selectedWeapon = sword;
        }

        private void btnStage1_Click(object sender, EventArgs e)
        {
            boss = p.bosses.menacingPikl;
            //Type[] mobList = Assembly.GetAssembly(typeof(Mob)).GetTypes().Where(TheType => TheType.IsClass && !TheType.IsAbstract && TheType.IsSubclassOf(typeof(Mob))).ToArray();            
            mob1 = p.mobs.pikle;
            mob2 = p.mobs.pikle;
            mob3 = p.mobs.jerry;
            specialMob = p.mobs.jerry;
            p.expAdd = 0;
            startStage();
        }

        private void btnStage2_Click(object sender, EventArgs e)
        {
            boss = p.bosses.goblinKing;
            mob1 = p.mobs.smolGoblin;
            mob2 = p.mobs.spearGoblin;
            mob3 = p.mobs.spaceGoblin;
            specialMob = p.mobs.cyclops;
            p.expAdd = 2;
            startStage();
        }
    }
}
