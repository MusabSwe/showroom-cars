using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ShowRoom.Pages
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public Credential credential { get; set; }


         public string Message { get; set; }

        public void OnGet()
        {
            this.credential = new Credential { UserName = "admin" };
        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();    
            }

            if (credential.UserName == "admin" && credential.Password == "123")
            {
                Message = null;
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, "admin"),
                                                new Claim(ClaimTypes.Email, "admin@mywebsite.com")
                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Admin/dashboard");
            }
            Message = "Invalid Input";
            return Page();
        }

        public class Credential
        {
            
            [Required]
            [Display(Name = "User Name")]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
        
    }
}
