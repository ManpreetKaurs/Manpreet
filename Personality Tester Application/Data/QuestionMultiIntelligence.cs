using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personality_Tester_Application.Bus;
namespace Personality_Tester_Application.Data
{
   public static class QuestionMultiIntelligence
    {
        static UserMultipleIntelligence userMultipleIntelligence;

        static List<string> quesListIntoExtro = new List<string>()
        {
        "1: You have high energy?",
        "2: You talk a lot?",
        "3: You think out loud?",
        "4: You like to be around people a lot?",
        "5: You are easily distracted?",
        "6: You admire practicality?",
        "7: You focus on facts and specifics?",
        "8: You have straightforward speech?",
        "9: You are more realistic?",
        "10: You are present oriented?",
        "11: You are cool and reserved?",
        "12: Your feelings are not hurt easily?",
        "13: You are honest and direct?",
        "14: You are naturally critical?",
        "15: You are motivated by achievement?",
        "16: You are serious and former?",
        "17: You are time conscious?",
        "18: You like to make plans?",
        "19: You work first and think later?",
        "20:You like to finish project first?"

        };

        public static List<string> QuesListIntoExtro
        {
            get
            {
                return quesListIntoExtro;
            }

            set
            {
                quesListIntoExtro = value;
            }
        }

        public static UserMultipleIntelligence UserMultipleIntelligence
        {
            get
            {
                return userMultipleIntelligence;
            }

            set
            {
                userMultipleIntelligence = value;
            }
        }
    }
}
