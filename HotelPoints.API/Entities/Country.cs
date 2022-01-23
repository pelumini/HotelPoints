using System.Collections.Generic;

namespace HotelPoints.API.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        //Relationship - One to Many
        public virtual IList<Hotel> Hotels { get; set; }
    }
}
