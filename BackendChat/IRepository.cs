using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendChat.Firestore.Repositories
{
    public interface IRepository<TEntity, TDto>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> FindByIdAsync(int id);
        Task<int> InsertAsync(TDto dto);
        Task<int> UpdateAsync(int id, TDto dto);
        Task<int> DeleteAsync(int id);
    }
}
