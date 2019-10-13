using System;
using Strategy_Museum_Begin.Strategy;
using Strategy_Museum_Demo.Logic;

namespace Strategy_Museum_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Museum museum = new Museum();

            museum.Visit(new Person("Mehmet Sultanul", 4, new ChildTicketMultiplier()));
            museum.Visit(new Person("Cristina Pop", 6, new ChildTicketMultiplier()));
            museum.Visit(new Person("Rafael Popescu", 20, new AdultTicketMultiplier()));
            museum.Visit(new Person("Nadia Comanici", 33, new AdultTicketMultiplier()));
            museum.Visit(new Person("Mihai Lungu", 83, new SeniorTicketMultiplier()));

            Console.WriteLine($"The museum's income from tickets: {museum.IncomeFromTickets}");
        }
    }
}
