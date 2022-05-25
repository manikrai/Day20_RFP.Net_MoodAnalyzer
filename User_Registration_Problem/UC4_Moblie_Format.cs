using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UserRegistrationProblem
{
    internal class UC4_Moblie_Format
    {
        public static string REGEX_Moblie = "^[91]{1}\\s{1}[1-9]{1}[0-9]{9}$";
        public  bool Validate_PhoneNo(string Moblie)
        {
            return Regex.IsMatch(Moblie, REGEX_Moblie);
        }
    }
}
