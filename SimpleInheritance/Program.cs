using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 
    class Cat : Animal
    {
        public double length;
        public double height;
        public string color;
        public Cat()
            : base()
        {
            length = 0;
            height = 0;
            color = "";
        }
        public Cat(string name, string color, double length, double height)
            : base(name)
        {
            this.color = color;
            this.length = length;
            this.height = height;
        }
        public void getName()
        {
            Console.WriteLine($"My name is {name}");
        }
        public void getColor()
        {
            Console.WriteLine($"I am {color}");
        }
        public void getLength()
        {
            Console.WriteLine($"I am {length} inches long");
        }
        public void getHeight()
        {
            Console.WriteLine($"I am {height} inches tall");
        }
        public void display2()
        {
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am {color}");
            Console.WriteLine($"I am {length} inches long");
            Console.WriteLine($"I am {height} inches tall");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Cat kitten = new Cat();

            //derived class object using parameterized constructor
            kitten.name = "Loki";
            kitten.color = "Grey";
            kitten.length = 12;
            kitten.height = 8;
            kitten.display2();
        }

    }
}
