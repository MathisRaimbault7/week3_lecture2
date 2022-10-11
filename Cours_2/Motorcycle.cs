using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_2
{
    public abstract class Motorcycle
    {
        double miles = 10;  
        double speed = 100;

        public virtual int Drive(int miles, int speed)
        {
            return (int)Math.Round(((double)miles) / speed, 0);
        }

        public void StartEngine() { }

        protected void AddGas(int gallons) { }
        

        public virtual int Drive(TimeSpan time, int speed) { return 0;}

        public abstract double GetTopSpeed();
    }
    public class SportsMotorocycle : Motorcycle
    {
        public override double GetTopSpeed()
        {
            return 1;
        }
        double _weightRatio = 1.2;
        public override int Drive(int miles, int speed)
        {
            return (int)Math.Round(((double)miles)/speed,0) * (int)_weightRatio;
        }
    }

    public class SportsMotorCycleWithSideCar : Motorcycle
    {
        public override double GetTopSpeed()
        {
            return 1;
        }

        float _weightRatio = 0.8F;
        public override int Drive(int miles, int speed)
        {
            return base.Drive(miles, speed) * (int)_weightRatio;
        }
    }
}
