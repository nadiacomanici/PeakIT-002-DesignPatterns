namespace AbstractFactory_Cars_Demo.Classes.Electric
{
    public class ElectricEngine : Engine
    {
        public override double GetComsumptionInHalfASecondBasedOnSpeed(double speed)
        {
            if (State != EngineState.Stopped)
            {
                switch (speed)
                {
                    case double n when (n == 0):
                        return 0.02;

                    case double n when (0 < n && n <= 30):
                        return 0.4;

                    case double n when (30 < n && n <= 80):
                        return 1.5;

                    case double n when (80 < n && n <= 110):
                        return 5;

                    case double n when (110 < n):
                        return 10;
                }
            }
            return 0;
        }
    }
}
