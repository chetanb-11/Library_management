using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Library_management;

public abstract class Member : IBorrowable
{
    public int MemberId;
    [Required(ErrorMessage = "Name of the member is required")]
    public string Name;
    [Required(ErrorMessage = "email of the member is required")]
    public string Email;
    [Required(ErrorMessage = "position of the member is required")]
    private string _position;

    private List<int> booksIssued { get; set; } = new List<int>();

    protected Member(int memberId, string name, string email, string position)
    {
        Name = name;
        Email = email;
        MemberId = memberId;
        _position = position;
    }

    public virtual bool BorrowBook(Book book)
    {
        LibraryService libraryService = new();
        if (libraryService.FindBook(book.Id))
        {
            booksIssued.Add(book.Id);
            return true;
        }

        return false;
    }

    public virtual void ReturnBook(Book book)
    {
        booksIssued.Remove(book.Id);
    }
}