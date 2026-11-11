using BackendChat.Api.Models.Dtos;
using BackendChat.Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendChat.Firestore.Repositories
{
    public class MessageRepository : IRepository<Message, MessageDto>
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Message?> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Message>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(MessageDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(int id, MessageDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
