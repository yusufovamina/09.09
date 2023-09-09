
using System.Collections;

class DateComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if(x is Student student && y is Student student1)
        {
            return DateTime.Compare(student.Birthday, student1.Birthday);
        }
        throw new NotImplementedException();
    }
}
