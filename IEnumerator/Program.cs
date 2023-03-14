using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogShelter dogShelter = new DogShelter();

            foreach (Dog dog in dogShelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }else
                {
                    dog.GiveTreat(1);
                }
            }
        }
    }

    class Dog
    {
        public string Name { get; set;}
        public bool IsNaughtyDog { get; set; }

        public Dog(string name, bool isNaughtyDog) {
            Name = name;
            IsNaughtyDog = isNaughtyDog;
        }

        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine("Dog {0} said woof {1} times!", Name, numberOfTreats);
        }
    }

    class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        System.Collections.IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
