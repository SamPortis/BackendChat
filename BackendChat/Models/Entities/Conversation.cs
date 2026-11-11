using Google.Cloud.Firestore;

namespace BackendChat.Api.Models.Entities
{
    [FirestoreData]
    public class Conversation
    {
        [FirestoreDocumentId]
        public string? ConversationId { get; set; }

        [FirestoreProperty]
        public required string Name { get; set; }

        [FirestoreProperty]
        public List<Message> Messages { get; set; } = new List<Message>();


        [FirestoreProperty]
        public List<User> People { get; set; } = new List<User>();

        [FirestoreProperty]
        public bool ReadReceipt { get; set; }

        [FirestoreProperty]
        public DateTime LastMessageSentTime { get; set; }
    }
}
