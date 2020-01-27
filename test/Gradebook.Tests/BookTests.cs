using System;
using GradeBook;
using Xunit;

namespace Gradebook.Test1

{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
           var book = new Book("");
           book.AddGrade(89.1);
           book.AddGrade(90.5);
           book.AddGrade(77.3);

        

            // act
           var result = book.GetStatistics();

            // asssert
           Assert.Equal(85.6, result.Average,1);
           Assert.Equal(90.5, result.High);
           Assert.Equal(77.3, result.Low);

        }
    }
}
