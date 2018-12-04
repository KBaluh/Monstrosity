using Monstrosity.BLL.Models;

namespace Monstrosity.Portal.Models
{
    public class ActivityViewModel
    {
        public string ErrorMessage { get; set; }

        public string SuccessMessage { get; set; }

        public ActivityDTO Activity { get; set; }
    }
}