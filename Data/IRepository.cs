using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportAPI.Data
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }

    public interface IARepository<TA> where TA : class, IAuthEntity
    {
        Task<List<TA>> GetAll();
        Task<TA> Get(int id);
        Task<TA> Add(TA entity);
        Task<TA> Update(TA entity);
        Task<TA> Delete(int id);
        Task<TA> Auth(string id);
    }

    public interface IAHRepository<TH> where TH : class, IHAuthEntity
    {
        Task<List<TH>> GetAll();
        Task<TH> Get(int id);
        Task<TH> Add(TH entity);
        Task<TH> Update(TH entity);
        Task<TH> Delete(int id);
        Task<TH> Auth(string id);
    }
}
