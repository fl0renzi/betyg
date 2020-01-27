using System;
using System.Collections.Generic;

namespace GradeBook 
{
   public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name; 
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
                public Statistics GetStatistics()
        {
            var resultat = new Statistics();
            resultat.Average = 0.0;
            
            resultat.High = double.MinValue;
            resultat.Low = double.MaxValue;

            foreach(var grade in grades)
            {
            resultat.High = Math.Max(grade,resultat.High);
            resultat.Low = Math.Min(grade, resultat.Low);
            resultat.Average += grade;
            }
            resultat.Average /=  grades.Count;
            //resultat = Math.Round((double)resultat,2);
           return resultat;
        }
   
        private List<double> grades;


        public string Name;

    }

}