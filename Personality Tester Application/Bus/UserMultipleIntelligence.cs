using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personality_Tester_Application.Bus
{
   public class UserMultipleIntelligence
    {
        public int IntrovertScore { get; set; }
        public int ExtrovertScore { get; set; }
        public int SensorScore { get; set; }
        public int IntutiveScore { get; set; }
        public int ThinkerScore { get; set; }
        public int FeelerScore { get; set; }
        public int JudgerScore { get; set; }
        public int PercieverScore { get; set; }

        public string IntroString { get; set; }
        public string ExtroString { get; set; }
        public string SensorString { get; set; }
        public string IntitutiveString { get; set; }
        public string ThinkerString { get; set; }
        public string FeelerString { get; set; }
        public string JudgerString { get; set; }
        public string PercieverString { get; set; }

        public UserMultipleIntelligence()
        {
            this.IntrovertScore = 0;
            this.ExtrovertScore = 0;
            this.SensorScore = 0;
            this.IntutiveScore = 0;
            this.ThinkerScore = 0;
            this.FeelerScore = 0;
            this.JudgerScore = 0;
            this.PercieverScore = 0;

            this.IntroString = "";
            this.ExtroString = "";
            this.SensorString = "";
            this.IntitutiveString = "";
            this.ThinkerString = "";
            this.FeelerString = "";
            this.JudgerString = "";
            this.PercieverString = "";

        }
    }
}
