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
    public partial class FormInstruction : Form
    {
        public FormInstruction()
        {
            InitializeComponent();
        }

        private void FormInstruction_Load(object sender, EventArgs e)
        {
            label1.Text = "Now we will have second part of our test.\n"+ 
                "Please click OK to continue ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMultipleIntelligence frmMultipleIntelligence = new FormMultipleIntelligence();
            frmMultipleIntelligence.Show();
            this.Hide();
        }
    }
}
