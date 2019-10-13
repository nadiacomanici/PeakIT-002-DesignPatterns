namespace TemplateMethod_Museum_Demo.Logic
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public abstract double TicketMultiplier { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Child : Person
    {
        public override double TicketMultiplier
        {
            get { return 0.0; }
        }

        public Child(string name, int age) : base(name, age)
        {
        }
    }

    public class Adult : Person
    {
        public override double TicketMultiplier
        {
            get { return 1.0; }
        }

        public Adult(string name, int age) : base(name, age)
        {
        }
    }

    public class Senior : Person
    {
        public override double TicketMultiplier
        {
            get { return 0.5; }
        }

        public Senior(string name, int age) : base(name, age)
        {
        }
    }
}
