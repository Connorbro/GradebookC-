using System;
using System.Collections.Generic;

namespace GradeBook
{

  
    class Program
    {
        static void Main(string[] args)
        { 
            var book = new Book("Connor's Grade Book");
            
            var done = false; 

            while(!done)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
            }


            var stats = book.GetStatistics();

            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }    
    }
}
