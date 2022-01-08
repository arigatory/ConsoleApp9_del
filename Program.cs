using System;
using static System.Console;
using System.Threading;
using System.IO;

namespace xuy
{
    class Program
    {

        static void Main(string[] ages)
        {

            string text = File.ReadAllText(@"data.txt");
            WriteLine(text);
            

        }
    }
}
