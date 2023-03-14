using System;
using System.Collections.Generic;
using System.Linq;

namespace Лаба_1.__3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("3 завдання");
          
            int lght = 4;

            List<string> line = new List<string>()
            {
                "FDAS",
                "GFRS",
                "DSRE",
                "LKOM",
                "TREV"
            };

            var selectedLine = line.Where(l => l.Length == lght).OrderByDescending(l=>l).FirstOrDefault();
          
            Console.WriteLine(selectedLine);
        }
    }
}