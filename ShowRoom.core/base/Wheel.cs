using System;
using System.ComponentModel.DataAnnotations;

namespace ShowRoom.Core
{
    public class Wheel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tire Name")]
        public string TireName { get; set; }
        [Required]
        [Display(Name = "Tire Type")]
        public string TireType { get; set; }
        [Required]
        [Display(Name = "Tire Date")]
        public DateTime? TireDate { get; set; }
        [Required]
        [Display(Name = "Tire Size")]
        public double? TireSize { get; set; }
        //FK1&2
        public Car Car { get; set; }
        public Bike Bike { get; set; }


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