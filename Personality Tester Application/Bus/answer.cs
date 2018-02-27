using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personality_Tester_Application.Bus
{
  public  class answer
    {
        private int ansid;
        private int selected_option;
        private string colour_type;

        public int Ansid
        {
            get
            {
                return ansid;
            }

            set
            {
                ansid = value;
            }
        }

        public int Selected_option
        {
            get
            {
                return selected_option;
            }

            set
            {
                selected_option = value;
            }
        }

        public string Colour_type
        {
            get
            {
                return colour_type;
            }

            set
            {
                colour_type = value;
            }
        }

        public answer()
        {
            this.ansid = 00;
            this.selected_option = 00;
            this.colour_type = "unknown";
        }

        public answer(int ansid, int selected_option, string colour_type)
        {
            this.ansid = ansid;
            this.selected_option = selected_option;
            this.colour_type = "colour_type";
        }
    }
}
