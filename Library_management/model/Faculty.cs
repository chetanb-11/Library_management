namespace Library_management;

public class Faculty : Member
{
    public Faculty(int memberId, string name, string email) : base(memberId, name, email, "faculty")
    {
        Console.WriteLine("Faculty profile created");
    }
    public bool AlotBook(int bookId)
    {
        throw new NotImplementedException();
    }

    public void RemoveBook(int bookId)
    {
        throw new NotImplementedException();
    }
}