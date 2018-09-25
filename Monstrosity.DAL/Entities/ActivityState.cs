using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monstrosity.DAL.Entities
{
    [Table("ActivityState")]
    public class ActivityState
    {
        public int ActivityStateId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
