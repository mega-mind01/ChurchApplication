using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.DataService.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> FindById(string Id);
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(string Id);

    }
}
