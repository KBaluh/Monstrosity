using Monstrosity.BLL.Interfaces;
using Monstrosity.BLL.Models;
using Monstrosity.Portal.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Monstrosity.Portal.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityService _service;

        public ActivityController(IActivityService service)
        {
            _service = service;
        }

        // GET: Activity
        public ActionResult Index()
        {
            IEnumerable<ActivityDTO> activities = null;
            string errorMessage = string.Empty;

            try
            {
                activities = _service.GetAll();
            }
            catch (Exception ex)
            {
                activities = new List<ActivityDTO>();
                errorMessage = $"Не удалось загрузить активности.\n`{ex.ToString()}`";
            }

            var viewModel = new ActivityListViewModel
            {
                Activities = activities,
                ErrorMessage = errorMessage
            };
            return View(viewModel);
        }
    }
}