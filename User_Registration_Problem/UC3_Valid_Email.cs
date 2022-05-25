using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    internal class UC3_Valid_Email
    {
        public static string REGEX_Email = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        public bool Validate_Email(string Email)
        {
            return Regex.IsMatch(Email, REGEX_Email);
        }
    }
}
