namespace GradeBook
{
    public abstract class Book : BookBase
    {
        public Book(string name) : base(name)
        {

        }
        public abstract void Addgrade(double grade);
    }
}