using System;
using Library_management.Controller;

namespace Library_management
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty faculty = new Faculty(123456, "123456", "123456@gmail.com");
            
            Console.WriteLine("Enter member is");
            var memberId = int.Parse(Console.ReadLine());
            
            if (memberId == faculty.MemberId)
            {
                FacultyControl facultyControl = new();
                facultyControl.Control(memberId);
            }
            else
            {
                StudentControl studentControl = new();
                studentControl.control(memberId);
            }
        }
    }
}