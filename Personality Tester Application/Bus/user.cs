using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personality_Tester_Application.Bus
{
   public class User
    {
        public int BrownScore { get; set; }
        public int BlueScore { get; set; }
        public int GreenScore { get; set; }
        public int RedScore { get; set; }
        //public int A_Score { get; set; }
        //public int B_Score { get; set; }
        //public int C_Score { get; set; }
        //public int D_Score { get; set; }

        public User()
        {
            this.BrownScore = 0;
            this.BlueScore = 0;
            this.GreenScore = 0;
            this.RedScore = 0;
            //this.A_Score = 0;
            //this.B_Score = 0;
            //this.C_Score = 0;
            //this.D_Score = 0;
        }
    }
}
