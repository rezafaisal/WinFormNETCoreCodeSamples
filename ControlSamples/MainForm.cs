using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlSamples
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // event untuk Exit
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to exit?",
                                     "Exit",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // event untuk memanggil form anak
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Control Example 1")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!isOpen)
            {
                ControlExample1 form = new ControlExample1();
                form.MdiParent = this;
                form.Show();
            }
        }

        // event untuk about
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ShowAboutForm();
        }

        // event untuk exit
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to exit?",
                                     "Exit",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // event untuk about
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ShowAboutForm();
        }

        // method untuk menampilkan AboutForm
        private void ShowAboutForm()
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "About Us")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!isOpen)
            {
                AboutForm form = new AboutForm();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
