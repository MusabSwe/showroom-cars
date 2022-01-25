using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShowRoom.Core;
using ShowRoom.Data;

namespace ShowRoom.Pages.Admin
{
    [Authorize(Policy = "AdminOnly")]
    public class CarDataModel : PageModel
    {
        private readonly IShowRoomData showRoomData;
        private readonly ShowRoomContext showRoomContext;

        [BindProperty]
        public Car car { get; set; }
        public SelectList Engines { get; set; }
        public SelectList Wheels { get; set; }
        public SelectList Fuel { get; set; }
        public CarDataModel(IShowRoomData showRoomData,ShowRoomContext showRoomContext)
        {
            this.showRoomData = showRoomData;
            this.showRoomContext = showRoomContext;
        }
        public void OnGet()
        {
          
            var options2 = showRoomContext.Wheel.Select(w => new
            {
                Id = w.Id,
                optionValue = $"Tire: {w.TireName} - Type: {w.TireType} - Size: {w.TireSize}"
            }).ToList();

            var option4 = showRoomContext.FuelEconomy.Where(f => f.VehicleName != "Venom").Select(f => new
            {
                Id = f.Id,
                optionValue = $"Car: {f.VehicleName} - Economy Level: {f.EconomyLevel} - Fuel type: {f.FuelType}"
            }).ToList();

            Wheels = new SelectList(options2, "Id", "optionValue");
            Engines = new SelectList(showRoomData.GetEngines().ToList(), "Id", "EngineName");
            Fuel = new SelectList(option4, "Id", "optionValue");

        }

        public IActionResult OnPost()
        {
            //var errors = ModelState.Values.SelectMany(v => v.Errors
            var options2 = showRoomContext.Wheel.Select(w => new
            {
                Id = w.Id,
                optionValue = $"Tire: {w.TireName} - Type: {w.TireType} - Size: {w.TireSize}"
            }).ToList();

            var option4 = showRoomContext.FuelEconomy.Select(f => new
            {
                Id = f.Id,
                optionValue = $"Car: {f.VehicleName} - Economy Level: {f.EconomyLevel} - Fuel type: {f.FuelType}"
            }).ToList();

            Wheels = new SelectList(options2, "Id", "optionValue");
            Engines = new SelectList(showRoomData.GetEngines().ToList(), "Id", "EngineName");
            Fuel = new SelectList(option4, "Id", "optionValue");

            if (!ModelState.IsValid)
            {
                return Page();
            }
              
              int? max = showRoomContext.Car.Max(u =>(int?) u.VehicleId);
              int i;
              if(max == null)
              {
                  i = 1;
              }
              else
              {
                  i = max.Value + 1;
              }
              
            TempData["Message"] = $"{car.Display(i)} is added to the database";
            showRoomData.AddCar(car);
            showRoomData.commit();
            return RedirectToPage("/Admin/dashboard");
        }
    }
}
