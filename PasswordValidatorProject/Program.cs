using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password.Verify("Test1");
            Console.WriteLine("--------------");
            Password.Verify("test1");
            Console.WriteLine("--------------");

            Password.Verify("Test#@");
            Console.WriteLine("--------------");

            Password.Verify("Test112@#dsa");
            Console.WriteLine("--------------");

            Password.Verify("Test1243423");
            Console.WriteLine("--------------");

            Password.Verify(" ");
        }
    }
}
