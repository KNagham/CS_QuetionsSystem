using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestionsSystem.Model;
using QuestionsSystem.Controller;


namespace QuestionsSystem.View
{
    public partial class frmGame : Form
    {
        List<elemet> _elemets = new List<elemet>();
        int _questionTotal;
        int _currentQuestion;
        int _correctAnswer;
        public frmGame()
        {
            InitializeComponent();
            StartGame();
            InitGui();
        }

        private void StartGame()
        {
            _elemets = DBHelper.ReadQuestions();
            _elemets = DataController.GetQuetsions(_elemets,2);
            _currentQuestion = 0;
            ShowQuestion(_currentQuestion);
        }

        private void ShowQuestion(int index)
        {
            txtQuestion_G.Text = _elemets.ElementAt(index).question;
            txtO1_G.Text = _elemets.ElementAt(index).option1;
            txtO2_G.Text = _elemets.ElementAt(index).option2;
            txtO3_G.Text = _elemets.ElementAt(index).option3;
            txtO4_G.Text = _elemets.ElementAt(index).option4;

            _questionTotal = _elemets.Count;
            lblQuestionCounter.Text = (_currentQuestion + 1).ToString() +  "/" + _questionTotal.ToString();
        }

        private void InitGui()
        {
            cbCorrectAnswer_G.Items.Add(1);
            cbCorrectAnswer_G.Items.Add(2);
            cbCorrectAnswer_G.Items.Add(3);
            cbCorrectAnswer_G.Items.Add(4);
        }

        private void cbCorrectAnswer_G_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_elemets.ElementAt(_currentQuestion).correct_answer == cbCorrectAnswer_G.SelectedItem.ToString())
            {
                MessageBox.Show("It's Correct!");
                _correctAnswer++;
            }
            else
            {
                MessageBox.Show("Wrong!");
            }

            if (_currentQuestion < _questionTotal - 1)
            {
                _currentQuestion++;
                ShowQuestion(_currentQuestion);
            }
            else
            {
                MessageBox.Show("Game Finished");
            }
        }
    }
}
