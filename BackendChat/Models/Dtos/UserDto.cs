using System.ComponentModel.DataAnnotations;

namespace BackendChat.Api.Models.Dtos
{
    public class UserDto
    {
        [Required, MaxLength(255)]
        public required string Name { get; set; }
    }
}
