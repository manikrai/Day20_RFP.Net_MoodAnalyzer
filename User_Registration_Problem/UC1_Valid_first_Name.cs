using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    internal class UC1_Valid_first_Name
    {
        public static string REGEX_FirstName = "^[A-Z]{1}[a-z]{3}";
        public bool Validate_FirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, REGEX_FirstName);

        }
    }
}
