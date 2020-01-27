using System;
using Xunit;



namespace Gradebook.Tests

{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            var book1 = new GetBook("Book 1");
            var book2 = new GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

            
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
