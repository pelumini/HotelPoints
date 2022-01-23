using Microsoft.AspNetCore.Identity;

namespace HotelPoints.API.Entities
{
    public class Account : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
