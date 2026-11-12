using BackendChat.Api.Models.Dtos;
using BackendChat.Api.Models.Entities;
using BackendChat.Api.Repositories;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendChat.Firestore.Repositories
{
    public class ConversationRepository(FirestoreDb db) : RepositoryBase<Conversation, ConversationDto>(db, "conversations")
    {
       
    }
}
