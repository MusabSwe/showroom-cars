namespace Task2
{
    class MotorBike : Bike{
        private string name;
        private int speedTracker;

        public MotorBike(string MotorName){

            this.name = MotorName;
        }

        public void setMotorBikeName(string n)
        {
            this.name = n;
        }

        public string getMotorBikeNameName()
        {
            return name;
        }

        public int displaySpeed(){
            return speedTracker;
        }
    }
}