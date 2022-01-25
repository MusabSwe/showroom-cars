using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShowRoom.Core;

namespace ShowRoom.Pages.Admin
{
    [Authorize(Policy = "AdminOnly")]
    public class FuelDataModel : PageModel
    {
        private readonly IShowRoomData showRoomData;

        [BindProperty]
        public FuelEconomy fuel { get; set; }

        public FuelDataModel(IShowRoomData showRoomData)
        {
            this.showRoomData = showRoomData;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            else { 
                TempData["Message"] = $"{fuel.toString()} is added to the database";
                showRoomData.AddFuelCard(fuel);
                showRoomData.commit();
                return RedirectToPage("/Admin/dashboard");
            }

            
       
        }
    }
}
