using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RV180800_GA181200
{
    public partial class formup : Form
    {
        public formup()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Menu fr = new Menu();
            fr.Show();
            this.Hide();
        }
    }
}
