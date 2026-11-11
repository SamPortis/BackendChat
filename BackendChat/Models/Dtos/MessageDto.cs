using System.ComponentModel.DataAnnotations;

namespace BackendChat.Api.Models.Dtos
{
    public class MessageDto
    {
        [Required]
        public string? SenderId { get; set; }

        [Required]
        public required string Content { get; set; }
    }
}
