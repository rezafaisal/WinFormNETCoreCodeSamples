using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int bil1 = Int32.Parse(textBoxBil1.Text);
            int bil2 = Int32.Parse(textBoxBil2.Text);
            int hasil = bil1 + bil2;

            textBoxHasil.Text = hasil.ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            int bil1 = Int32.Parse(textBoxBil1.Text);
            int bil2 = Int32.Parse(textBoxBil2.Text);
            int hasil = bil1 - bil2;

            textBoxHasil.Text = hasil.ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            int bil1 = Int32.Parse(textBoxBil1.Text);
            int bil2 = Int32.Parse(textBoxBil2.Text);
            int hasil = bil1 * bil2;

            textBoxHasil.Text = hasil.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxBil1.Text = "";
            textBoxBil2.Text = "";
        }
    }
}
