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

        public Wheel()
        {

        }

        public string TireNameProp { get; set; }

        public string TireTypeProp { get; set; }

        public DateTime TireDateProp { get; set; }

         public double TireSizeProp { get; set; }

        public string toString()
        {

            return "Wheel information for " + carName + " car:\nName: " + TireNameProp + "\nDate: " + TireDateProp + "\nType: " + TireTypeProp + "\nSize: " + TireSizeProp;
        }

    }
}