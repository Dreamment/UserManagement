using System.ComponentModel.DataAnnotations;

namespace Entities.Messages
{
    public class SendMailMessage
    {

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}
