using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class Human
    {
        //constructor
        public Human(string firstName, string lastName)
        {
            this.lastName = lastName;
            this.firstName= firstName;
        }

        //members
        private string firstName;
        private string lastName;


        //member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0} {1}.", firstName, lastName);
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;   
        }

        public string getFirstName()
        {
            return this.firstName;
        }
        
        public string getLastName()
        {
            return this.lastName; 
        }

    }
}
