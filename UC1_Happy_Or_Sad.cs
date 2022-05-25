using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer_Problem
{
    public class UC1_Happy_Or_Sad
    {
        private string message;
        public UC1_Happy_Or_Sad(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            //try
            //{


            //    if (this.message.Contains("Sad"))
            //    {
            //        return "Sad";
            //    }
            //    else
            //    {
            //        return "Happy";
            //    }
            // }
            //catch
            //{
            // return "Happy";
            //}

            // custom exception

            try
            {
                if(this.message.Equals(string.Empty))
                    {
                    throw new MoodAnalysreCustomException(MoodAnalysreCustomException.ExceptionType.Empty_Message, "MoodShould Not Be Empty");
                }
                if(this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalysreCustomException(MoodAnalysreCustomException.ExceptionType.NULL_MESSAGE, "Mood Should Not Be Null");
            }
         }
    }
}
