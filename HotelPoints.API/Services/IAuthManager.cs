using HotelPoints.API.DTOs;
using System.Threading.Tasks;

namespace HotelPoints.API.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO userDTO);
        Task<string> CreateToken();
    }
}
