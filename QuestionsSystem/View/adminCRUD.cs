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
using QuestionsSystem.Modell;

namespace QuestionsSystem.View
{
    public partial class frmAdminCRUD : Form
    {
        private object element;

        public frmAdminCRUD()
        {
            InitializeComponent();
            InitGui();
            InitGui_Update(false);
        }
        private void UpdateGUIClear()
        {
            txtId_U.Text = "";
            txtQuestion_U.Text = "";
            txtO1_U.Text = "";
            txtO2_U.Text = "";
            txtO3_U.Text = "";
            txtO4_U.Text = "";
            cbCorrectAnswer_U.Text = "";
        }
        private void InitGui_Update(bool canUpdate)
        {
            txtQuestion_U.Enabled = canUpdate;
            txtO1_U.Enabled = canUpdate;
            txtO2_U.Enabled = canUpdate;
            txtO3_U.Enabled = canUpdate;
            txtO4_U.Enabled = canUpdate;
            cbCorrectAnswer_U.Enabled = canUpdate;
            btnUpdate_U.Enabled = canUpdate;
            txtId_U.Enabled = !canUpdate;
            btnSearch_U.Enabled = !canUpdate;
        }

        public void InitGui()
        {
            cbCorrectAnswer.Items.Add(1);
            cbCorrectAnswer.Items.Add(2);
            cbCorrectAnswer.Items.Add(3);
            cbCorrectAnswer.Items.Add(4);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "" || txtO1.Text == "" || txtO2.Text == "" || txtO3.Text == "" || txtO4.Text == "" || cbCorrectAnswer.Text == "")
            {
                MessageBox.Show("Pleas fill all Fields");
                return;
            }
            try
            {
                Element element = new Element();
                element.question = txtQuestion.Text;
                element.option1 = txtO1.Text;
                element.option2 = txtO2.Text;
                element.option3 = txtO3.Text;
                element.option4 = txtO4.Text;
                element.correct_answer = cbCorrectAnswer.Text;
                DBHelper.AddQuestion(element);
                MessageBox.Show("Question has been added");
                txtQuestion.Text = "";
                txtO1.Text = "";
                txtO2.Text = "";
                txtO3.Text = "";
                txtO4.Text = "";
                cbCorrectAnswer.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Wrong!");

            }


        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            List<Element> elements = new List<Element>();
            elements = DBHelper.ReadQuestions();
            dgRead.DataSource = elements;

        }




        private void btnSearch_U_Click(object sender, EventArgs e)
        {
            bool foundIt = false;
            int id;
            try
            {
                id = int.Parse(txtId_U.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter digit Number");
                return;
            }
            List<Element> elements = DBHelper.ReadQuestions();
            foreach (Element Item in elements)
            {
                if (Item.id == id)
                {
                    foundIt = true;
                    ReadToUpdate(Item);
                    break;
                }
                if (!foundIt)
                {
                    MessageBox.Show("Id is not Exist");
                }
            }
        }
        private void ReadToUpdate(Element element)
        {
            InitGui_Update(true);
            txtQuestion_U.Text = element.question;
            txtO1_U.Text = element.option1;
            txtO2_U.Text = element.option2;
            txtO3_U.Text = element.option3;
            txtO4_U.Text = element.option4;
            cbCorrectAnswer_U.Text = element.correct_answer;
        }

        private void btnUpdate_U_Click(object sender, EventArgs e)
        {
            Element temp = new Element();
            temp.id = int.Parse(txtId_U.Text);
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
                MessageBox.Show("Something went Wrong! ");
                return;
            }
            MessageBox.Show("Data has been updated");
            InitGui_Update(false);
            UpdateGUIClear();

        }
    }
}