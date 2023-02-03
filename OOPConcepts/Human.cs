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
        public Human(string firstName, string lastName, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
        }

        //members
        private string firstName;
        private string lastName;
        private int age;


        //member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0} {1}.I am {2} years old.", firstName, lastName, age);
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

        public void setAge(int newAge)
        {
            this.age = newAge;
        }

        public int getAge()
        {
            return this.age;
        }

    }
}
