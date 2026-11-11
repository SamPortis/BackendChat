using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendChat.Api.Repositories
{
    public interface IRepository<TEntity, TDto>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> FindByIdAsync(string id);
        Task<int> InsertAsync(TDto dto);
        Task<int> UpdateAsync(string id, TDto dto);
        Task<int> DeleteAsync(string id);
    }
}
