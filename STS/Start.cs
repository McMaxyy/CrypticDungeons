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
    public partial class Start : Form
    {
        Podatki p;
        Weapons weapon;
        Armor armor;

        public Start(ref Podatki p)
        {           
            InitializeComponent();
            this.p = p;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            weapon = p.weapons.woodenS;
            armor = p.armors.bronzeA;
            this.Hide();
            Map m = new Map(weapon, armor, ref p);
            m.Show();
        }
    }
}
