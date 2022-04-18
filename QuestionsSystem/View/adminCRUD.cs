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
        public frmAdminCRUD()
        {
            InitializeComponent();
            InitGui();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Wrong!");

            }


        }
    }
}
