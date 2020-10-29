using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood2.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurantData restaurantData;

        public DetailModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public Restaurent Restaurent { get; set; }
        public IActionResult OnGet(int restaurantId)
        {
            Restaurent = restaurantData.GetById(restaurantId);
            if (Restaurent == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
