using OdeToFood.Core;
using System;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurent> restaurents;
        public InMemoryRestaurantData()
        {
            restaurents = new List<Restaurent>()
            {
                new Restaurent{ Id = 1, Name = "Anis's Pizza", Location = "Dhaka", Cuisine = CuisineType.Mexican },
                new Restaurent{ Id = 2, Name = "Jony's Pizza", Location = "Pabna", Cuisine = CuisineType.Italian },
                new Restaurent{ Id = 3, Name = "Joy's Pizza", Location = "Pabna", Cuisine = CuisineType.Indian }
                
            };
        }
        public IEnumerable<Restaurent> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
