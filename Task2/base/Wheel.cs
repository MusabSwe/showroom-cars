using System;

namespace Task2
{
    public class Wheel
    {
        public int WheelId { get; set; }
        
        public string TireName { get; set; }

        public string TireType { get; set; }

        public DateTime TireDate { get; set; }

        public double TireSize { get; set; }

        public Wheel(string TireName, string type, DateTime date, double size)
        {
            this.TireName = TireName;
            this.TireType = type;
            this.TireDate = date;
            this.TireSize = size;
        }

        public Wheel()
        {
        }


        public string toString()
        {
            return "Wheel information are :\nName: " + TireName + "\nDate: " + TireDate + "\nType: " + TireType +
                   "\nSize: " + TireSize;
        }
    }
}
