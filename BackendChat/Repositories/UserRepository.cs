using BackendChat.Api.Models.Dtos;
using BackendChat.Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendChat.Firestore.Repositories
{
    public class UserRepository : IRepository<User, UserDto>
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User?> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(UserDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(int id, UserDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
