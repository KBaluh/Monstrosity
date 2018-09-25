using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monstrosity.DAL.Entities
{
    [Table("ContactType")]
    public class ContactType
    {
        public int ContactTypeId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
