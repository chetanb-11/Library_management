namespace Library_management;

public interface IBorrowable
{
    public bool AlotBook(int bookId);
    public void ReturnBook(int bookId);
}