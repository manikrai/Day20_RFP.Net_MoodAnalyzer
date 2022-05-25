using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    internal class UC2_Valid_Last_Name
    {
        public static string REGEX_LastName = "^[A-Z]{1}[a-z]{2}";
        public bool Validate_LastName(string LastName)
        {
            return Regex.IsMatch(LastName, REGEX_LastName);
        }
    }
}
