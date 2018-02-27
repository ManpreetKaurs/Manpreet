using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personality_Tester_Application.Bus;
using Personality_Tester_Application.Data;
namespace Personality_Tester_Application
{
    public partial class PersonalityQuestions : Form
    {
        int questionIndex;            // Let's create a global variable that will track which question we are on

        public PersonalityQuestions()
        {
            InitializeComponent();
            QuestionsColor.UserProfile = new User();  // Let's initiate our user object here, when the form is loaded
            questionIndex = 0;           // We will also initiate the questionIndex variable to zero

            LoadQuestion(questionIndex);    // Load the first question
            
        }
        void LoadQuestion(int index)
        {
            lblQuestion.Text = QuestionsColor.QuestionsList[index];
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Let's check which colour the current question belongs to
            // We can do this by checking the current questionIndex (0-2: Blue, 3-5: Green, 6-8: Red, 9-11: Brown)
            if ((questionIndex >= 0) && (questionIndex < 6))
            {
                // Now we check which radioButton is selected (dictating how many points to score)
                if (radionButtonLeast.Checked)
                {
                    QuestionsColor.UserProfile.BlueScore += 1;
                }
                else if (radioButtonSomewhat.Checked)
                {
                    QuestionsColor.UserProfile.BlueScore += 2;
                }
                else if (radioButtonMost.Checked)
                {
                    QuestionsColor.UserProfile.BlueScore += 3;
                }
            }
            else if ((questionIndex >= 6) && (questionIndex < 12))
            {
                // Now we check which radioButton is selected (dictating how many points to score)
                if (radionButtonLeast.Checked)
                {
                    QuestionsColor.UserProfile.GreenScore += 1;
                }
                else if (radioButtonSomewhat.Checked)
                {
                    QuestionsColor.UserProfile.GreenScore += 2;
                }
                else if (radioButtonMost.Checked)
                {
                    QuestionsColor.UserProfile.GreenScore += 3;
                }
            }
            else if ((questionIndex >= 12) && (questionIndex < 18))
            {
                // Now we check which radioButton is selected (dictating how many points to score)
                if (radionButtonLeast.Checked)
                {
                    QuestionsColor.UserProfile.RedScore += 1;
                }
                else if (radioButtonSomewhat.Checked)
                {
                    QuestionsColor.UserProfile.RedScore += 2;
                }
                else if (radioButtonMost.Checked)
                {
                    QuestionsColor.UserProfile.RedScore += 3;
                }
            }
            else if ((questionIndex >= 18) && (questionIndex < 24))
            {
                // Now we check which radioButton is selected (dictating how many points to score)
                if (radionButtonLeast.Checked)
                {
                    QuestionsColor.UserProfile.BrownScore += 1;
                }
                else if (radioButtonSomewhat.Checked)
                {
                    QuestionsColor.UserProfile.BrownScore += 2;
                }
                else if (radioButtonMost.Checked)
                {
                    QuestionsColor.UserProfile.BrownScore += 3;
                }
            }

            // We now increment questionIndex by 1
            questionIndex++;

            // Let's check if questionIndex is now outside the bounds of our questionsList
            if (questionIndex >= QuestionsColor.QuestionsList.Count)
            {
                // Let's now load the FormMultipleIntelligence
                FormInstruction frmInstruction = new FormInstruction();
                frmInstruction.Show();
                this.Hide();

            }
            else
            {
                // Load the next question
                LoadQuestion(questionIndex);
            }
        }

    }
}


  