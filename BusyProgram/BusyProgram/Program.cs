using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BusyProgram
{
    class Program
    {
        static Random generator = new Random();
        static String lastVerb = "";
        static String lastNoun = "";

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Really Productive Program";
            Console.WriteLine("Welcome to the Really Productive Program. Please wait...");
            try
            {
                Thread.Sleep(500);
                runProgram();
            }
            catch (Exception )
            {
            }
        }

        static void runProgram()
        {
            while (true)
            {
                Console.Write(getRandomAction());
                Thread.Sleep(generator.Next(200, 401));
                Console.Write(".");
                Thread.Sleep(generator.Next(150, 301));
                Console.Write(".");
                Thread.Sleep(generator.Next(250, 501));
                Console.Write(".");
                Thread.Sleep(generator.Next(150, 301));
                Console.WriteLine("Done!");
                Thread.Sleep(generator.Next(100, 201));
            }
        }

        static String getRandomAction()
        {
            String noun;
            String verb;
            do
            {
                noun = StaticData.NOUNS[generator.Next(0, StaticData.NOUNS.Length)];
                verb = StaticData.VERBS[generator.Next(0, StaticData.VERBS.Length)];
            } while (lastVerb == verb && lastNoun == noun);

            verb = verb.Substring(0, 1).ToUpper() + verb.Substring(1);
            return verb + " " + noun;
        }
    }
}
