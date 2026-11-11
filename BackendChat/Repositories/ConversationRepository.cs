using BackendChat.Api.Models.Dtos;
using BackendChat.Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendChat.Firestore.Repositories
{
    public class ConversationRepository : IRepository<Conversation, ConversationDto>
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Conversation?> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Conversation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(ConversationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(int id, ConversationDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
