using System.Reflection;
using Library_management.Exception;

namespace Library_management;

public class LibraryService
{
    private Repository<Book> _bookrepo = new();
    private Repository<Member> _memberrepo = new();

    public void AddBook(Book book) => _bookrepo.Add(book);
    public bool FindBook(int bookId) => _bookrepo.Find(b => b.Id == bookId) != null;
    public IEnumerable<Book> GetAllBooks() => _bookrepo.GetAll() as IEnumerable<Book>;
    public void RemoveBook(int bookId)
    {
        var book = _bookrepo.Find(b => b.Id == bookId);
        if (book is null)
        {
            throw new BookNotFoundException($"Book {bookId} not available");
        }
            _bookrepo.Remove(book);
    }

    public bool FindMember(int memberId) => _memberrepo.Find(m => m.MemberId == memberId) != null;
    public Student GetMember(int memberId) => _memberrepo.Find(m => m.MemberId == memberId) as Student;
    public void AddMember(Member member)
    {
        if (FindMember(member.MemberId))
        {
            throw new CustomAttributeFormatException("member already exist");
        }
        _memberrepo.Add(member);
    }
}
