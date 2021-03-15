using ControllerAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerAPI.Repositories
{
    public interface IEFCoreRepository
    {
        Task<ResponseService[]> GetAllResponseService(); 
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangeAsync();
    }
}
