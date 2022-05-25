using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer_Problem
{
    public class MoodAnalysreCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,Empty_Message,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        private readonly ExceptionType exceptionType;

        public MoodAnalysreCustomException(ExceptionType Type,string message): base(message)
        {
            this.exceptionType = Type;
        }
    }
}
