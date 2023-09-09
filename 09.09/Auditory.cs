using System.Collections;

class Auditory:IEnumerable
{
    Student[] students = {
        new Student { FirstName = "Ryan",
            LastName = "Gosling",
            Birthday = new DateTime(1980, 11, 12),
            StudentCard = new StudentCard { Id = 12233, Series = "RG" }
        },

        new Student { FirstName = "Atilla",
            LastName = "Ismayil",
            Birthday = new DateTime(2008, 10, 7),
            StudentCard = new StudentCard { Id = 10078, Series = "AI" }
        },
        new Student { FirstName = "Napoleon",
            LastName = "Bonapart",
            Birthday = new DateTime(1769, 8, 15),
            StudentCard = new StudentCard { Id = 19328, Series = "NB" }
        },
        new Student { FirstName = "Allita",
            LastName = "Limasi",
            Birthday = new DateTime(2080, 7, 10),
            StudentCard = new StudentCard { Id = 07436, Series = "AL" }
        },
        new Student { FirstName = "Aelita",
            LastName = "Marsianskaya",
            Birthday = new DateTime(3025, 12, 31),
            StudentCard = new StudentCard { Id = 31532, Series = "AM" }
        }
    };

   

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public void Sort(IComparer comparer)
    {
        Array.Sort(students,comparer);
    }
    public void Sort()
    {
        Array.Sort(students);
    }

}  
    