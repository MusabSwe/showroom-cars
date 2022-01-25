using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShowRoom.Core;

namespace ShowRoom.Pages
{
    public class CarsModel : PageModel
    {
        private readonly IShowRoomData showRoomData;

        public IEnumerable<Car> Cars { get; set; }
        [BindProperty(SupportsGet = true)]
        public string searchTerm { get; set; }

        public string [] type { get; set; }
        public string[] image { get; set; }

        public CarsModel(IShowRoomData showRoomData)
        {
            this.showRoomData = showRoomData;
        }
        public void OnGet()
        {
            string[] types = { "Sedan","Sedan", "Van", "SUV", "Sedan", "SUV" };
            string[] images = {"~/assets/img/CAMRY.png", "~/assets/img/CAMRY.png", "~/assets/img/GMC-Safari.jpg",
                                "~/assets/img/HYUNDAI-CRETA.png","~/assets/img/SONATA.jpg","~/assets/img/TOYOTA-FORTUNER.jpg"};
            type = types;
            image = images;
            Cars = showRoomData.GetCarByName(searchTerm);
        }
    }
}
