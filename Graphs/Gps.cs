using System.Collections.Generic;
using System.Linq;

namespace Graphs
{
    /// <summary>
    /// Simple GPS algorithm exercise 
    /// </summary>
    public class Gps
    {
        public HashSet<int> Cities { get; set; }
        public HashSet<Route> Distances { get; set; }

        public Gps()
        {
            Cities = new HashSet<int>();
            Distances = new HashSet<Route>();
        }

        /// <summary>
        /// Adds new city with new distance or updates existing city with shorter distance.
        /// </summary>
        /// <param name="cityId">City identifier.</param>
        /// <param name="distance">Distance.</param>
        public void AddOrUpdate(int cityId, int distance)
        {
            if (Cities.Contains(cityId))
            {
                Distances.FirstOrDefault(s => s.City == cityId).Distance = distance;
            }
            else
            {
                Cities.Add(cityId);
                Distances.Add(new Route { City = cityId, Distance = distance });
            }
        }

        /// <summary>
        /// Retrieves and removes city with smallest distance and returns it's id.
        /// </summary>
        /// <returns>The closest city identifier.</returns>
        public int PollClosestCity()
        {
            Route closest = null;
            int distance = int.MaxValue;
            int cityId = 0;

            for (int i = 0; i < Distances.Count; i++)
            {
                Route route = Distances.ElementAt(i);
                if (route.Distance >= distance) continue;
                distance = route.Distance;
                closest = route;
            }
            if (closest == null) return cityId;
            cityId = closest.City;
            Cities.RemoveWhere(x => x == cityId);
            Distances.RemoveWhere(y => y.City == cityId);
            return cityId;

        }
    }

    public class Route
    {
        public int City { get; set; }
        public int Distance { get; set; }
    }
}
