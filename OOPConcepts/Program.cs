using System;
using System.Security.Cryptography.X509Certificates;

namespace OOPConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object of class Human
            Human denis = new Human("Denis", "Markovic");

            //Call methods of the class
            denis.IntroduceMyself();

            denis.setFirstName("Igor");
            denis.setLastName("Cancar");

            //getter testing;
            Console.WriteLine("Current object firstName and lastName are: {0} {1}.", denis.getFirstName(), denis.getLastName());

            denis.IntroduceMyself();

            
        }
    }
}
