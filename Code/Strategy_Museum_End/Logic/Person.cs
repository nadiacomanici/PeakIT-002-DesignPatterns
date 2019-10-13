using Strategy_Museum_End.Logic.Strategies;

namespace Strategy_Museum_End.Logic
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public ITicketStrategy TicketStrategy { get; private set; }

        public Person(string name, int age, ITicketStrategy ticketStrategy)
        {
            Name = name;
            Age = age;
            TicketStrategy = ticketStrategy;
        }
    }
}
