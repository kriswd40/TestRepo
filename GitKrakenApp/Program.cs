

namespace GitKrakenApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Executing program.");

            var classOne = new ClassOne();
            classOne.Description = "Description 1";
            classOne.ClassId = 1;

            var classTwo = new ClassOne();
            classTwo.Description = "Description 2";
            classTwo.ClassId = 2;

            var classThree = new ClassOne();
            classThree.Description = "Description 3";
            classThree.ClassId = 3;

            var classes = new List<ClassOne>();

            classes.Add(classOne);
            classes.Add(classTwo);
            classes.Add(classThree);

            foreach (var className in classes)
            {
                Console.WriteLine(className.Description + Environment.NewLine);
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
