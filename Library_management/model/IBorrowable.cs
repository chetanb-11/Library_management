namespace Library_management;

public interface IBorrowable
{
    public bool BorrowBook(Book bookId);
    public void ReturnBook(Book bookId);
}