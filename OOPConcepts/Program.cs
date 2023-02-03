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
            denis.firstName = "Denis";

            denis.IntroduceMyself();

            
        }
    }
}
