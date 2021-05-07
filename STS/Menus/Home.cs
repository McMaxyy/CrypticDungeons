using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace STS
{
    public partial class Home : Form
    {
        Podatki p;
        Weapons weapon;
        Armor armor;

        //Function that shows equiped gear 
        public void showEquipment()
        {
            pbPlayer.BackgroundImage = armor.armorImage;
            pbSword.BackgroundImage = weapon.weaponImage;
        }

        //Function that checks which piece of equipment you have
        public void isUnlocked()
        {
            if (p.weapons.ironS.isUnlocked == true)
            {
                btnIS.Enabled = true;
                btnIS.BackColor = Color.DarkSlateGray;
            }
            if (p.armors.ironA.isUnlocked == true)
            {
                btnIA.Enabled = true;
                btnIA.BackColor = Color.DarkSlateGray;
            }
            if (p.weapons.pickleS.isUnlocked == true)
            {
                btnPS.Enabled = true;
                btnPS.BackColor = Color.DarkSlateGray;
            }
            if (p.armors.pickleA.isUnlocked == true)
            {
                btnPA.Enabled = true;
                btnPA.BackColor = Color.DarkSlateGray;
            }
            if (p.weapons.goblinS.isUnlocked == true)
            {
                btnGS.Enabled = true;
                btnGS.BackColor = Color.DarkSlateGray;
            }
            if (p.armors.goblinA.isUnlocked == true)
            {
                btnGA.Enabled = true;
                btnGA.BackColor = Color.DarkSlateGray;
            }
            if (p.weapons.dinoS.isUnlocked == true)
            {
                btnDS.Enabled = true;
                btnDS.BackColor = Color.DarkSlateGray;
            }
            if (p.armors.dinoA.isUnlocked == true)
            {
                btnDA.Enabled = true;
                btnDA.BackColor = Color.DarkSlateGray;
            }
        }

        //Function that shows equipment
        public void showAvailableEquipment()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Visible == false)
                {
                    if ((string)x.Tag == "Equipment" || (string)x.Tag == "Equipment1")
                    {
                        x.Visible = true;
                    }
                }
            }
        }

        //Function that hides equipment
        public void hideAvailableEquipment()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Visible == true)
                {
                    if ((string)x.Tag == "Equipment" || (string)x.Tag == "Equipment1" || (string)x.Tag == "Equipment2")
                    {
                        x.Visible = false;
                    }
                }
            }
        }

        //Function that shows stats
        public void showStats()
        {
            lblStats.Text = "Attack: " + (p.str + (weapon.weaponDmgMax + weapon.weaponDmgMin) / 2) + " || Defense: " + (p.def + armor.armorDefense);
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
            showStats();

            p.didPlayerEat = false;
            lblFood.Text = "Available meat: " + p.items.meat.itemQuantity;
            if (p.items.meat.itemQuantity > 0)
                btnCook.Enabled = true;
        } 

        //Buttons that choose worn equipment
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
        private void btnMM_Click(object sender, EventArgs e)
        {
            weapon = p.weapons.monkeM;
            showEquipment();
        }
        private void btnMA_Click(object sender, EventArgs e)
        {
            armor = p.armors.monkeA;
            showEquipment();
        }
        private void btnDS_Click(object sender, EventArgs e)
        {
            weapon = p.weapons.dinoS;
            showEquipment();
        }
        private void btnDA_Click(object sender, EventArgs e)
        {
            armor = p.armors.dinoA;
            showEquipment();
        }

        //Button for showing/hiding equipment
        private void btnEquipment_Click(object sender, EventArgs e)
        {
            if (btnBA.Visible == false)
            {
                showAvailableEquipment();
            }
            else if (btnBA.Visible == true || btnDA.Visible == true)
            {
                hideAvailableEquipment();
                btnNext.BackgroundImage = Properties.Resources.Next;
            }

        }

        //Button for showing/hiding inventory
        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (lblItems.Visible == false)
            {
                lblItems.Visible = lblCoins.Visible = true;
                lblItems.Text = p.inventory.toString();
                lblCoins.Text = "Available coins:" + p.coins;
            }
            else
            {
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

        private void updateStats(object sender, MouseEventArgs e)
        {
            showStats();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Visible == false)
                {
                    if ((string)x.Tag == "Equipment2")
                    {
                        x.Visible = true;
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Visible == true)
                {
                    if ((string)x.Tag == "Equipment1")
                    {
                        x.Visible = false;
                    }
                }
            }             
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Visible == false)
                {
                    if ((string)x.Tag == "Equipment1")
                    {
                        x.Visible = true;
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Visible == true)
                {
                    if ((string)x.Tag == "Equipment2")
                    {
                        x.Visible = false;
                    }
                }
            }
        }

        //JSON serialization and deserialization
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (p.saveName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    p.saveName = Path.GetFullPath(saveFileDialog1.FileName);
                }
            }

            if(p.saveName != "")
                File.WriteAllText(p.saveName, JsonConvert.SerializeObject(p));
        }

        private void saveNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                p.saveName = Path.GetFullPath(saveFileDialog1.FileName);
                File.WriteAllText(p.saveName, JsonConvert.SerializeObject(p));
            }
        }

        private void btnCook_Click(object sender, EventArgs e)
        {
            p.items.meat.itemQuantity--;
            lblFood.Text = "Available meat: " + p.items.meat.itemQuantity;
            p.didPlayerEat = true;
            btnCook.Enabled = false;
        }
    }
}
