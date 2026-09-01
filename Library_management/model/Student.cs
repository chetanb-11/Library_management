using System.Runtime.CompilerServices;

namespace Library_management;

public class Student : Member
{
    public Student(int memberId, string name, string email) : base(memberId, name, email, "student")
    {
        Console.WriteLine("Student Account created");
    }

    public bool AlotBook(int bookId)
    {
        throw new NotImplementedException();
    }

    public void ReturnBook(int bookId)
    {
        throw new NotImplementedException();
    }
}