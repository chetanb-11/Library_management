namespace Library_management;

public class Book
{
    public int Id { get; private set; }
    
    public Book(int bookId)
    {
        Id = bookId;
    }
}