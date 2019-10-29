using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    static class UserInterface
    {
        //MEMBER METHODS
        public static string RetrieveUserInput(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
