using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var book = new Book(""); // Its Legal have a empty name? 
            book.addGrade("23.1");
            book.addGrade("72.1");
            book.addGrade("24.1");

            // Act
            book.getStadistics();

            // Assert
            Assert.Equal(86.3, result.average, 1);
            Assert.Equal(6.3, result.lowValue, 1);
            Assert.Equal(76.3, result.hightValue, 1);
        }
        
    }
}
