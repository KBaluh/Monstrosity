using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monstrosity.DAL.Entities
{
    [Table("Contact")]
    public class Contact
    {
        public int ContactId { get; set; }

        [Required]
        public string Name { get; set; }

        public string LastName { get; set; }

        public string FatherName { get; set; }

        public DateTime? DoB { get; set; }

        [Required]
        public int ContactTypeId { get; set; }

        [ForeignKey(nameof(ContactTypeId))]
        public ContactType ContactType { get; set; }
    }
}
