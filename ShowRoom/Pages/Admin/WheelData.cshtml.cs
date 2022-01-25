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
    public class WheelDataModel : PageModel
    {
        private readonly IShowRoomData showRoomData;

        [BindProperty]
        public Wheel wheel { get; set; }
        public WheelDataModel(IShowRoomData showRoomData)
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
        
            TempData["Message"] = $"{wheel.toString()}  are added to the database";
            showRoomData.AddWheel(wheel);
            showRoomData.commit();
            return RedirectToPage("/Admin/dashboard");
        }

    }
}
