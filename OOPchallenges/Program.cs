using System;

namespace OOPchallenges
{
    class Program
    {
        class Dog
        {
             string name;
            int spots;
            double happiness;


            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"the dog {name} has been born.");
            }
            public double Happiness
            {
                get { return happiness; }
            }
            public void Barks()
            {
                Console.WriteLine("woof woof");
                happiness += 0.2;

            }

            public void Wiggle()
            {
                Console.WriteLine("WIGGLE VIGGLE");
            }
            public void Rename(string newName)
            {
                name = newName;
            }
            public void ShowDogData()
            {
                Console.WriteLine($"name: {name}; Spots: {spots}; Happy: {happiness}; ");
            }

        }
        static void Main(string[] args)
        {
            Dog newDog = new Dog("Snicku", 10);
           Console.WriteLine($"the level of happiness: {newDog.Happiness}");
            newDog.Barks();
            while(newDog.Happiness != 1)
            {
                newDog.Barks();
                Console.WriteLine(newDog.Happiness);
            }

            newDog.Wiggle();

            Console.WriteLine("name the dog: ");
            string newDogName = Console.ReadLine();
            newDog.Rename(newDogName);
            newDog.ShowDogData();

        }
    }
}
 