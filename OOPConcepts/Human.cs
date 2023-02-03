using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class Human
    {
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

    }
}
