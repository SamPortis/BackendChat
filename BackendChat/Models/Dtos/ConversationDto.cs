using System.ComponentModel.DataAnnotations;

namespace BackendChat.Api.Models.Dtos
{
    public class ConversationDto
    {
        [Required, MaxLength(255)]
        public required string Name { get; set; }

        [Required]
        public bool ReadRecepit { get; set; }

        [Required]
        public DateTime LastMessageSentTime { get; set; }
    }
}
