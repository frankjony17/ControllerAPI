using ControllerAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerAPI.Repositories
{
    public class EFCoreRepository : IEFCoreRepository
    {
        private readonly ResponseContext _context;

        public EFCoreRepository(ResponseContext context)
        {
            _context = context;
        }

        public async Task<ResponseService[]> GetAllResponseService()
        {
            IQueryable<ResponseService> query = _context.ResponseServices;
            return await query.ToArrayAsync();
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangeAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
