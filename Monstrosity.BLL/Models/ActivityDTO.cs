using System.ComponentModel.DataAnnotations;

namespace Monstrosity.BLL.Models
{
    public class ActivityDTO
    {
        public int ActivityId { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
