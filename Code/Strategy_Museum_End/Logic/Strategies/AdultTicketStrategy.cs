namespace Strategy_Museum_End.Logic.Strategies
{
    public class AdultTicketStrategy : ITicketStrategy
    {
        public double TicketPriceMultiplier
        {
            get
            {
                return 1.0;
            }
        }
    }
}
