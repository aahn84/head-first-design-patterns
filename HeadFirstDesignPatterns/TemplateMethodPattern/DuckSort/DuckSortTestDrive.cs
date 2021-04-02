using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace app.HeadFirstDesignPatterns.TemplateMethodPattern.DuckSort
{
    public class DuckSortTestDrive
    {
        public static void Run()
        {
            Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2),
            };

            Console.WriteLine();
            Console.WriteLine("Before sorting:");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine();
            Console.WriteLine("After sorting:");
            Display(ducks);
        }

        public static void Display(IEnumerable<Duck> ducks)
        {
            foreach (var duck in ducks)
            {
                Console.WriteLine(duck);
            }
        }
    }
}