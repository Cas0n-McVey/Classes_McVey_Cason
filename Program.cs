using System;

namespace Classes_McVey_Cason
{
    class Program
    {
        static void Main(string[] args)
        {
            // It's going to create an object from that class from the greetings class
            Greetings greetings = new Greetings();
            // To call Welcome Method in Greetings.cs
            greetings.Welcome();

            // Asking for your name and paints it out
            Console.WriteLine("What is your name squire?");
            string userName = Console.ReadLine();

            // To call Hello Method in Greetings.cs
            greetings.Hello(userName);
        }
    }
}
    

