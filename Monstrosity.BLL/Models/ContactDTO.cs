using System;

namespace Monstrosity.BLL.Models
{
    public class ContactDTO
    {
        public int ContactId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string FatherName { get; set; }

        public DateTime DoB { get; set; }

        public int ContactTypeId { get; set; }
    }
}
