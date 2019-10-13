using Strategy_Museum_Begin.Strategy;

namespace Strategy_Museum_Demo.Logic
{
    public class Person
    {
        private ITicketMultiplier ticketMultiplierStrategy;

        public string Name { get; private set; }
        public int Age { get; private set; }

        public double TicketMultiplier
        {
            get
            {
                return ticketMultiplierStrategy.TicketMultiplier;
            }
        }

        public Person(string name, int age, ITicketMultiplier ticketMultiplierStrategy)
        {
            Name = name;
            Age = age;
            this.ticketMultiplierStrategy = ticketMultiplierStrategy;
        }
    }
}
