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
    public partial class Mining : Form
    {
        Podatki p;
        Weapons selectedWeapon;
        Armor selectedArmor;
        Random r = new Random();
        int rockHP, maxRockHP, yy, selectedOre, timesReqToHit;
        bool isCleared;

        

        public void attackRock()
        {
            rockHP -= 5;
            lblHP.Text = "HP: " + rockHP + "/" + maxRockHP;

            if (rockHP <= 0)
            {
                isCleared = true;
                lblHP.Text = "You've gained ore";
                p.inventory.addItem(selectedOre, 1);
                button1.Visible = button2.Visible = button3.Visible = false;
                if (selectedOre == 9)
                    pbRock.BackgroundImage = Properties.Resources.IronOre_Depleted;
                else
                    pbRock.BackgroundImage = Properties.Resources.MythrilOre_Depleted;
            }
        }

        

        public Mining(Weapons sword, Armor armor, ref Podatki p)
        {
            InitializeComponent();
            this.p = p;

            selectedArmor = armor;
            selectedWeapon = sword;

            yy = r.Next(10);
            if (yy == 9)
            {
                button1.BackColor = button2.BackColor = button3.BackColor = SystemColors.Desktop;
                pbRock.BackgroundImage = Properties.Resources.MythrilOre_New;
                selectedOre = 10;
                maxRockHP = 100;
                rockHP = 100;
                lblHP.Text = "HP: " + rockHP + "/" + maxRockHP;
            }
            else
            {
                button1.BackColor = button2.BackColor = button3.BackColor = SystemColors.ControlLight;
                pbRock.BackgroundImage = Properties.Resources.IronOre_New;
                selectedOre = 9;
                rockHP = 50;
                maxRockHP = 50;
                lblHP.Text = "HP: " + rockHP + "/" + maxRockHP;
            }

            timesReqToHit = r.Next(1, 4);

            yy = r.Next(3);
            switch (yy)
            {
                case 0:
                    button1.Visible = true;
                    break;
                case 1:
                    button2.Visible = true;
                    break;
                case 2:
                    button3.Visible = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timesReqToHit--;
            attackRock();
            if (timesReqToHit == 0)
            {
                button1.Visible = false;
                yy = r.Next(2);
                switch (yy)
                {
                    case 0:
                        button2.Visible = true;
                        break;
                    case 1:
                        button3.Visible = true;
                        break;
                }

                timesReqToHit = r.Next(1, 4);
            }

            if (isCleared == true)
                button1.Visible = button2.Visible = button3.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timesReqToHit--;
            attackRock();
            if (timesReqToHit == 0)
            {
                button2.Visible = false;
                yy = r.Next(2);
                switch (yy)
                {
                    case 0:
                        button1.Visible = true;
                        break;
                    case 1:
                        button3.Visible = true;
                        break;
                }

                timesReqToHit = r.Next(1, 4);
            }

            if (isCleared == true)
                button1.Visible = button2.Visible = button3.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timesReqToHit--;
            attackRock();
            if (timesReqToHit == 0)
            {
                button3.Visible = false;
                yy = r.Next(2);
                switch (yy)
                {
                    case 0:
                        button1.Visible = true;
                        break;
                    case 1:
                        button2.Visible = true;
                        break;
                }

                timesReqToHit = r.Next(1, 4);
            }

            if (isCleared == true)
                button1.Visible = button2.Visible = button3.Visible = false;
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
    }
}
