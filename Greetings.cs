using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_McVey_Cason
{
    internal class Greetings
    {
        /// <summary>
        /// Welcoming you
        /// </summary>
        public void Welcome()
        {
            Console.WriteLine("Hello Traveler, welcome!");
        }
        /// <summary>
        /// Tells you the name you put down and paints it
        /// </summary>
        /// <param name="name"></param>
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, thank you for joining us today!");
        }
    }
}
