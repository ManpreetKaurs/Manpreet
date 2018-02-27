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
    public partial class FormMultipleIntelligence : Form
    {
        int multiIndex; //Declare global variable 
        public FormMultipleIntelligence()
        {
            InitializeComponent();
            QuestionMultiIntelligence.UserMultipleIntelligence = new UserMultipleIntelligence();
            multiIndex = 0;
            load_MultiIntelligence_ques(multiIndex);
        }
        void load_MultiIntelligence_ques(int indexQues)
        {
            lblQuestionMulti.Text = QuestionMultiIntelligence.QuesListIntoExtro[indexQues];
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if ((multiIndex >= 0) && (multiIndex < 5))
            {
                if (radioButtonYes.Checked)
                {
                    QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore += 1;
                    QuestionMultiIntelligence.UserMultipleIntelligence.ExtroString = "E";
                }
                else if (radioButtonNo.Checked)
                {
                    QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore += 1;
                    QuestionMultiIntelligence.UserMultipleIntelligence.IntroString = "I";
                }
            }

            else if ((multiIndex >= 5) && (multiIndex < 10))
            {
                if (radioButtonYes.Checked)
                {
                    QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore += 1;
                    QuestionMultiIntelligence.UserMultipleIntelligence.SensorString = "S";
                }
                else if (radioButtonNo.Checked)
                {
                    QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore += 1;
                    QuestionMultiIntelligence.UserMultipleIntelligence.IntitutiveString = "N";
                }

            }
            else if ((multiIndex >= 10) && (multiIndex < 15))
            {
                if (radioButtonYes.Checked)
                {
                    QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore += 1;
                    QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerString = "T";
                }
                else if (radioButtonNo.Checked)
                {
                    QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore += 1;
                    QuestionMultiIntelligence.UserMultipleIntelligence.FeelerString = "F";
                }

            }
            else if ((multiIndex >= 15) && (multiIndex < 20))
            {
                if (radioButtonYes.Checked)
                {
                    QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore += 1;
                    QuestionMultiIntelligence.UserMultipleIntelligence.JudgerString = "J";
                }
                else if (radioButtonNo.Checked)
                {
                    QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore += 1;
                    QuestionMultiIntelligence.UserMultipleIntelligence.PercieverString = "P";
                }

            }
            multiIndex++;

            // Let's check if questionIndex is now outside the bounds of our questionsList
            if (multiIndex >= QuestionMultiIntelligence.QuesListIntoExtro.Count)
            {
                // Let's now load the Results form
                Form_Results formResults = new Form_Results();
                formResults.Show();
                this.Hide();
            }
            else
            {
                // Load the next question
                load_MultiIntelligence_ques(multiIndex);
            }
        }
    }
}