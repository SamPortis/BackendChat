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
    public class MessageRepository(FirestoreDb db) : RepositoryBase<Message, MessageDto>(db, "messages")
    {
    }
}
