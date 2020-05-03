using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{




    class Program
    {
        static void MultipleLegs(PetStruct petStruct, PetClass petClass)
        {
            petStruct.Legs = petStruct.Legs * 2;
            petClass.Legs = petClass.Legs * 2;
            Console.WriteLine("Internal Method - A " + petStruct.Type + " has " + petStruct.Legs + " legs");
            Console.WriteLine("Internal Method - A " + petClass.Type + " has " + petClass.Legs + " legs");
        }


        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            string[] stringArray = new string[10];

            int[] populatedIntArray = new int[] { 0, 1, 2, 3, 4, 5 };
            string[] populatedStringArray = new string[] { "Bob", "John", "Ron" };



            intArray[0] = 5;
            intArray[2] = 15;

            int firstvalue = intArray[0];

            int[,] multiInt = new int[2, 3];
            int[,] multiPopulatedInt = { { 1, 2, 3 }, { 3, 4, 5 } };
            int firstMultivalue = multiPopulatedInt[0, 0]; //value would be 1
            int secondMultivalue = multiPopulatedInt[1, 2]; //value would be 5

            List<string> listOfString = new List<string>();
            listOfString.Add("First string added to list");
            listOfString.Insert(0, "Inserted to the top of the list");
            listOfString.Remove("First string added to list");
            listOfString.RemoveAt(0);

            listOfString.Sort();
            var theFirstStringis = listOfString[0];

            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("James", "Bonds");
            names.Add("lebron", "James");

            Console.WriteLine("The name is " + names["James"]);

            names.Remove("James");





            PetStruct dog = new PetStruct();
            dog.Type = PetType.Dog;
            dog.Legs = 4;
            dog.HasFur = true;
            dog.Name = "Doggy";



            PetClass duck = new PetClass();
            duck.Name = "Ugly";
            duck.Type = PetType.Duck;
            duck.Legs = 2;
            duck.HasFur = false;

            //Outside method
            Console.WriteLine("a " + dog.Type + " has " + dog.Legs + " legs ");
            Console.WriteLine("a " + duck.Type + " has " + duck.Legs + " legs ");

            MultipleLegs(dog, duck);

            //Outside method
            Console.WriteLine("a " + dog.Type + " has " + dog.Legs + " legs ");
            Console.WriteLine("a " + duck.Type + " has " + duck.Legs + " legs ");


            Console.ReadLine();



        }
    }

    class PetClass
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;
    }

    struct PetStruct
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;
    }


    enum PetType
    {
        Dog,
        Duck
    }
}
