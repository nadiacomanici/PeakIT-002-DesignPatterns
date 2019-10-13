using System;
using TemplateMethod_Museum_Demo.Logic;

namespace TemplateMethod_Museum_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Museum museum = new Museum();

            museum.Visit(new Child("Mehmet Sultanul", 4));
            museum.Visit(new Child("Cristina Pop", 6));
            museum.Visit(new Adult("Rafael Popescu", 20));
            museum.Visit(new Adult("Nadia Comanici", 33));
            museum.Visit(new Senior("Mihai Lungu", 83));

            Console.WriteLine($"The museum's income from tickets: {museum.IncomeFromTickets}");
        }
    }
}
