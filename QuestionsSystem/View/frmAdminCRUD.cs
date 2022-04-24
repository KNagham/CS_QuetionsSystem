using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestionsSystem.Controller;
using QuestionsSystem.Model;

namespace QuestionsSystem.View
{
    public partial class frmAdminCRUD : Form
    {
        public frmAdminCRUD()
        {
            InitializeComponent();
            InitGUI();
            InitGUI_Update(false);
            InitGUIDelete(true);
        }

        private void InitGUI_Update(bool canUpdate)
        {
            txtQuestion_U.Enabled = canUpdate;
            txtO1_U.Enabled = canUpdate;
            txtO2_U.Enabled = canUpdate;
            txtO3_U.Enabled = canUpdate;
            txtO4_U.Enabled = canUpdate;
            cbCorrectAnswer_U.Enabled = canUpdate;
            btnUpdate_U.Enabled = canUpdate;

            txtID_U.Enabled = !canUpdate;
            btnSearch_U.Enabled = !canUpdate;
        }

        private void UpdateGUIClear()
        {
            txtQuestion_U.Text = "";
            txtO1_U.Text = "";
            txtO2_U.Text = "";
            txtO3_U.Text = "";
            txtO4_U.Text = "";
            cbCorrectAnswer_U.Text = "";
            txtID_U.Text = "";
        }
        public void InitGUI()
        {
            //Create tab
            cbCorrectAnswer.Items.Add(1);
            cbCorrectAnswer.Items.Add(2);
            cbCorrectAnswer.Items.Add(3);
            cbCorrectAnswer.Items.Add(4);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "" || txtO1.Text == "" || txtO2.Text == "" || txtO3.Text == "" || txtO4.Text == "" || cbCorrectAnswer.Text == "")
            {
                MessageBox.Show("Please Fill all Fields");
                return;
            }

            try
            {
                elemet element = new elemet();
                element.question = txtQuestion.Text;
                element.option1 = txtO1.Text;
                element.option2 = txtO2.Text;
                element.option3 = txtO3.Text;
                element.option4 = txtO4.Text;
                element.correct_answer = cbCorrectAnswer.Text;

                DBHelper.AddQuestion(element);
                MessageBox.Show("Question has been Added!");

                txtQuestion.Text = "";
                txtO1.Text = "";
                txtO2.Text = "";
                txtO3.Text = "";
                txtO4.Text = "";
                cbCorrectAnswer.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            List<elemet> elemests = new List<elemet>();
            elemests = DBHelper.ReadQuestions();
            dgRead.DataSource = DBHelper.ReadQuestions();
        }

        private void btnSearch_U_Click(object sender, EventArgs e)
        {
            bool foundIt = false;
            int id;
            try
            {
                id = int.Parse(txtID_U.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter Digit number");
                return;
            }

            List<elemet> elements = DBHelper.ReadQuestions();
            foreach(elemet item in elements)
            {
                if (item.id == id)
                {
                    foundIt = true;
                    ReadyToUpdate(item);
                    break;
                }
            }
            if (!foundIt)
            {
                MessageBox.Show("ID does not Exist");
            }
        }

        private void ReadyToUpdate(elemet element)
        {
            InitGUI_Update(true);
            txtQuestion_U.Text = element.question;
            txtO1_U.Text = element.option1;
            txtO2_U.Text = element.option2;
            txtO3_U.Text = element.option3;
            txtO4_U.Text = element.option4;
            cbCorrectAnswer_U.Text = element.correct_answer;
        }

        private void btnUpdate_U_Click(object sender, EventArgs e)
        {
            elemet temp = new elemet();
            temp.id = int.Parse(txtID_U.Text);
            temp.question = txtQuestion_U.Text;
            temp.option1 = txtO1_U.Text;
            temp.option2 = txtO2_U.Text;
            temp.option3 = txtO3_U.Text;
            temp.option4 = txtO4_U.Text;
            temp.correct_answer = cbCorrectAnswer_U.Text;
            try
            {
                DBHelper.UpdateRecord(temp);
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
                return;
            }
            MessageBox.Show("Data has been Updated");
            UpdateGUIClear();
            InitGUI_Update(false);

        }

        private void btnSearch_D_Click(object sender, EventArgs e)
        {
            bool foundIt = false;
            int id;

            try
            {
                id = int.Parse(txtID_D.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter Digit number");
                return;
            }

            List<elemet> elements = DBHelper.ReadQuestions();
            foreach (elemet item in elements)
            {
                if (item.id == id)
                {
                    foundIt = true;
                    txtQuestion_D.Text = item.question;
                    InitGUIDelete(false);
                    break;
                }
            }
            if (!foundIt)
            {
                MessageBox.Show("ID does not Exist");
            }
        }

        private void InitGUIDelete(bool state)
        {
            txtID_D.Enabled = state;
        }

        private void btnDelete_D_Click(object sender, EventArgs e)
        {
            List<elemet> elemets = DBHelper.ReadQuestions();
            foreach (elemet item in elemets)
            {
                if (item.id == int.Parse(txtID_D.Text))
                {
                    DBHelper.DeleteQuestion(item);
                    break;
                }
            }
            MessageBox.Show("Record has been Deleted");
            InitGUIDelete(true);
            txtQuestion_D.Text = "";
            txtID_D.Text = "";
        }

        private void btnCancel_U_Click(object sender, EventArgs e)
        {
            UpdateGUIClear();
            InitGUI_Update(false);
        }

        private void btnCancel_D_Click(object sender, EventArgs e)
        {
            InitGUIDelete(true);
            txtQuestion_D.Text = "";
            txtID_D.Text = "";
        }

        private void btnBack_R_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
