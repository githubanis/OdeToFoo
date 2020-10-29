using OdeToFood.Core;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        //IEnumerable<Restaurent> GetAll();
        IEnumerable<Restaurent> GetRestaurentsByName(string name);
        Restaurent GetById(int id);

    }
}
