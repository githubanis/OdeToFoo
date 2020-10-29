using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Linq;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public List<Restaurent> restaurents;
        public InMemoryRestaurantData()
        {
            restaurents = new List<Restaurent>()
            {
                new Restaurent{ Id = 1, Name = "Anis's Pizza", Location = "Dhaka", Cuisine = CuisineType.Mexican },
                new Restaurent{ Id = 2, Name = "Jony's Pizza", Location = "Pabna", Cuisine = CuisineType.Italian },
                new Restaurent{ Id = 3, Name = "Joy's Pizza", Location = "Pabna", Cuisine = CuisineType.Indian }
                
            };
        }
        //public IEnumerable<Restaurent> GetAll()
        //{
        //    var query =
        //        from r in restaurents
        //        orderby r.Name
        //        select r;

        //    return query;
        //}

        public IEnumerable<Restaurent> GetRestaurentsByName(string name = null)
        {
            var query =
                from r in restaurents
                where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                orderby r.Name
                select r;

            return query;
        }

        public Restaurent GetById(int id)
        {
            return restaurents.SingleOrDefault(r => r.Id == id);
        }
    }
}
