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
    public partial class Home : Form
    {
        Podatki p;
        Weapons weapon;
        Armor armor;

        public void showEquipment()
        {
            pbPlayer.BackgroundImage = armor.armorImage;
            pbSword.BackgroundImage = weapon.weaponImage;
        }
        public void isUnlocked()
        {
            if (p.weapons.ironS.isUnlocked == true)
                btnIS.Enabled = true;
            if (p.armors.ironA.isUnlocked == true)
                btnIA.Enabled = true;
            if (p.weapons.pickleS.isUnlocked == true)
                btnPS.Enabled = true;
            if (p.armors.pickleA.isUnlocked == true)
                btnPA.Enabled = true;
            if (p.weapons.goblinS.isUnlocked == true)
                btnGS.Enabled = true;
            if (p.armors.goblinA.isUnlocked == true)
                btnGA.Enabled = true;
        }

        public void showAvailableEquipment()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Visible == false)
                {
                    if ((string)x.Tag == "Equipment")
                    {
                        x.Visible = true;
                    }
                }
            }
        }

        public void hideAvailableEquipment()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Visible == true)
                {
                    if ((string)x.Tag == "Equipment")
                    {
                        x.Visible = false;
                    }
                }
            }
        }

        public Home(Weapons selectedWeapon, Armor selectedArmor, ref Podatki p)
        {
            InitializeComponent();            

            this.p = p;
            weapon = selectedWeapon;
            armor = selectedArmor;
            showEquipment();
            isUnlocked();

            lblLevel.Text = "Level: " + p.level;
            lblHP.Text = "HP: " + p.playerMaxHP;
            lblStats.Text = "Strength: " + p.str + " || Defense: " + p.def;
        } 

        private void btnWS_Click(object sender, EventArgs e)
        {
            weapon = p.weapons.woodenS;
            showEquipment();
        }

        private void btnIS_Click(object sender, EventArgs e)
        {
            weapon = p.weapons.ironS;
            showEquipment();
        }

        private void btnIA_Click(object sender, EventArgs e)
        {
            armor = p.armors.ironA;
            showEquipment();
        }

        private void btnBA_Click(object sender, EventArgs e)
        {
            armor = p.armors.bronzeA;
            showEquipment();
        }

        private void btnPS_Click(object sender, EventArgs e)
        {
            weapon = p.weapons.pickleS;
            showEquipment();
        }
        private void btnGS_Click(object sender, EventArgs e)
        {
            weapon = p.weapons.goblinS;
            showEquipment();
        }

        private void btnGA_Click(object sender, EventArgs e)
        {
            armor = p.armors.goblinA;
            showEquipment();
        }
        private void btnPA_Click(object sender, EventArgs e)
        {
            armor = p.armors.pickleA;
            showEquipment();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            if (btnBA.Visible == false)
            {
                showAvailableEquipment();
                btnEquipment.Text = "Hide Equipment";
            }
            else
            {
                hideAvailableEquipment();
                btnEquipment.Text = "Show Equipment";
            }

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (lblItems.Visible == false)
            {
                btnInventory.Text = "Hide Inventory";
                lblItems.Visible = lblCoins.Visible = true;
                lblItems.Text = p.inventory.toString();
                lblCoins.Text = "Available coins:" + p.coins;
            }
            else
            {
                btnInventory.Text = "Show Inventory";
                lblItems.Visible = lblCoins.Visible = false;
            }
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            Map m = new Map(weapon, armor, ref p);
            m.Width = this.Width;
            m.Height = this.Height;
            m.StartPosition = FormStartPosition.Manual;
            m.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            m.ShowDialog();

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            Shop s = new Shop(weapon, armor, ref p);
            s.Width = this.Width;
            s.Height = this.Height;
            s.StartPosition = FormStartPosition.Manual;
            s.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            s.ShowDialog();
        }

        private void btnCraft_Click(object sender, EventArgs e)
        {
            Smithy s = new Smithy(weapon, armor, ref p);
            s.Width = this.Width;
            s.Height = this.Height;
            s.StartPosition = FormStartPosition.Manual;
            s.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            s.ShowDialog();
        }       
    }
}
