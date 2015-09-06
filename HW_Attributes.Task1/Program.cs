using System;

namespace HW_Attributes.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.Print(new MyClass());

            Console.ReadKey();
        }
    }
}
