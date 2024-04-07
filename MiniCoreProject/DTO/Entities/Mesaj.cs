using System.ComponentModel.DataAnnotations;

namespace MiniCoreProject.DTO.Entities
{
    public class Mesaj
    {
        [Key]
        public int MessageID { get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
