
using ConsoleAppPractice.Pepole;

namespace ConsolAppPractice // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Mansor";
            person.Age = 49;
            person.HasPet = true;

            person.Greeting();
        }
    }
}







