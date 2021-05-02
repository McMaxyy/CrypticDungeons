using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace STS
{
    public partial class Start : Form
    {
        Podatki p;
        Weapons weapon;
        Armor armor;

        public Start(ref Podatki p)
        {           
            InitializeComponent();
            this.p = p;
        }

        //Start new game
        private void btnStart_Click(object sender, EventArgs e)
        {
            weapon = p.weapons.woodenS;
            armor = p.armors.bronzeA;           
            Home h = new Home(weapon, armor, ref p);
            h.Width = this.Width;
            h.Height = this.Height;
            h.StartPosition = FormStartPosition.Manual;
            h.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            h.ShowDialog();           
        }

        //Load JSON save game
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                p.saveName = Path.GetFullPath(openFileDialog1.FileName);
                JsonConvert.PopulateObject(File.ReadAllText(p.saveName), this.p);

                weapon = p.weapons.woodenS;
                armor = p.armors.bronzeA;
                Home h = new Home(weapon, armor, ref p);
                h.Width = this.Width;
                h.Height = this.Height;
                h.StartPosition = FormStartPosition.Manual;
                h.Location = new Point(this.Location.X, this.Location.Y);
                this.Visible = false;
                h.ShowDialog();
            }
        }

        //Close the game
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
