namespace GradeBook
{
    public abstract class BookBase : NamedObject
    {
        public BookBase(string name) : base(name)
        {
            
        }
        public abstract void AddGrade(double grade); // Everything that is a BookBase have a AddGrade Method. But at this level I cant provide an implementation
    }
}