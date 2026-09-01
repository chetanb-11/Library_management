using System.Net.Mail;

namespace Library_management;

public abstract class Member : IBorrowable
{
    public int MemberId;
    public string Name;
    public string Email;
    private string _position;
    public List<int> booksIssued { get; private set; }

    public Member(int memberId, string name, string email, string position)
    {
        Name = name;
        Email = email;
        MemberId = memberId;
        _position = position;
    }

    public bool AlotBook(int bookId)
    {
        LibraryService libraryService = new();
        if (libraryService.FindBook(bookId))
        {
            booksIssued.Add(bookId);
            return true;
        }

        return false;
    }

    public void ReturnBook(int bookId)
    {
        booksIssued.Remove(bookId);
    }
}