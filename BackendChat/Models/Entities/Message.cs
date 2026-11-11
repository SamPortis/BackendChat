using Google.Cloud.Firestore;

namespace BackendChat.Api.Models.Entities
{
    [FirestoreData]
    public class Message
    {
        [FirestoreDocumentId]
        public string? MessageId { get; set; }

        [FirestoreProperty]
        public string SenderId { get; set; } = string.Empty;

        [FirestoreProperty]
        Timestamp TimeStamp { get; set; }

        [FirestoreProperty]
        public string Content { get; set; } = string.Empty;

    }
}
