using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using QuestionsSystem.Model;
using QuestionsSystem.Controller;
namespace QuestionsSystem.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Hashing("admin");
        }


        private string Hashing(string str)
        {
            StringBuilder strBuilder = new StringBuilder();
            using (SHA256 xSHA256 = SHA256.Create())
            {
                byte[] data = xSHA256.ComputeHash(Encoding.UTF8.GetBytes(str));
                for (int i = 0; i < data.Length; i++)
                {
                    strBuilder.Append(data[i].ToString("x2"));
                }
                //MessageBox.Show(strBuilder.ToString());
            }
            return strBuilder.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please Enter user name and password");
                return;
            }
            Admin admin = DBHelper.FindUser(txtUser.Text);
            if (admin.user == null)
            {
                MessageBox.Show("User not found!");
                return;
            }
            
            //user exist in the Database
            string hashPass = Hashing(txtPass.Text);
            if (admin.password != hashPass)
            {
                MessageBox.Show("Password wrong!");
                return;
            }

            this.Hide();
            frmAdminCRUD frmAdminCRUD = new frmAdminCRUD();
            frmAdminCRUD.ShowDialog();
            this.Close();
        }
    }
}
