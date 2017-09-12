using System;
using TestTask.Logic.Classes;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            SentenceBuilder str = new SentenceBuilder(new Sentence(), "hello test automation training");
            Console.WriteLine("Initial string : " + str.ToString());

            try
            {
                str.ReplaceChar(6, '$');
                Console.WriteLine("The string after replacement : " + str.ToString());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ArgumentOutOfRangeException is occured");
            }
                      
            Console.ReadKey();
        }
    }
}
