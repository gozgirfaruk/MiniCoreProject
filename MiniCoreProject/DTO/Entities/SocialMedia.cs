using System.ComponentModel.DataAnnotations;

namespace MiniCoreProject.DTO.Entities
{
    public class SocialMedia
    {
        [Key]
        public int SocialMeadiID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
