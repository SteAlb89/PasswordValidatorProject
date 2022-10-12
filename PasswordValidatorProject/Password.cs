using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidatorProject
{
    internal class Password
    {
        // Write a program that knows how to validate a password according to the following criteria:
        // - Must have at least 8 characters
        // - Contain at least one digit
        // - To contain at least one UpperCase
        // - Contain at least one symbol
        // - Do not contain white space
        // If the password fails, display an error message specifying the exact reason

        public static void Verify(string password)
        {

            if (!CheckIfHas8Chars(password))
            {
                Console.WriteLine("The password does not have the correct number of characters");
            }
            if (!CheckIfHasAtLeastOneNumber(password))
            {
                Console.WriteLine("The password does not contain at least one number");
            }
            if (!CheckIfContainUpperCase(password))
            {
                Console.WriteLine("The password does not contain an UpperCase");
            }
            if (!CheckIfContainsSymbol(password))
            {
                Console.WriteLine("The password does not contain a symbol");
            }
            if (CheckIfContainUpperCase(password) && CheckIfContainsSymbol(password) && CheckIfHas8Chars(password) && CheckIfHasAtLeastOneNumber(password) && CheckIfContainsWhiteSpace(password))
            {
                Console.WriteLine("The password is not valid");
            }
        }
        public static bool CheckIfHas8Chars(string password)
        {
            return password.Length >= 8;

            //if(password.Length >= 8)     Example
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public static bool CheckIfHasAtLeastOneNumber(string password)
        {
            // Using 0 and 9
            //for(int i = 0; i < password.Length; i++)   Example
            //{
            //    if(password[i] >= '0' && password[i] <= '9')
            //    {
            //        return true;
            //    }
            //}
            //return false;


            // using isDigit method
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckIfContainUpperCase(string password)
        {
            //for (int i = 0; i < password.Length; i++)
            //{
            //    if (password[i] >= 'A' && password[i] <= 'Z')
            //    {
            //        return true;
            //    }
            //}
            //return false;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckIfContainsSymbol(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]) && !char.IsWhiteSpace(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
       public static bool CheckIfContainsWhiteSpace(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if(char.IsWhiteSpace(password[i]))
                {
                    return true;
                }    
            }
            return false;
        }
    }
}
