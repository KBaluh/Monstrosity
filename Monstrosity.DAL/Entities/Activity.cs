using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monstrosity.DAL.Entities
{
    [Table("Activity")]
    public class Activity
    {
        public int ActivityId { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
