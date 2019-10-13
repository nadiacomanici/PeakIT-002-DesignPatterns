using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Museum_Begin.Strategy
{
    public interface ITicketMultiplier
    {
        double TicketMultiplier { get; }
    }

    public class ChildTicketMultiplier : ITicketMultiplier
    {
        public double TicketMultiplier
        {
            get { return 0; }
        }
    }

    public class AdultTicketMultiplier : ITicketMultiplier
    {
        public double TicketMultiplier
        {
            get { return 1; }
        }
    }

    public class SeniorTicketMultiplier : ITicketMultiplier
    {
        public double TicketMultiplier
        {
            get { return 0.5; }
        }
    }
}
