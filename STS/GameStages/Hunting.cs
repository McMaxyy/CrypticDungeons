using System;
using System.Drawing;
using System.Windows.Forms;

namespace STS
{
    public partial class Hunting : Form
    {
        Random r = new Random();
        Podatki p;
        Weapons selectedWeapon;
        Armor selectedArmor;
        int counter = 1, xx, yy;

        public void randomizeButtonLocations()
        {
            xx = r.Next(20, 720);
            yy = r.Next(100, 580);

            button1.Location = new Point(xx, yy);
        }

        public void isClicked()
        {
            lblScore.Text = "Successful hits: " + (counter - 1) + "/11";
            switch (counter)
            {
                case 2: 
                case 3: 
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    randomizeButtonLocations();
                    break;
                case 12:
                    button1.Visible = false;
                    p.items.meat.itemQuantity++;
                    lblScore.Text = "You've gained meat";
                    break;
            }
        }

        public Hunting(Weapons weapon, Armor armor, ref Podatki p)
        {
            InitializeComponent();
            this.p = p;
            selectedWeapon = weapon;
            selectedArmor = armor;

            randomizeButtonLocations();

            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            isClicked();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Home h = new Home(selectedWeapon, selectedArmor, ref p);
            h.Width = this.Width;
            h.Height = this.Height;
            h.StartPosition = FormStartPosition.Manual;
            h.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            h.ShowDialog();
        }
    }
}
