using System;
using Xunit;

namespace GradeBook.Test
{
    // Login method. 
    public delegate string WriteLogDelegate(string logMessage);
    
    public class TypeTests
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello Log");
            Assert.Equal(3, count);

        }

        string IncrementCount(string message)
        {
            count ++;
            return message.ToLower();

        }
        string ReturnMessage(string message)
        {
            count ++;
            return message.ToLower();

        }
        
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Fernando";
            var upper = MakeUpperCase(name);

            Assert.Equal("Fernando", name);
            Assert.Equal("FERNANDO", upper);

        }
        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(3, x); // x = 3 because, we are passing a copy of the value.
        }

        public void SetInt(ref int num)
        {
            x = 42;
        }

        public int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            // I want to check if we can change the name of the book.
            
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New name"); // Adding Ref KeyWord

            Assert.Equal("New name", book1.Name);
            //  book --reference--> book1 ---reference--> "New Name" 
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }
        
        [Fact]
        public void CanSetNameFromReference()
        {
            // I want to check if we can change the name of the book.
            
            var book1 = GetBook("Book 1");
            SetName(book1, "New name");

            Assert.Equal("New name", book1.Name);

        }
        private void SetName(Book book, string name)
        {
            book.Name = name;
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
    }
}
