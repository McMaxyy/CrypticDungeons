using System;
using System.Drawing;
using System.Windows.Forms;

namespace STS
{
    public partial class Shop : Form
    {
        Podatki p;
        Weapons selectedWeapon;
        Armor selectedArmor;

        //Function that locks the "buy" buttons after the player's made a purchase
        public void lockButtons()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button)
                {
                    if ((string)x.Tag == "Buy")
                    {
                        x.Enabled = false;
                    }
                }
            }
        }

        //Function that checks if the player has enough coins to purchase the piece of equipment
        public void isAvailable()
        {
            if (p.coins >= p.weapons.ironS.coinValue && p.weapons.ironS.isObtained == false)
                btnBuyIronS.Enabled = true;
            if (p.coins >= p.armors.ironA.coinValue && p.armors.ironA.isObtained == false)
                btnBuyIronA.Enabled = true;
        }

        public Shop(Weapons weapon, Armor armor, ref Podatki p)
        {
            InitializeComponent();
            this.p = p;
            selectedWeapon = weapon;
            selectedArmor = armor;

            isAvailable();
            lblCoins.Text = "Available Coins: " + p.coins;
        }

        private void btnBuyIronS_Click(object sender, EventArgs e)
        {
            selectedWeapon = p.weapons.ironS;
            p.coins = p.coins - 35;
            lblCoins.Text = "Available Coins: " + p.coins;
            btnBuyIronS.Enabled = false;
            p.weapons.ironS.isObtained = true;
            p.weapons.ironS.isUnlocked = true;
            lockButtons();
            isAvailable();
        }

        private void btnBuyIronA_Click(object sender, EventArgs e)
        {
            selectedArmor = p.armors.ironA;
            p.coins = p.coins - 60;
            lblCoins.Text = "Available Coins: " + p.coins;
            btnBuyIronA.Enabled = false;
            p.armors.ironA.isObtained = true;
            p.armors.ironA.isUnlocked = true;
            lockButtons();
            isAvailable();
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
