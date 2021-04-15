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
        Boss boss;
        Mob mob1, mob2, mob3, specialMob;

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


        public Home(Weapons selectedWeapon, Armor selectedArmor, ref Podatki p)
        {
            InitializeComponent();
            lblItems.Text = p.inventory.toString();

            this.p = p;
            weapon = selectedWeapon;
            armor = selectedArmor;
            showEquipment();
            isUnlocked();
        } 

        private void btnStage1_Click(object sender, EventArgs e)
        {             
            boss = p.bosses.menacingPikl;
            mob1 = p.mobs.pikle;
            mob2 = p.mobs.pikle;
            mob3 = p.mobs.jerry;
            specialMob = p.mobs.jerry;
            p.expAdd = 0;
            showAvailableEquipment();
        }
        private void btnStage2_Click(object sender, EventArgs e)
        {
            boss = p.bosses.goblinKing;
            mob1 = p.mobs.smolGoblin;
            mob2 = p.mobs.spearGoblin;
            mob3 = p.mobs.spaceGoblin;
            specialMob = p.mobs.cyclops;
            p.expAdd = 2;
            showAvailableEquipment();
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

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            STS s = new STS(weapon, armor, boss, mob1, mob2, mob3, specialMob, ref p);
            s.Show();
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

        private void btnPA_Click(object sender, EventArgs e)
        {
            armor = p.armors.pickleA;
            showEquipment();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop s = new Shop(weapon, armor, ref p);
            s.Show();
        }

        private void btnCraft_Click(object sender, EventArgs e)
        {
            this.Hide();
            Smithy s = new Smithy(weapon, armor, ref p);
            s.Show();
        } 
    }
}
