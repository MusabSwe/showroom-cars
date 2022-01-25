using System.ComponentModel.DataAnnotations;

namespace ShowRoom.Core
{
    public class Engine
    {
        //columns
        public int Id { get; set; }
        [Required]
        [Display(Name = "Engine Name")]
        public string EngineName { get; set; }
        //FK1&2
        public Car Car { get; set; }
        public Bike Bike { get; set; }

        public Engine(int id, string EngineName)
        {
            this.Id = id;
            this.EngineName = EngineName;
        }

        public Engine()
        {
            
        }
    }
}