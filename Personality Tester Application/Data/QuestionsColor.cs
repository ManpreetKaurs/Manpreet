using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personality_Tester_Application.Bus;

namespace Personality_Tester_Application.Data
{
   public static class QuestionsColor
    {
        static User userProfile;
        public static User UserProfile
        {
            get
            {
                return userProfile;
            }

            set
            {
                userProfile = value;
            }
        }
        static List<string> questionsList = new List<string>()
        {
            "1: You are kind of personality who like to talk and socialize with people.",
            "2: You make judgements based upon other people rather than facts.",
            "3: You can be quite emotional aware of other feelings and sensitive moods of"+
                "\n  others.",//Blue Colour
            "4: You prefer doing a repetitive task.",
            "5: They perfer to work in teams and will be a stabilizing force within that "+
                "\n  group.",
            "6: You are not fast as others, you are accurate and thorough.",//D-Blue
            "7: You like to get to the bottom of the things.",
            "8: You appreciate working independently and quite in order to concentrate rarely" +
               "\n  important things in more logical ways.",
            "9: Creative problem solving and jumping out of your paradigm to development "+
               "\n  daring future vision are a part of your greatest strength.",//Green
            "10: Rationality, logic and accuracy are your key interests.",
            "11: You are careful, resourceful, and are excellent thinkers.",
            "12: You prefer to look at all aspects of an issue before taking a stand.",//C- Green 
            "13: You are action oriented and physically active.",
            "14: You are achievement oriented and second place is not enough for you.",
            "15: You like to take risks and pursue adventurous things.",//red
            "16: You are outgoing, energetic and fast paced.",
            "17: You are good relationship builders and most people likes you.",
            "18: You dont't want to appear unsuccesssful and unattractive in front of"+
                 "\n  others.",//B-Red
            "19: You are duty conscious and expect other to be as well.",
            "20: You are result oriented and like to be prepared.",
            "21: You usually enjoy leading and being up front with people by expressing"+
                "\n  themselves openly and directly.",//brown
            "22: You can not be easily discouraged and have enough confidence.",
            "23: You are not very good at recognizing co-worker's feelings and needs.",
            "24: You can excel in high stress situations.",//A -Brown
          };

        public static List<string> QuestionsList
        {
            get
            {
                return questionsList;
            }

            set
            {
                questionsList = value;
            }
        }

    }
}
