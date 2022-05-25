using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace UserRegistrationProblem
{
    internal class UC5_Password_Rules
    {
        public static string REGEX_Password = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,10}$";
        public bool Validate_Password(string Password)
        {
            return Regex.IsMatch(Password, REGEX_Password); 
        }
    }
}
