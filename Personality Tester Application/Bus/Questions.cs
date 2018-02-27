using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personality_Tester_Application.Bus
{
   public  class Questions
    {
        private string text;

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
        private int id;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }

        }

        public bool Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }

        private bool answer;

        public Questions()
        { this.Text = "";
            this.id = 00;
            this.answer = false;
        }
        public Questions(string text, int id)
        { this.text = text;
            this.id = id;
            this.answer = false;
        }
      


    }
}
