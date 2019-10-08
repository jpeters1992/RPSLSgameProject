using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {

        //MEMBER VARIABLES
        List<string> variousGestures;

        //CONSTRUCTOR
        public Computer()
        {
            variousGestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }

        //MEMBER METHODS


    }
}
