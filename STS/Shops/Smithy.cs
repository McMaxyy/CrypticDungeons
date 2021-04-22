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
            btnCraftGS.Enabled = p.recipes.goblinS.isCraftable(ref p);
            btnCraftGA.Enabled = p.recipes.goblinA.isCraftable(ref p);
            btnCraftMonkeA.Enabled = p.recipes.monkeA.isCraftable(ref p);
            btnCraftMonkeM.Enabled = p.recipes.monkeM.isCraftable(ref p);
        }

        public void updateMaterials()
        {
            lblPickleS.Text = "Pickle Juice: " + p.inventory.requiredMaterials(0) + "/2" + Environment.NewLine + "Pickle Skin: " + p.inventory.requiredMaterials(1) + "/2";
            lblPickleA.Text = "Pickle Juice: " + p.inventory.requiredMaterials(0) + "/1" + Environment.NewLine + "Pickle Skin: " + p.inventory.requiredMaterials(1) + "/4";
            lblGoblinS.Text = "Goblin Skull: " + p.inventory.requiredMaterials(2) + "/3" + Environment.NewLine + "Goblin Hide: " + p.inventory.requiredMaterials(3) + "/3";
            lblGoblinA.Text = "Goblin Skull: " + p.inventory.requiredMaterials(2) + "/2" + Environment.NewLine + "Goblin Hide: " + p.inventory.requiredMaterials(3) + "/5";
            lblMonkeM.Text = "Monke Bones: " + p.inventory.requiredMaterials(4) + "/4" + Environment.NewLine + "Monke Carapace: " + p.inventory.requiredMaterials(5) + "/3";
            lblMonkeA.Text = "Monke Bones: " + p.inventory.requiredMaterials(4) + "/4" + Environment.NewLine + "Monke Carapace: " + p.inventory.requiredMaterials(5) + "/5";
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
            updateMaterials();
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

        private void btnCraftPSword_Click(object sender, EventArgs e)
        {
            p.recipes.pickleS.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedWeapon = p.weapons.pickleS;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftPArmor_Click(object sender, EventArgs e)
        {
            p.recipes.pickleA.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedArmor = p.armors.pickleA;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftGS_Click(object sender, EventArgs e)
        {
            p.recipes.goblinS.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedWeapon = p.weapons.goblinS;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftGA_Click(object sender, EventArgs e)
        {
            p.recipes.goblinA.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedArmor = p.armors.goblinA;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftMonkeM_Click(object sender, EventArgs e)
        {
            p.recipes.monkeM.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedWeapon = p.weapons.monkeM;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftMonkeA_Click(object sender, EventArgs e)
        {
            p.recipes.monkeA.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedArmor = p.armors.monkeA;
            showEquipment();
            isCraftable();
            updateMaterials();
        }
    }
}