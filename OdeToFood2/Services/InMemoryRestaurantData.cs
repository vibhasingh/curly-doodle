using OdeToFood2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood2.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Papa Jones" },
                new Restaurant { Id = 2, Name = "Pizza hut" },
                new Restaurant { Id = 3, Name = "Dominos" }
             };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        List<Restaurant> _restaurants;
    }
}
