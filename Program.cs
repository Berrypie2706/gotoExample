using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Again:
            Console.WriteLine("Enter User Name");
            userName = Console.ReadLine();
            if (userName.Length >= 6)
            {
                Console.WriteLine("Welcome : \t " + userName);
            }
            else
            {
                Console.WriteLine("Invalid user");
                goto Again;
            }
            Console.ReadKey();
        }
    }
}
