using System;
using System.Collections.Generic;

namespace GradeBook
{
   
    class Program
    {
        static void Main(string[] args)
        {   
            
            var book = new Book("Johans betyg");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();
             Console.WriteLine($"Det lägsta betyget är {stats.Low}");
            Console.WriteLine($"Det högsta betyget är  {stats.High}");
            Console.WriteLine($"Medeltalet av dessa 5 tal är:{stats.Average}");

            
        }
    }
}
