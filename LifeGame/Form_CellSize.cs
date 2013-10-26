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
    public partial class Form_CellSize : Form
    {
        public Form_CellSize()
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
    }
}
