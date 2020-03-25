using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labelHasil.Visible = false;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string hasil = "";
            string name = textBoxName.Text;
            
            string gender = "";
            if (radioButtonMale.Checked)
            {
                gender = "Male";
            } else if (radioButtonFemale.Checked)
            {
                gender = "Female";
            } else
            {
                MessageBox.Show("Please choose your gender.");
            }

            string occupation = comboBoxOccupation.Text;
            if (String.IsNullOrEmpty(occupation))
            {
                MessageBox.Show("Please choose your current occupation.");
            }

            string skill = "";
            if(checkBoxCSharp.Checked)
            {
                skill += "C#, ";
            }

            if (checkBoxVBNET.Checked)
            {
                skill += "VB, ";
            }

            if (checkBoxJava.Checked)
            {
                skill += "Java";
            }

            if (String.IsNullOrEmpty(skill))
            {
                MessageBox.Show("Please choose your programming skill.");
            }
            
            if(!String.IsNullOrEmpty(name) || !String.IsNullOrEmpty(gender) || !String.IsNullOrEmpty(occupation) || !String.IsNullOrEmpty(skill))
            {
                hasil = "Name: " + name + "\n";
                hasil += "Gender: " + gender + "\n";
                hasil += "Occupation: " + occupation + "\n";
                hasil += "Programming Skills: " + skill + "\n";

                labelHasil.Visible = true;
                labelHasil.Text = hasil;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            comboBoxOccupation.SelectedIndex = -1;
            checkBoxCSharp.Checked = false;
            checkBoxVBNET.Checked = false;
            checkBoxJava.Checked = false;
            labelHasil.Visible = false;
        }
    }
}
