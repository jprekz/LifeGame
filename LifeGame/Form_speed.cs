using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeGame
{
    public partial class Form_speed : Form
    {
        public Form_speed()
        {
            InitializeComponent();
        }

        public bool ApplyFlag = false;

        private void button_apply_Click(object sender, EventArgs e)
        {
            ApplyFlag = true;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            this.numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
        }
    }
}
