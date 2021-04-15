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
    public partial class Smithy : Form
    {
        Weapons selectedWeapon;
        Armor selectedArmor;
        Podatki p;

        public void showEquipment()
        {
            pbPlayer.BackgroundImage = selectedArmor.armorImage;
            pbSword.BackgroundImage = selectedWeapon.weaponImage;
        }

        public void isCraftable()
        {
            btnCraftPSword.Enabled = p.recipes.pickleS.isCraftable(ref p);
            btnCraftPArmor.Enabled = p.recipes.pickleA.isCraftable(ref p);
        }

        public Smithy(Weapons weapon, Armor armor, ref Podatki p)
        {            
            InitializeComponent();
            this.p = p;

            selectedArmor = armor;
            selectedWeapon = weapon;
            showEquipment();
            lblItems.Text = p.inventory.toString();
            isCraftable();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Home h = new Home(selectedWeapon, selectedArmor, ref p);
            this.Hide();
            h.Show();           
        }

        private void btnCraftPSword_Click(object sender, EventArgs e)
        {
            p.recipes.pickleS.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedWeapon = p.weapons.pickleS;
            showEquipment();
            isCraftable();
        }

        private void btnCraftPArmor_Click(object sender, EventArgs e)
        {
            p.recipes.pickleA.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedArmor = p.armors.pickleA;
            showEquipment();
            isCraftable();
        }
    }
}
