namespace Library_management.Controller;

public class FacultyControl
{
    public void Control(int memberId)
    {
        LibraryService memberService = new();
        while (true)
        {
            Console.WriteLine("Books in database:");
            var books = memberService.GetAllBooks();

            if (books.Count() == 0) Console.WriteLine("No book exist in record");
            else
                foreach (var book in books)
                {
                    Console.WriteLine(book.Id);
                }

            Console.WriteLine("Add(add book)/remove(remove book)/exit");
            var request = Console.ReadLine();
            if (request == "Add" || request == "add")
            {
                Console.WriteLine("Enter book id for new book");
                int NewBookId = int.Parse(Console.ReadLine());
                memberService.AddBook(new Book(NewBookId));
            }
            else if (request == "remove" || request == "remove")
            {
                Console.WriteLine("Enter book id need to be deleted");
                int bookId = int.Parse(Console.ReadLine());
                memberService.RemoveBook(bookId);
                Console.WriteLine("Book removed successfully");
            }
            else if (request == "exit")
            {
                Console.WriteLine("Thank you");
                break;
            }
            else
            {
                Console.WriteLine("enter valid option");
            }
        }
    }
}