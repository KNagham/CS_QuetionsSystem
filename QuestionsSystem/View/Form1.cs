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
using QuestionsSystem.Modell;
using QuestionsSystem.Controller;


namespace QuestionsSystem.View

{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //Hashing("Caty");
        }
        private string Hashing(string str)
        {
            StringBuilder strBuilder = new StringBuilder();
            using (SHA256 xsHA256 = SHA256.Create())
            {
                byte[] data= xsHA256.ComputeHash(Encoding.UTF8.GetBytes(str));
                string x = "";
                for(int i = 0; i< data.Length; i++)
                {
                    strBuilder.Append(data[i].ToString("x2"));
                }
               
            }
            return strBuilder.ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="" || txtPass.Text=="")
            {
                MessageBox.Show("please enter usernmae and Password");
                    return;
            }
            Admin admin = DBHelper.FindUser(txtUser.Text);
            if(admin.user==null)
            {
                MessageBox.Show("incorrect username");
                return;
            }
            string hashpass = Hashing(txtPass.Text);
            if(admin.password != hashpass)
            {
                MessageBox.Show("Password worng");
                return;
            }
            this.Hide();
            frmAdminCRUD frmAdminCRUD = new frmAdminCRUD();
            frmAdminCRUD.ShowDialog();
            this.Close();
        }
    }
}
