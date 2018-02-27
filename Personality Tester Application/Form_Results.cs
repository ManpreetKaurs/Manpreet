using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personality_Tester_Application.Bus;
using Personality_Tester_Application.Data;
using System.Windows.Forms;

namespace Personality_Tester_Application
{
    public partial class Form_Results : Form
    {
        public Form_Results()
        {
            InitializeComponent();
        }

        private void Form_Results_Load(object sender, EventArgs e)
        {

            fillChart();
            DisplayWinningColour();
            displayType();
        }
        void fillChart()
        {
            PersonalityChart.Series["Colour"].Points.AddXY("Blue", QuestionsColor.UserProfile.BlueScore);
            PersonalityChart.Series["Colour"].Points.AddXY("Green", QuestionsColor.UserProfile.GreenScore);
            PersonalityChart.Series["Colour"].Points.AddXY("Red", QuestionsColor.UserProfile.RedScore);
            PersonalityChart.Series["Colour"].Points.AddXY("Brown", QuestionsColor.UserProfile.BrownScore);
            PersonalityChart.Titles.Add("Personality Colour Type");
            PersonalityChart.Series["Colour"].Points[0].Color = Color.Blue;
            PersonalityChart.Series["Colour"].Points[1].Color = Color.Green;
            PersonalityChart.Series["Colour"].Points[2].Color = Color.Red;
            PersonalityChart.Series["Colour"].Points[3].Color = Color.Brown;

        }
        void DisplayWinningColour()
        {
            if (QuestionsColor.UserProfile.BlueScore > QuestionsColor.UserProfile.BrownScore && QuestionsColor.UserProfile.BlueScore > QuestionsColor.UserProfile.RedScore && QuestionsColor.UserProfile.BlueScore > QuestionsColor.UserProfile.GreenScore)
            {
                lblResultColor.Text = "Color: You are Blue Colour." + "\nType: Your Personality Type is 'D'.";
                labeljob.Text = "\nStrengths: Working with others, Learn by doing,and Loyal and committed. " +
              "\nWeeknesses: Dislike Changes ,Trouble with conflict Take things personally." +
              "\nJob Suggestions:IT consultant, Software quality assurance(QA) tester.";
                textBox1.Text = "Color-Blue";
                textBoxPersonalityColor.Text = "Blue or Relator usually enjoy being with people and have a high regard of emotions "+
                "Relators know the feeling that are important and they will bend their needs to accomodate others."
                + "They are sympathetically mature and want to communicate and socialize with others.";
                textBoxLetter.Text = "Personalty-'D'";
                textBoxLetterPersonality.Text = "The 'D' personality takes a slower, easy pace toward their job and life in general."
                 +"They seek security and longevity on the job and are very happy doing a repetitive task," 
                 +"day in and day out as the repetition allows them to become very skilled in what they do.";
            }
            else if (QuestionsColor.UserProfile.BrownScore > QuestionsColor.UserProfile.BlueScore && QuestionsColor.UserProfile.BrownScore > QuestionsColor.UserProfile.RedScore && QuestionsColor.UserProfile.BrownScore > QuestionsColor.UserProfile.GreenScore)

            {
                lblResultColor.Text = "Color: You are Brown Colour." + "\nType: Your Personality Type is 'A'.";
                labeljob.Text =
               "\nStrong Points: Loyal and committed, Social and enthusiastic,and Born Leader. " +
               "\nWeek Points: Expressing feelings Can be blunt and insensitive,Poor follow up skills. " +
               "\nJob Suggestions: Information system manager,Project manager";
                textBox1.Text = "Color-Brown";
                textBoxPersonalityColor.Text = "Brown or Builder has leadership quality. The Brown wants to control others. "+
                    "Builder wants the bottom line.They do not like it when others are not direct with them. Builders want to be "+
                    "the best at everything they do.";
                textBoxLetter.Text = "Personalty-'A'";
                textBoxLetterPersonality.Text = "The 'A' personality likes to be in charge and be in control of their environment and their lives." +
                "They will also be very dissatisfied if they believe someone is trying to take advantage of them or hold them back.";
                
            }

            else if (QuestionsColor.UserProfile.GreenScore > QuestionsColor.UserProfile.BlueScore && QuestionsColor.UserProfile.GreenScore > QuestionsColor.UserProfile.RedScore && QuestionsColor.UserProfile.GreenScore > QuestionsColor.UserProfile.BrownScore)

            {
                lblResultColor.Text = "Color: You are Green Colour." + "\nType: Your Personality Type is 'C'.";
                labeljob.Text =
              "\nStrong Points: Orderly and organized ,Handles criticism well and Good listener." +
              "\nWeek Points:Too rigid , needs to be right." +
              "\nJob Suggestions: Web developer, computer programmer,Software systems developer, Programmer Analyst";
                textBox1.Text = "Color-Green";
                textBoxPersonalityColor.Text = "Green or Planner enjoy planning new and better ways of doing things."+
                    "They know the details are important and they make sure that everything is brought into consideration "
                    +"before making an important decision.Planners may miss opportunity because they are too slow at getting things done. ";
                textBoxLetter.Text = "Personalty-'C'";
                textBoxLetterPersonality.Text = "The 'C' personality is a very detail oriented individual that likes to be involved in things that are controlled and stable."  
                    + "They are interested in accuracy, rationality and logic.They are careful, resourceful, "+
                    "and above all, are excellent thinkers who will look at all aspects of an issue before taking a stand.";
            }

            else if (QuestionsColor.UserProfile.RedScore > QuestionsColor.UserProfile.BlueScore && QuestionsColor.UserProfile.RedScore > QuestionsColor.UserProfile.GreenScore && QuestionsColor.UserProfile.RedScore > QuestionsColor.UserProfile.BrownScore)

            {
                lblResultColor.Text = "Color: You are Red Colour" + "\nType: Your Personality Type is 'B'.";
                labeljob.Text =
               "\nStrong Points: Communication,Generationg ideas and Highly energetic." +
               "\nWeek Points:Poor follow up skills,Argumentative and Easly bored." +
               "\nJob Suggestions: application analyst,games developer,business intelligence analyst";
                textBox1.Text = "Color-Red";
                textBoxPersonalityColor.Text = "Red or Adventurer usually enjoy being where the action is and bringing fun"+
                    " and thrills into the routine of daily life. Adveturers are at their best in a time of crisis."+
                    "They usually seek excitement, adventure, and risk.";
                textBoxLetter.Text = "Personalty-'B'";
                textBoxLetterPersonality.Text = "The 'B' personality is a very outgoing, energetic and fast paced individual"+
                    " who likes to be around people and enjoys being the center of attention. "
                    +"They are good relationship builders and most people like them right away.";
        }
}
        void displayType()
        {
            if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
               (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
               (QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore > QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore) &&
               (QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore > QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore))

            {
                lblmulti.Text = "You are Extrovert, Sensor, Feeler and Perciever i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.ExtroString +
               QuestionMultiIntelligence.UserMultipleIntelligence.SensorString +
               QuestionMultiIntelligence.UserMultipleIntelligence.FeelerString +
               QuestionMultiIntelligence.UserMultipleIntelligence.PercieverString;//ESFP"


            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore > QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore > QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore))
            {
                lblmulti.Text = "You are Extrovert,Sensor, Thinker and Perciever i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.ExtroString +
              QuestionMultiIntelligence.UserMultipleIntelligence.SensorString +
              QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerString +
              QuestionMultiIntelligence.UserMultipleIntelligence.PercieverString;//ESTP
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                     (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                     (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore > QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                     (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore < QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Extrovert,Sensor, Thinker and Judger i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.ExtroString +
              QuestionMultiIntelligence.UserMultipleIntelligence.SensorString +
              QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerString +
              QuestionMultiIntelligence.UserMultipleIntelligence.JudgerString;//ESTJ
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore < QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore > QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Extrovert,Sensor, Feeler and Judger i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.ExtroString +
                  QuestionMultiIntelligence.UserMultipleIntelligence.SensorString +
             QuestionMultiIntelligence.UserMultipleIntelligence.FeelerString +
              QuestionMultiIntelligence.UserMultipleIntelligence.JudgerString;//ESFJ
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                   (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                   (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore < QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                   (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore > QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Extrovert,Intuitives, Feeler and Judger i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.ExtroString +
               QuestionMultiIntelligence.UserMultipleIntelligence.IntitutiveString +
               QuestionMultiIntelligence.UserMultipleIntelligence.FeelerString +
               QuestionMultiIntelligence.UserMultipleIntelligence.JudgerString;//ENFJ
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore < QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore < QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Extrovert,Intuitives, Feeler and Perciever i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.ExtroString +
                QuestionMultiIntelligence.UserMultipleIntelligence.IntitutiveString +
                QuestionMultiIntelligence.UserMultipleIntelligence.FeelerString +
                QuestionMultiIntelligence.UserMultipleIntelligence.PercieverString;//ENFP
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore > QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore > QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Extrovert,Intuitives, Thinker and Judger i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.ExtroString +
                QuestionMultiIntelligence.UserMultipleIntelligence.IntitutiveString +
                QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerString +
                 QuestionMultiIntelligence.UserMultipleIntelligence.JudgerString;//ENTJ
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore > QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore < QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Extrovert,Intuitives, Thinker and Perciever i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.ExtroString +
                QuestionMultiIntelligence.UserMultipleIntelligence.IntitutiveString +
               QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerString +
                QuestionMultiIntelligence.UserMultipleIntelligence.PercieverString;//ENTP
            }

            /************************************************/
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
               (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
               (QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore > QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore) &&
               (QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore > QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore))

            {
                lblmulti.Text = "You are Introvert, Sensor, Feeler and Perciever i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.IntroString +
               QuestionMultiIntelligence.UserMultipleIntelligence.SensorString +
              QuestionMultiIntelligence.UserMultipleIntelligence.FeelerString +
             QuestionMultiIntelligence.UserMultipleIntelligence.PercieverString;//ISFP

            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore > QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore > QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore))
            {
                lblmulti.Text = "You are Introvert,Sensor, Thinker and Perciever i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.IntroString +
              QuestionMultiIntelligence.UserMultipleIntelligence.SensorString +
              QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerString +
              QuestionMultiIntelligence.UserMultipleIntelligence.PercieverString;//ISTP
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                     (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                     (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore > QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                     (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore > QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Introvert,Sensor, Thinker and Judger i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.IntroString +
               QuestionMultiIntelligence.UserMultipleIntelligence.SensorString +
              QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerString + QuestionMultiIntelligence.UserMultipleIntelligence.JudgerString;//ISTJ
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore > QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore < QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                    (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore > QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Introvert,Sensor, Feeler and Judger i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.IntroString +
              QuestionMultiIntelligence.UserMultipleIntelligence.SensorString +
               QuestionMultiIntelligence.UserMultipleIntelligence.FeelerString +
              QuestionMultiIntelligence.UserMultipleIntelligence.JudgerString;//ISFJ
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                   (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                   (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore < QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                   (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore > QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Introvert,Intuitives, Feeler and Judger i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.IntroString +
                QuestionMultiIntelligence.UserMultipleIntelligence.IntitutiveString +
                QuestionMultiIntelligence.UserMultipleIntelligence.FeelerString +
               QuestionMultiIntelligence.UserMultipleIntelligence.JudgerString;//INFJ
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore < QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore < QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Introvert,Intuitives, Feeler and Perciever i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.IntroString +
                QuestionMultiIntelligence.UserMultipleIntelligence.IntitutiveString +
              QuestionMultiIntelligence.UserMultipleIntelligence.FeelerString +
               QuestionMultiIntelligence.UserMultipleIntelligence.PercieverString;//INFP
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore >QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore > QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Introvert,Intuitives, Thinker and Judger i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.IntroString +
                QuestionMultiIntelligence.UserMultipleIntelligence.IntitutiveString +
                QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerString +
                 QuestionMultiIntelligence.UserMultipleIntelligence.JudgerString;//INTJ
            }
            else if ((QuestionMultiIntelligence.UserMultipleIntelligence.ExtrovertScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntrovertScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.SensorScore < QuestionMultiIntelligence.UserMultipleIntelligence.IntutiveScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerScore >QuestionMultiIntelligence.UserMultipleIntelligence.FeelerScore) &&
                  (QuestionMultiIntelligence.UserMultipleIntelligence.JudgerScore < QuestionMultiIntelligence.UserMultipleIntelligence.PercieverScore))
            {
                lblmulti.Text = "You are Introvert,Intuitives, Thinker and Perciever i.e: " + QuestionMultiIntelligence.UserMultipleIntelligence.IntroString +
                QuestionMultiIntelligence.UserMultipleIntelligence.IntitutiveString +
                QuestionMultiIntelligence.UserMultipleIntelligence.ThinkerString +
                QuestionMultiIntelligence.UserMultipleIntelligence.PercieverString;//INTP
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
