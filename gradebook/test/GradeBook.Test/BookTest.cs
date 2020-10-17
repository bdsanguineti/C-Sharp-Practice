using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTests
    {
        [Fact]
        public void BookCalculateAnAverageGrade()
        {
            // Arrange
            var book = new Book(""); // Its Legal have a empty name? 
            var result = new Stadistics;
        
            book.AddGrade(23.1);
            book.AddGrade(72.1);
            book.AddGrade(24.1);

            // Act
            book.GetStadistics();

            // Assert
            Assert.Equal(86.3, result.Average, 1);
            Assert.Equal(6.3, result.LowValue, 1);
            Assert.Equal(76.3, result.HighValue, 1);
            Assert.Equal('B', result.Letter);
        }
        
    }
}
