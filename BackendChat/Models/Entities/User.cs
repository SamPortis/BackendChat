using Google.Cloud.Firestore;

namespace BackendChat.Api.Models.Entities
{
    [FirestoreData]
    public class User
    {
        [FirestoreDocumentId]
        public int? UserId { get; set; }

        [FirestoreProperty]
        public required string Name { get; set; }

        [FirestoreProperty]
        public List<Conversation> Conversations { get; set; } = new List<Conversation>();

        [FirestoreProperty]
        public List<User> Contacts { get; set; } = new List<User>();
    }
}
