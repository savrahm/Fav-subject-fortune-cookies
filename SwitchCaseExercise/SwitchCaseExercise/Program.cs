using System;

namespace SwitchCaseExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me your favorite subject in school and I'll tell you your future.");

            string favSub = Console.ReadLine();

            switch (favSub)
            {
                case "math":
                    Console.WriteLine("Math fortune cookie: You are like a whale in the desert.");
                    break;
                case "english":
                    Console.WriteLine("English fortune cookie: You will soon meet a tall dark stranger. Outcome unforeseen.");
                    break;
                case "social studies":
                    Console.WriteLine("Social studies fortune cookie: Prepare for a long voyage.");
                    break;
                case "recess":
                    Console.WriteLine("Recess fortune cookie: Seek and ye shall find. Treasure awaits, but at what cost?");
                    break;
                case "lunch":
                    Console.WriteLine("Lunch fortune cookie: Lunch will be disappointing. Dinner will be better.");
                    break;
                default:
                    Console.WriteLine("I'm not familiar with that subject, but sometimes it's better not to know what's coming.");
                    break;
            }
        }
    }
}
