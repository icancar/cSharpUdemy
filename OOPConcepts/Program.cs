using System;
using System.Security.Cryptography.X509Certificates;

namespace OOPConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object of class Human
            Human denis = new Human();
            denis.setFirstName("Denis");
            denis.setLastName("Markovic");

            //Call methods of the class
            denis.IntroduceMyself();

            
        }
    }
}
