using System.ComponentModel.DataAnnotations;

namespace Monstrosity.BLL.Models
{
    public class ActivityStateDTO
    {
        public int ActivityStateId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
