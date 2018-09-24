using Monstrosity.BLL.Models;
using System.Collections.Generic;

namespace Monstrosity.Portal.Models
{
    public class ActivityListViewModel
    {
        public string ErrorMessage { get; set; }

        public IEnumerable<ActivityDTO> Activities { get; set; }
    }
}