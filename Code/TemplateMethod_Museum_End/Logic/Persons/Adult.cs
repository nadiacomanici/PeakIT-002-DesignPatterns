namespace TemplateMethod_Museum_End.Logic.Persons
{
    public class Adult : Person
    {
        public Adult(string name, int age) : base(name, age)
        {
        }

        public override double TicketPriceMultiplier
        {
            get { return 1.0; }
        }
    }
}
