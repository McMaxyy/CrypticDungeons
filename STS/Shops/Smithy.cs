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
            if (p.recipes.dinoS.isCraftable(ref p) == true && p.weapons.dinoS.isObtained == false)
                btnCraftDinoS.Enabled = true;
            else
                btnCraftDinoS.Enabled = false;

            if (p.recipes.dinoA.isCraftable(ref p) == true && p.armors.dinoA.isObtained == false)
                btnCraftDinoA.Enabled = true;
            else
                btnCraftDinoA.Enabled = false;

            if (p.recipes.monkeM.isCraftable(ref p) == true && p.weapons.monkeM.isObtained == false)
                btnCraftMonkeM.Enabled = true;
            else
                btnCraftMonkeM.Enabled = false;

            if (p.recipes.monkeA.isCraftable(ref p) == true && p.armors.monkeA.isObtained == false)
                btnCraftMonkeA.Enabled = true;
            else
                btnCraftMonkeA.Enabled = false;

            if (p.recipes.goblinS.isCraftable(ref p) == true && p.weapons.goblinS.isObtained == false)
                btnCraftGS.Enabled = true;
            else
                btnCraftGS.Enabled = false;

            if (p.recipes.goblinA.isCraftable(ref p) == true && p.armors.goblinA.isObtained == false)
                btnCraftGA.Enabled = true;
            else
                btnCraftGA.Enabled = false;

            if (p.recipes.pickleS.isCraftable(ref p) == true && p.weapons.pickleS.isObtained == false)
                btnCraftPSword.Enabled = true;
            else
                btnCraftPSword.Enabled = false;

            if (p.recipes.pickleA.isCraftable(ref p) == true && p.armors.pickleA.isObtained == false)
                btnCraftPArmor.Enabled = true;
            else
                btnCraftPArmor.Enabled = false;
        }

        public void updateMaterials()
        {
            lblPickleS.Text = "Pickle Juice: " + p.inventory.requiredMaterials(0) + "/2" + Environment.NewLine + "Pickle Skin: " + p.inventory.requiredMaterials(1) + "/2";
            lblPickleA.Text = "Pickle Juice: " + p.inventory.requiredMaterials(0) + "/1" + Environment.NewLine + "Pickle Skin: " + p.inventory.requiredMaterials(1) + "/4";
            lblGoblinS.Text = "Goblin Skull: " + p.inventory.requiredMaterials(2) + "/3" + Environment.NewLine + "Goblin Hide: " + p.inventory.requiredMaterials(3) + "/3";
            lblGoblinA.Text = "Goblin Skull: " + p.inventory.requiredMaterials(2) + "/2" + Environment.NewLine + "Goblin Hide: " + p.inventory.requiredMaterials(3) + "/5";
            lblMonkeM.Text = "Monke Bones: " + p.inventory.requiredMaterials(4) + "/4" + Environment.NewLine + "Monke Carapace: " + p.inventory.requiredMaterials(5) + "/3";
            lblMonkeA.Text = "Monke Bones: " + p.inventory.requiredMaterials(4) + "/4" + Environment.NewLine + "Monke Carapace: " + p.inventory.requiredMaterials(5) + "/5";
            lblDinoS.Text = "Dino Teeth: " + p.inventory.requiredMaterials(6) + "/3" + Environment.NewLine + "Dino Claws: " + p.inventory.requiredMaterials(7) + "/4";
            lblDinoA.Text = "Dino Teeth: " + p.inventory.requiredMaterials(6) + "/4" + Environment.NewLine + "Dino Claws: " + p.inventory.requiredMaterials(7) + "/6" + Environment.NewLine + "Dino Tail: " + p.inventory.requiredMaterials(8) + "/1";
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
            p.weapons.pickleS.isObtained = true;
            p.recipes.pickleS.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedWeapon = p.weapons.pickleS;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftPArmor_Click(object sender, EventArgs e)
        {
            p.armors.pickleA.isObtained = true;
            p.recipes.pickleA.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedArmor = p.armors.pickleA;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftGS_Click(object sender, EventArgs e)
        {
            p.weapons.goblinS.isObtained = true;
            p.recipes.goblinS.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedWeapon = p.weapons.goblinS;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftGA_Click(object sender, EventArgs e)
        {
            p.armors.goblinA.isObtained = true;
            p.recipes.goblinA.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedArmor = p.armors.goblinA;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftMonkeM_Click(object sender, EventArgs e)
        {
            p.weapons.monkeM.isObtained = true;
            p.recipes.monkeM.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedWeapon = p.weapons.monkeM;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftMonkeA_Click(object sender, EventArgs e)
        {
            p.armors.monkeA.isObtained = true;
            p.recipes.monkeA.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedArmor = p.armors.monkeA;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftDinoS_Click(object sender, EventArgs e)
        {
            p.weapons.dinoS.isObtained = true;
            p.recipes.dinoS.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedWeapon = p.weapons.dinoS;
            showEquipment();
            isCraftable();
            updateMaterials();
        }

        private void btnCraftDinoA_Click(object sender, EventArgs e)
        {
            p.armors.dinoA.isObtained = true;
            p.recipes.dinoA.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedArmor = p.armors.dinoA;
            showEquipment();
            isCraftable();
            updateMaterials();
        }
    }
}