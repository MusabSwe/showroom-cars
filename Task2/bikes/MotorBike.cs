namespace Task2
{
    class MotorBike : Bike
    {
        private string Name;
        private int speedTracker;

        public MotorBike(string MotorName)
        {

            this.Name = MotorName;
        }

        public MotorBike()
        {

        }

        public string NameProp { get; set; }
        public int SpeedTracker { get; set; }

        public int displaySpeed()
        {
            return SpeedTracker;
        }
    }
}