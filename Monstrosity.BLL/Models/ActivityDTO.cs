using System;
using System.ComponentModel.DataAnnotations;

namespace Monstrosity.BLL.Models
{
    public class ActivityDTO
    {
        public int ActivityId { get; set; }

        [Required]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Display(Name = "Дата с")]
        public DateTime DateFrom { get; set; }

        [Display(Name = "Дата по")]
        public DateTime? DateTo { get; set; }

        [Display(Name = "Состояние")]
        public int ActivityStateId { get; set; }

        [Display(Name = "Контакт")]
        public int? ContactId { get; set; }
    }
}
