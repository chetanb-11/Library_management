namespace Library_management.Controller;

public class StudentControl
{
    Student CreateStudent(int studentId)
    {
        Console.WriteLine("Member doesn't exist, enter your details");

        // need to do required
        Console.WriteLine("Email: ");
        var email = Console.ReadLine();
        Console.WriteLine("name: ");
        var name = Console.ReadLine();

        return new(studentId, name, email);
        // memberService.AddMember(student);
    }

    public void control(int studentId)
    {
        LibraryService memberService = new();
        var memberExist = memberService.FindMember(studentId);
        Student student;
        if (!memberExist)
        {
            student = CreateStudent(studentId);
            memberService.AddMember(student);
        }
        else

        {
            Console.WriteLine("Welcome back");
            student = memberService.GetMember(studentId);
        }

        Console.WriteLine("How do you wanna continue?(borrow(book), return(book))");

        var request = Console.ReadLine();
        if (request == "borrow")
        {
            Console.WriteLine("Enter the book id you want to borrow");
            int.TryParse(Console.ReadLine(), out int bookId);
            if (student.BorrowBook(new(bookId)))
            {
                Console.WriteLine("book borrowed successfully");
            }
            else
            {
                Console.WriteLine("bool don't exist in database");
            }
        }

        else if (request == "return")
        {
            Console.WriteLine("Enter the book id you want to return");
            int.TryParse(Console.ReadLine(), out int bookId);
            Console.WriteLine("book removing in process");
            student.ReturnBook(new Book(bookId));
        }
    }
}