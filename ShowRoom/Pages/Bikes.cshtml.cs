using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShowRoom.Core;

namespace ShowRoom.Pages
{
    public class BikesModel : PageModel
    {
        private readonly IShowRoomData showRoomData;

        public IEnumerable<Bike> bikes { get; set; }
        [BindProperty(SupportsGet = true)]
        public string searchTerm { get; set; }

        public string[] type { get; set; }
        public string[] image { get; set; }

        public BikesModel(IShowRoomData showRoomData)
        {
            this.showRoomData = showRoomData;
        }
        public void OnGet()
        {
            bikes = showRoomData.GetBikeByName(searchTerm);
            string[] imgs = {"~/assets/img/Venom.jpg", "~/assets/img/Cobra.jpg" };
            image = imgs;
        }
    }
}
