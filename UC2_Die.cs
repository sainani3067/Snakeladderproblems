using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_LadderProblems
{
    class UC2_Die
    {
        public static void getRoll()
        {
            Random rNumber = new Random();
            int roll = rNumber.Next(1, 7);
            Console.WriteLine(roll);
        }
    }
}

