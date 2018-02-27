using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personality_Tester_Application
{
    public partial class PersonalityTester : Form
    {
        public PersonalityTester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonalityQuestions pq = new PersonalityQuestions();
            pq.Show();
            this.Hide();
        }
    }
}
