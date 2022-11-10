

namespace GitKrakenApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Executing program.");

            // Adding items to create a longer file.
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            int x = 5;
            int y = 6;
            int z = 7;

            var classOne = new ClassOne();
            classOne.Description = "Description 1";
            classOne.ClassId = 1;

            var classTwo = new ClassOne();
            classTwo.Description = "Description 2";
            classTwo.ClassId = 2;

            var classThree = new ClassOne();
            classThree.Description = "Description 3";
            classThree.ClassId = 3;

            var classFour = new ClassOne();
            classFour.Description = "Description 4";
            classFour.ClassId = 4;

            var classes = new List<ClassOne>();

            classes.Add(classOne);
            classes.Add(classTwo);
            classes.Add(classFour);
            classes.Add(classThree);

            foreach (var className in classes)
            {
                Console.WriteLine("1:" + className.Description + Environment.NewLine);
            }

            foreach (var className in classes)
            {
                Console.WriteLine("2:" + className.Description + Environment.NewLine);
            }

            foreach (var className in classes)
            {
                Console.WriteLine("3:" + className.Description + Environment.NewLine);
            }

            foreach (var className in classes)
            {
                Console.WriteLine("4:" + className.Description + Environment.NewLine);
            }

            var betterClass = new BetterClass()
            {
                Description = "BetterClass",
                ClassId = 5,
                ExtraData = "Extra data on this class."
            };

            classes.Add(betterClass);

            foreach (var className in classes)
            {
                Console.WriteLine("5:" + className.Description + Environment.NewLine);
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
