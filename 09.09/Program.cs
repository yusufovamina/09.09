#region IFoo IBar
//FooBar fooBar = new FooBar();
//fooBar.Foo();

//IFoo foo=new FooBar();
//foo.Foo();
//((IBar)foo).Foo();
//IBar bar = new FooBar();
//bar.Foo();

//interface IFoo
//{
//    void Foo();
//}

//interface IBar
//{
//    void Foo();
//}

//class FooBar : IFoo, IBar
//{
//    //public void Foo()
//    //{
//    //    Console.WriteLine("Hello world!!!");
//    //}

//    void IFoo.Foo() {
//        Console.WriteLine("Foo Hello World");
//    }

//    void IBar.Foo()
//    {
//        Console.WriteLine("Bar Hello World");
//    }
//    public void Foo()
//    {
//        Console.WriteLine("Hello world!!!");
//    }
//}

#endregion

using System.Xml.Linq;

Auditory auditory =new Auditory();
foreach(var student in auditory)
{
    Console.WriteLine(student);
}
Console.WriteLine();
auditory.Sort();
foreach (var student in auditory)
{
    Console.WriteLine(student);
}

Student st = new Student()
{
    FirstName = "oRyan",
    LastName = "oGosling",
    Birthday = new DateTime(1980, 11, 12),
    StudentCard = new StudentCard { Id = 100003, Series = "RG" }
};
Student st2=(Student)st.Clone();

class Student:ICloneable,IComparable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }

    public StudentCard StudentCard { get; set; }

    public object Clone() //deep copy
    {
       Student tmp = (Student)this.MemberwiseClone();   // shallow copy 
        tmp.StudentCard = new StudentCard()
        {
            Series = this.StudentCard.Series,
            Id = this.StudentCard.Id,
        };
        return tmp;
    }

    public int CompareTo(object? obj)
    {
        if (obj is Student student)
        {
            return FirstName.CompareTo(student.FirstName);
        }
        throw new NotImplementedException();    
    }

    public override string ToString()
    {
        return $"{FirstName} - {LastName} - {StudentCard}";
    }
}
