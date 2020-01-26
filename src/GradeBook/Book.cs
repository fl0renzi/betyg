using System;
using System.Collections.Generic;

namespace GradeBook 
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name; 
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
                public void ShowStatistics()
        {
            var resultat = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(double number in grades)
            {
               highGrade = Math.Max(number,highGrade);
               lowGrade = Math.Min(number, lowGrade);
                resultat += number;
            }
            resultat /=  grades.Count;
            //resultat = Math.Round((double)resultat,2);
            Console.WriteLine($"Det lägsta betyget är {lowGrade}");
            Console.WriteLine($"Det högsta betyget är  {highGrade}");
            Console.WriteLine($"Medeltalet av dessa 5 tal är:{resultat:N1}");
        }
   
        private List<double> grades;


        private string name;

    }

}