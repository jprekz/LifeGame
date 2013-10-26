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
    public partial class Form_new : Form
    {
        public Form_new()
        {
            InitializeComponent();
        }

        public bool NewFlag = false;

        private void button_new_Click(object sender, EventArgs e)
        {
            NewFlag = true;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_rnd_CheckedChanged(object sender, EventArgs e)
        {
            this.numericUpDown_rnd.Enabled = this.checkBox_rnd.Checked;
        }
    }
}
