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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
