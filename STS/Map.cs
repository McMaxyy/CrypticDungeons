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


        public Map(ref Podatki p) 
        { 
            InitializeComponent();
            this.p = p;
        } 

        private void btnStage1_Click(object sender, EventArgs e)
        {             
            if (p.weapons.ironS.isUnlocked == true)
                btnIS.Enabled = true;
            if (p.armors.ironA.isUnlocked == true)
                btnIA.Enabled = true;

            btnWS.Visible = true;
            btnIS.Visible = true;
            btnBA.Visible = true;
            btnIA.Visible = true;
            btnGo.Visible = true;
        }

        private void btnWS_Click(object sender, EventArgs e)
        {
            weapon = p.weapons.woodenS;
        }

        private void btnIS_Click(object sender, EventArgs e)
        {
            weapon = p.weapons.ironS;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            STS s = new STS(weapon, armor, ref p);
            s.Show();
        }

        private void btnIA_Click(object sender, EventArgs e)
        {
            armor = p.armors.ironA;
        }

        private void btnBA_Click(object sender, EventArgs e)
        {
            armor = p.armors.bronzeA;
        }
    }
}
