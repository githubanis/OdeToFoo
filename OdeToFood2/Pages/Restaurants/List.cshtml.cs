using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood2.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration configuration;
        private readonly IRestaurantData restaurantData;

        public ListModel(IConfiguration configuration, IRestaurantData restaurantData)
        {
            this.configuration = configuration;
            this.restaurantData = restaurantData;
        }
        public string Message { get; set; }

        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public IEnumerable<Restaurent> Restaurents { get; set; }

        public void OnGet()
        {
            Message = configuration["Message"];
            Restaurents = restaurantData.GetRestaurentsByName(SearchTerm);
        }
    }
}
