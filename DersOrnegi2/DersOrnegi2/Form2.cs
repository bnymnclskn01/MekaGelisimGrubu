using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersOrnegi2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Red;
            progressBar2.ForeColor = Color.Blue;
            progressBar3.ForeColor = Color.Pink;
            progressBar4.ForeColor = Color.Black;

            progressBar1.Value = 45;
            progressBar2.Value = 10;
            progressBar3.Value = 75;
            progressBar4.Value = 100;
        }
    }
}
