using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Linq;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public List<Restaurant> restaurents;
        public InMemoryRestaurantData()
        {
            restaurents = new List<Restaurant>()
            {
                new Restaurant{ Id = 1, Name = "Anis's Pizza", Location = "Dhaka", Cuisine = CuisineType.Mexican },
                new Restaurant{ Id = 2, Name = "Jony's Pizza", Location = "Pabna", Cuisine = CuisineType.Italian },
                new Restaurant{ Id = 3, Name = "Joy's Pizza", Location = "Pabna", Cuisine = CuisineType.Indian }
                
            };
        }
        //public IEnumerable<Restaurant> GetAll()
        //{
        //    var query =
        //        from r in restaurents
        //        orderby r.Name
        //        select r;

        //    return query;
        //}

        public IEnumerable<Restaurant> GetRestaurentsByName(string name = null)
        {
            var query =
                from r in restaurents
                where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                orderby r.Name
                select r;

            return query;
        }

        public Restaurant GetById(int id)
        {
            return restaurents.SingleOrDefault(r => r.Id == id);
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurent = restaurents.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if (restaurent != null)
            {
                restaurent.Name = updatedRestaurant.Name;
                restaurent.Location = updatedRestaurant.Location;
                restaurent.Cuisine = updatedRestaurant.Cuisine;
            }
            return restaurent;
        }

        public int Commit()
        {
            return 0;
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            restaurents.Add(newRestaurant);
            newRestaurant.Id = restaurents.Max(r => r.Id) + 1;

            return newRestaurant;
        }
    }
}
