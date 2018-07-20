using OdeToFood2.Models;
using System.Collections.Generic;

namespace OdeToFood2.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
