using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCalculator
{
    public partial class Form1 : Form
    {
        Alchemist alc = new Alchemist();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(alc.magic_weapon_b[1]);
        }
    }
}
