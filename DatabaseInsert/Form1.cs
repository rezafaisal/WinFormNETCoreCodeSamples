using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace DatabaseInsert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsertData_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var email = textBoxEmail.Text;
            var message = textBoxMessage.Text;

            try
            {
                var db = new GuestBookDataContext();
                var item = new GuestBook { Name = name, Email = email, Message = message };
                db.GuestBook.Add(item);
                db.SaveChanges();

                MessageBox.Show("Data berhasil disimpan.");
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Data gagal disimpan. \n" + ex.ToString());
            }
            
        }
    }
}
