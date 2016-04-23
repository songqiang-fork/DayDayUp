using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace ConsoleApplication2
{
    class Program
    {
        static int index = 0;
        static int left = 0;
        static string[] strings =
        {
            "start.",
            "start..",
            "start...",
            "start....",
            "start.....",
            "start......",
            "start......."
        };

        static Timer timer = new Timer(500);
        static void Main(string[] args)
        {
            Console.Write("start......");
            left = Console.CursorLeft = "start......".IndexOf("start");
            timer.Elapsed += timer_Elapsed;
            timer.Start();
            Console.ReadKey();
        }

        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.CursorLeft = left;
            Console.Write("                  ");
            index++;
            Console.CursorLeft = left;
            Console.Write(strings[index % strings.Length]);
        }
    }
}
