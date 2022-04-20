using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsSystem.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.ShowDialog();
            this.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
