using Monstrosity.BLL.Models;
using System.Collections.Generic;

namespace Monstrosity.Portal.Models
{
    public class ContactListViewModel
    {
        public string ErrorMessage { get; set; }

        public IEnumerable<ContactDTO> Contacts { get; set; }
    }
}