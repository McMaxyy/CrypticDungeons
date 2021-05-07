using System;
using System.Drawing;
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

        //Function that checks if the item is craftable (depending on whether the player has enough materials and if they haven't already crafted it)
        public void isCraftable()
        {
            if (p.recipes.dinoS.isCraftable(ref p) == true && p.weapons.dinoS.isObtained == false)
            {
                btnCraftDinoS.Enabled = true;
                btnCraftDinoS.BackColor = Color.DarkSlateGray;
            }
            else
                btnCraftDinoS.Enabled = false;

            if (p.recipes.dinoA.isCraftable(ref p) == true && p.armors.dinoA.isObtained == false)
            {
                btnCraftDinoA.Enabled = true;
                btnCraftDinoA.BackColor = Color.DarkSlateGray;
            }
            else
                btnCraftDinoA.Enabled = false;

            if (p.recipes.monkeM.isCraftable(ref p) == true && p.weapons.monkeM.isObtained == false)
            {
                btnCraftMonkeM.Enabled = true;
                btnCraftMonkeM.BackColor = Color.DarkSlateGray;
            }
            else
                btnCraftMonkeM.Enabled = false;

            if (p.recipes.monkeA.isCraftable(ref p) == true && p.armors.monkeA.isObtained == false)
            {
                btnCraftMonkeA.Enabled = true;
                btnCraftMonkeA.BackColor = Color.DarkSlateGray;
            }
            else
                btnCraftMonkeA.Enabled = false;

            if (p.recipes.goblinS.isCraftable(ref p) == true && p.weapons.goblinS.isObtained == false)
            {
                btnCraftGS.Enabled = true;
                btnCraftGS.BackColor = Color.DarkSlateGray;
            }
            else
                btnCraftGS.Enabled = false;

            if (p.recipes.goblinA.isCraftable(ref p) == true && p.armors.goblinA.isObtained == false)
            {
                btnCraftGA.Enabled = true;
                btnCraftGA.BackColor = Color.DarkSlateGray;
            }
            else
                btnCraftGA.Enabled = false;

            if (p.recipes.pickleS.isCraftable(ref p) == true && p.weapons.pickleS.isObtained == false)
            {
                btnCraftPSword.Enabled = true;
                btnCraftPSword.BackColor = Color.DarkSlateGray;
            }
            else
                btnCraftPSword.Enabled = false;

            if (p.recipes.pickleA.isCraftable(ref p) == true && p.armors.pickleA.isObtained == false)
            {
                btnCraftPArmor.Enabled = true;
                btnCraftPArmor.BackColor = Color.DarkSlateGray;
            }
            else
                btnCraftPArmor.Enabled = false;
        }

        public void isUpgradable()
        {
            if (p.weapons.pickleS.isUnlocked == true && p.weapons.pickleS.enchLevel < 5 && p.inventory.requiredMaterials(11) >= 1 && p.coins >= 10)
                btnUpgradePS.Visible = true;
            else
                btnUpgradePS.Visible = false;

            if (p.weapons.goblinS.isUnlocked == true && p.weapons.goblinS.enchLevel < 5 && p.inventory.requiredMaterials(11) >= 1 && p.coins >= 20)
                btnUpgradeGS.Visible = true;
            else
                btnUpgradeGS.Visible = false;

            if (p.weapons.monkeM.isUnlocked == true && p.weapons.monkeM.enchLevel < 5 && p.inventory.requiredMaterials(11) >= 1 && p.coins >= 30)
                btnUpgradeMM.Visible = true;
            else
                btnUpgradeMM.Visible = false;

            if (p.weapons.dinoS.isUnlocked == true && p.weapons.dinoS.enchLevel < 5 && p.inventory.requiredMaterials(11) >= 1 && p.coins >= 40)
                btnUpgradeDS.Visible = true;
            else
                btnUpgradeDS.Visible = false;

            if (p.armors.pickleA.isUnlocked == true && p.armors.pickleA.enchLevel < 5 && p.inventory.requiredMaterials(11) >= 1 && p.coins >= 10)
                btnUpgradePA.Visible = true;
            else
                btnUpgradePA.Visible = false;

            if (p.armors.goblinA.isUnlocked == true && p.armors.goblinA.enchLevel < 5 && p.inventory.requiredMaterials(11) >= 1 && p.coins >= 20)
                btnUpgradeGA.Visible = true;
            else
                btnUpgradeGA.Visible = false;

            if (p.armors.monkeA.isUnlocked == true && p.armors.monkeA.enchLevel < 5 && p.inventory.requiredMaterials(11) >= 1 && p.coins >= 30)
                btnUpgradeMA.Visible = true;
            else
                btnUpgradeMA.Visible = false;

            if (p.armors.dinoA.isUnlocked == true && p.armors.dinoA.enchLevel < 5 && p.inventory.requiredMaterials(11) >= 1 && p.coins >= 40)
                btnUpgradeDA.Visible = true;
            else
                btnUpgradeDA.Visible = false;
        }

        public void updateText()
        {
            lblDS.Text = p.weapons.dinoS.weaponName;           
            lblPS.Text = p.weapons.pickleS.weaponName;
            lblMM.Text = p.weapons.monkeM.weaponName;
            lblGS.Text = p.weapons.goblinS.weaponName;
            lblDA.Text = p.armors.dinoA.armorName;
            lblPA.Text = p.armors.pickleA.armorName;
            lblGA.Text = p.armors.goblinA.armorName;
            lblMA.Text = p.armors.monkeA.armorName;
        }

        //Function that updates the player's materials
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
            isUpgradable();
            updateText();
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

        //Buttons that unlock the gear piece, remove the materials from the player's inventory and equip the piece
        private void btnCraftPSword_Click(object sender, EventArgs e)
        {
            p.weapons.pickleS.isObtained = true;
            p.recipes.pickleS.craftItem(ref p);
            lblItems.Text = p.inventory.toString();
            selectedWeapon = p.weapons.pickleS;
            showEquipment();
            isCraftable();
            updateMaterials();
            isUpgradable();
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
            isUpgradable();
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
            isUpgradable();
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
            isUpgradable();
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
            isUpgradable();
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
            isUpgradable();
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
            isUpgradable();
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
            isUpgradable();
        }

        private void btnUpgradePS_Click(object sender, EventArgs e)
        {
            p.coins -= 10;
            p.i_1++;
            p.weapons.pickleS.weaponName = "Pickle Sword +" + p.i_1;
            p.weapons.pickleS.weaponDmgMin++;
            p.weapons.pickleS.weaponDmgMax++;
            p.weapons.pickleS.enchLevel++;
            p.inventory.useItem(11, 1);
            lblItems.Text = p.inventory.toString();
            isUpgradable();
            updateText();
        }

        private void btnUpgradePA_Click(object sender, EventArgs e)
        {
            p.coins -= 10;
            p.i_2++;
            p.armors.pickleA.armorName = "Pickle Armor +" + p.i_2;
            p.armors.pickleA.armorDefense++;
            p.armors.pickleA.enchLevel++;
            p.inventory.useItem(11, 1);
            lblItems.Text = p.inventory.toString();
            isUpgradable();
            updateText();
        }

        private void btnUpgradeGS_Click(object sender, EventArgs e)
        {
            p.coins -= 20;
            p.i_3++;
            p.weapons.goblinS.weaponName = "Goblin Sword +" + p.i_3;
            p.weapons.goblinS.weaponDmgMin++;
            p.weapons.goblinS.weaponDmgMax++;
            p.weapons.goblinS.enchLevel++;
            p.inventory.useItem(11, 1);
            lblItems.Text = p.inventory.toString();
            isUpgradable();
            updateText();
        }

        private void btnUpgradeGA_Click(object sender, EventArgs e)
        {
            p.coins -= 20;
            p.i_4++;
            p.armors.goblinA.armorName = "Goblin Armor +" + p.i_4;
            p.armors.goblinA.armorDefense++;
            p.armors.goblinA.enchLevel++;
            p.inventory.useItem(11, 1);
            lblItems.Text = p.inventory.toString();
            isUpgradable();
            updateText();
        }

        private void btnUpgradeMM_Click(object sender, EventArgs e)
        {
            p.coins -= 30;
            p.i_5++;
            p.weapons.monkeM.weaponName = "Monke Mallet +" + p.i_5;
            p.weapons.monkeM.weaponDmgMin++;
            p.weapons.monkeM.weaponDmgMax++;
            p.weapons.monkeM.enchLevel++;
            p.inventory.useItem(11, 1);
            lblItems.Text = p.inventory.toString();
            isUpgradable();
            updateText();
        }      

        private void btnUpgradeMA_Click(object sender, EventArgs e)
        {
            p.coins -= 30;
            p.i_6++;
            p.armors.monkeA.armorName = "Monke Armor +" + p.i_6;
            p.armors.monkeA.armorDefense++;
            p.armors.monkeA.enchLevel++;
            p.inventory.useItem(11, 1);
            lblItems.Text = p.inventory.toString();
            isUpgradable();
            updateText();
        }

        private void btnUpgradeDS_Click(object sender, EventArgs e)
        {
            p.coins -= 40;
            p.i_7++;
            p.weapons.dinoS.weaponName = "Dino Sword +" + p.i_7;
            p.weapons.dinoS.weaponDmgMin++;
            p.weapons.dinoS.weaponDmgMax++;
            p.weapons.dinoS.enchLevel++;
            p.inventory.useItem(11, 1);
            lblItems.Text = p.inventory.toString();
            isUpgradable();
            updateText();
        }

        private void btnUpgradeDA_Click(object sender, EventArgs e)
        {
            p.coins -= 40;
            p.i_8++;
            p.armors.dinoA.armorName = "Dino Armor +" + p.i_8;
            p.armors.dinoA.armorDefense++;
            p.armors.dinoA.enchLevel++;
            p.inventory.useItem(11, 1);
            lblItems.Text = p.inventory.toString();
            isUpgradable();
            updateText();
        }
    }
}