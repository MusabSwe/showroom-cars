namespace Task2
{
    class MotorBike : Bike
    {
        
        private int speedTracker;

        public int SpeedTrackerProp { get; set; }

        public int displaySpeed()
        {
            return SpeedTrackerProp;
        }
    }
}
