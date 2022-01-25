using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using ShowRoom.Core;
using System.Linq;

namespace ShowRoom.Pages.Admin
{

    [Authorize(Policy = "AdminOnly")]
    public class EnginedataModel : PageModel
    {
        private readonly IShowRoomData showRoomData;

        [BindProperty]
        public Engine Engine { get; set; }

        public EnginedataModel(IShowRoomData showRoomData)
        {
            this.showRoomData = showRoomData;
        }
       
                public void OnGet()
                {

                }
        
        public IActionResult OnPost()
        {
           // var errors = ModelState.Values.SelectMany(v => v.Errors);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            TempData["Message"] = $"{Engine.EngineName} engine is added to the database";
               showRoomData.AddEngine(Engine);
               showRoomData.commit();
            return RedirectToPage("/Admin/dashboard");

        }

    }
}

