using HotelPoints.API.Entities;
using HotelPoints.API.Repositories;
using System;
using System.Threading.Tasks;

namespace HotelPoints.API.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();
    }
}
