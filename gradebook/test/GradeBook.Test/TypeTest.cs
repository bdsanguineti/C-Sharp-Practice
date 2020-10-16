using System;
using Xunit;

namespace GradeBook.Test
{
    public class TypeTests
    {
        [Fact]
        public void CanSetNameFromReference()
        {
            // I want to check if we can change the name of the book.
            
            var book1 = GetBook("Book 1");
            SetName(book1, "New name");

            Assert.Equal("New name", book1.Name);

        }
        
        [Fact]
        public void GetBookReturnsDiferentObjects()
        {
            // I want to invoke a mothod that will instantiate a book. 
            // And then write some test that can prove that every book is returned is the same object
            // or its a different object.

            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.name);
            Assert.Equal("Book 2", book2.name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // I want to invoke a mothod that will instantiate a book. 
            // And then write some test that can prove that every book is returned is the same object
            // or its a different object.

            var book1 = GetBook("Book 1");
            var book2 = book1;

            //Assert.Equal("Book 1", book1.name);
            //Assert.Equal("Book 1", book2.name);
            Assert.Same(book1, book2); // Two variables CAN referent the same object.
            Assert.True(Object.ReferenceEquals(book1, book2)); // Is The Same Reference.
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        
    }
}
