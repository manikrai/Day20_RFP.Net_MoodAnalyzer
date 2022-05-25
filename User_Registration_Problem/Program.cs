// See https://aka.ms/new-console-template for more information
using System;
using UserRegistrationProblem;
using System.Text.RegularExpressions;
namespace UserRegistrationProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UC1_Valid_first_Name uc1=new UC1_Valid_first_Name();
            Console.WriteLine(uc1.Validate_FirstName("Shubham"));
            Console.WriteLine();
            UC2_Valid_Last_Name uc2=new UC2_Valid_Last_Name();
            Console.WriteLine(uc2.Validate_LastName("Rai"));
            Console.WriteLine();
            UC3_Valid_Email uc3=new UC3_Valid_Email();
            Console.WriteLine(uc3.Validate_Email("abc.xyz@bl.co.in"));
            Console.WriteLine();
            UC4_Moblie_Format uc4=new UC4_Moblie_Format();
            Console.WriteLine(uc4.Validate_PhoneNo("91 9919819801"));
            Console.WriteLine();
            UC5_Password_Rules uc5=new UC5_Password_Rules();
            Console.WriteLine(uc5.Validate_Password("Manik@12"));
        }
    }
}

