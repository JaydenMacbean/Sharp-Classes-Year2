using System;

namespace DaGrunt
{
    public class BaseClass
    {
        protected int HealthModifier = 50;

        protected int Strength = 5;
        protected int Defense = 5;
        protected int Magic = 5;
        protected int Resistance = 5;

        private int SpeedModifier = 5;

    }

    class BlackMage : BaseClass
    {
        public BlackMage()
        {
            Strength = 2;
            Magic = 10;
            Defense = 2;
            Resistance = 3;
            
        }
    }
 
}
