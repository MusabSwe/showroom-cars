using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShowRoom.Core;
using ShowRoom.Data;

namespace ShowRoom.Pages.Admin
{
    [Authorize(Policy = "AdminOnly")]
    public class BikedataModel : PageModel
    {
        private readonly IShowRoomData showRoomData;
        private readonly ShowRoomContext showRoomContext;

        [BindProperty]
        public Bike bike { get; set; }
        public SelectList Engines { get; set; }
        public SelectList Wheels { get; set; }
        public SelectList Fuel { get; set; }
        public BikedataModel(IShowRoomData showRoomData, ShowRoomContext showRoomContext)
        {
            this.showRoomData = showRoomData;
            this.showRoomContext = showRoomContext;
        }
        public void OnGet()
        {
            var options1 = showRoomContext.Wheel.Select(w => new
            {
                Id = w.Id,
                optionValue = $"Tire: {w.TireName} - Type: {w.TireType} - Size: {w.TireSize}"
            }).ToList();

            var option2 = showRoomContext.FuelEconomy.Select(f => new
            {
                Id = f.Id,
                optionValue = $"{f.VehicleName} - Economy Level: {f.EconomyLevel} - Fuel type: {f.FuelType}"
            }).ToList();

            Wheels = new SelectList(options1, "Id", "optionValue");
            Engines = new SelectList(showRoomData.GetEngines().ToList(), "Id", "EngineName");
            Fuel = new SelectList(option2, "Id", "optionValue");

        }

        public IActionResult OnPost()
        {
            var options1 = showRoomContext.Wheel.Select(w => new
            {
                Id = w.Id,
                optionValue = $"Tire: {w.TireName} - Type: {w.TireType} - Size: {w.TireSize}"
            }).ToList();

            var option2 = showRoomContext.FuelEconomy.Select(f => new
            {
                Id = f.Id,
                optionValue = $"{f.VehicleName} - Economy Level: {f.EconomyLevel} - Fuel type: {f.FuelType}"
            }).ToList();

            Wheels = new SelectList(options1, "Id", "optionValue");
            Engines = new SelectList(showRoomData.GetEngines().ToList(), "Id", "EngineName");
            Fuel = new SelectList(option2, "Id", "optionValue");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            int? max = showRoomContext.Car.Max(u => (int?)u.VehicleId);
            int i;
            if (max == null)
            {
                i = 1;
            }
            else
            {
                i = max.Value + 1;
            }

            TempData["Message"] = $"{bike.Display(i)} is added to the database";
            showRoomData.addBike(bike);
            showRoomData.commit();
            return RedirectToPage("/Admin/dashboard");
        }
    }
}
