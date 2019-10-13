namespace Strategy_Museum_End.Logic.Strategies
{
    public class SeniorTicketStrategy : ITicketStrategy
    {
        public double TicketPriceMultiplier
        {
            get
            {
                return 0.5;
            }
        }
    }
}
