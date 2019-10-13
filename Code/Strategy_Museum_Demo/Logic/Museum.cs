using System.Collections.Generic;

namespace Strategy_Museum_Demo.Logic
{
    public class Museum
    {
        private const double _fullTicketPrice = 5;
        private List<Person> _visitors;

        public double IncomeFromTickets { get; private set; }

        public Museum()
        {
            _visitors = new List<Person>();
            IncomeFromTickets = 0;
        }

        public void Visit(Person person)
        {
            _visitors.Add(person);
            IncomeFromTickets += _fullTicketPrice * person.TicketMultiplier;
        }
    }
}
