using System.Runtime.CompilerServices;

namespace Library_management;

public class Student : Member
{
    public Student(int memberId, string name, string email) : base(memberId, name, email, "student")
    {
        Console.WriteLine("Student Account created");
    }
}