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
        Weapons weapon;
        Armor armor;
        Boss boss;
        Random r = new Random();

        public void showEquipment()
        {
            if (armor.armorName == "Bronze Armor")
                switch (weapon.weaponName)
                {
                    case "Wooden Sword":
                        pbPlayer.BackgroundImage = Properties.Resources.BronzeArmor_WoodenSword;
                        break;
                    case "Iron Sword":
                        pbPlayer.BackgroundImage = Properties.Resources.BronzeArmor_IronSword;
                        break;
                }
            else if (armor.armorName == "Iron Armor")
                switch (weapon.weaponName)
                {
                    case "Wooden Sword":
                        pbPlayer.BackgroundImage = Properties.Resources.IronArmor_WoodenSword;
                        break;
                    case "Iron Sword":
                        pbPlayer.BackgroundImage = Properties.Resources.IronArmor_IronSword;
                        break;
                }
        }

        public Map(Weapons selectedWeapon, Armor selectedArmor, ref Podatki p)
        {
            InitializeComponent();
            this.p = p;
            weapon = selectedWeapon;
            armor = selectedArmor;
            showEquipment();
        } 

        private void btnStage1_Click(object sender, EventArgs e)
        {             
            if (p.weapons.ironS.isUnlocked == true)
                btnIS.Enabled = true;
            if (p.armors.ironA.isUnlocked == true)
                btnIA.Enabled = true;

            boss = p.bosses.menacingPikl;

            btnWS.Visible = true;
            btnIS.Visible = true;
            btnBA.Visible = true;
            btnIA.Visible = true;
            btnGo.Visible = true;
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
            STS s = new STS(weapon, armor, boss, ref p);
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

        private void btnStage2_Click(object sender, EventArgs e)
        {
            if (p.weapons.ironS.isUnlocked == true)
                btnIS.Enabled = true;
            if (p.armors.ironA.isUnlocked == true)
                btnIA.Enabled = true;

            boss = p.bosses.pikl;

            btnWS.Visible = true;
            btnIS.Visible = true;
            btnBA.Visible = true;
            btnIA.Visible = true;
            btnGo.Visible = true;
        }
    }
}
