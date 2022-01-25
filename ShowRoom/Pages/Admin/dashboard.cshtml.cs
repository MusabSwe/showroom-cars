using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ShowRoom.Core;

namespace ShowRoom.Pages.Admin
{
    [Authorize(Policy = "AdminOnly")]
    public class dashboardModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        private readonly IShowRoomData showRoomData;

        public dashboardModel(IShowRoomData showRoomData)
        {
            this.showRoomData = showRoomData;
        }

        public void OnGet()
        {
    
        }
    }
}
