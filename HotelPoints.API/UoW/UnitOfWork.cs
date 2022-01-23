using HotelPoints.API.Data;
using HotelPoints.API.Entities;
using HotelPoints.API.Repositories;
using System;
using System.Threading.Tasks;

namespace HotelPoints.API.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private IGenericRepository<Country> _countries;

        private IGenericRepository<Hotel> _hotels;


        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_context);

        public IGenericRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
