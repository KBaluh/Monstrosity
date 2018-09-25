using System;
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

        public DateTime DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public int ActivityStateId { get; set; }

        [ForeignKey(nameof(ActivityStateId))]
        public ActivityState ActivityState { get; set; }
    }
}
