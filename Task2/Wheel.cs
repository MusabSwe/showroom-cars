using System;

namespace Task2
{
    class Wheel
    {

        private string tireName;
        private string tireType;
        private DateTime tireDate;
        private double tireSize;
        private string carName;
        public Wheel(string carName, string TireName, string type, DateTime date, double size)
        {

            this.carName = carName;
            this.tireName = TireName;
            this.tireType = type;
            this.tireDate = date;
            this.tireSize = size;
        }

        public Wheel(){
            
        }

        public void setTireName(string n)
        {
            this.tireName = n;
        }

        public string getTireName()
        {
            return tireName;
        }

        public void setTireType(string n)
        {
            this.tireType = n;
        }

        public string getTireType()
        {
            return tireType;
        }

        public void setTireDate(DateTime n)
        {
            this.tireDate = n;
        }

        public DateTime getTireDate()
        {
            return tireDate;
        }

        public void setTireSize(double n)
        {
            this.tireSize = n;
        }

        public double getTireSize()
        {
            return tireSize;
        }

        public string toString()
        {

            return "Wheel information for " + carName + " car:\nName: " + getTireName() + "\nDate: " + getTireDate() + "\nType: " + getTireType() + "\nSize: " + getTireSize();
        }

    }
}