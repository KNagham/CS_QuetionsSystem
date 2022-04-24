using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestionsSystem.Modell;
using QuestionsSystem.Controller;


namespace QuestionsSystem.View
{
    public partial class frmGame : Form
    {
        
        List<Element> _elements = new List<Element>();
        int _currentQuestion;
        int _correctAnswer;
        int _totalQuestions;
        public frmGame()
   
        {
            System.Windows.Forms.Application.Exit();
            InitializeComponent();
            InitGUI_G();
            StartGame();
        }

        private void showQuestion(int index)
        {
            txtQuestion_G.Text = _elements.ElementAt(index).question;
            txtO1_G.Text = _elements.ElementAt(index).option1;
            txtO2_G.Text = _elements.ElementAt(index).option2;
            txtO3_G.Text = _elements.ElementAt(index).option3;
            txtO4_G.Text = _elements.ElementAt(index).option4;
            lblQuestion.Text = (_currentQuestion + 1).ToString() + " / " + _elements.Count.ToString();

        }

        private void StartGame()
        {
            _elements = DBHelper.ReadQuestions();
            _elements = DataController.GetQuestions(_elements, 3);
            _totalQuestions = _elements.Count;
            _currentQuestion = 0;
            showQuestion(0);

        }

        private void InitGUI_G()
        {
            cbCorrectAnswer_G.Items.Add(1);
            cbCorrectAnswer_G.Items.Add(2);
            cbCorrectAnswer_G.Items.Add(3);
            cbCorrectAnswer_G.Items.Add(4);

        }



        private void cbCorrectAnswer_G_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_elements.ElementAt(_correctAnswer).correct_answer == cbCorrectAnswer_G.SelectedItem.ToString())
            {
                MessageBox.Show(" It is correct !");
                _correctAnswer++;
            }
            else
            {
                MessageBox.Show(" It is Wrong");
            }
            if(_currentQuestion< _totalQuestions -1)
            {
                _currentQuestion++;
                showQuestion(_currentQuestion);
            }
            else
            {
                MessageBox.Show("Game over!");
            }
                       
        }

        
    }
}
