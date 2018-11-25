using Monstrosity.BLL.Interfaces;
using Monstrosity.BLL.Models;
using Monstrosity.Portal.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Monstrosity.Portal.Controllers
{
    [RoutePrefix("Activity")]
    public class ActivityController : Controller
    {
        private readonly IActivityService _service;

        public ActivityController(IActivityService service)
        {
            _service = service;
        }

        // GET: Activity
        [HttpGet]
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

        [HttpPost]
        public ActionResult Index(ActivityDTO model)
        {
            try
            {
                _service.Create(model);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.ErrorMesage = "Error on creation";
            }
            return View(model);
        }

        [Route("Create")]
        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new ActivityViewModel
            {
                Activity = new ActivityDTO()
            };
            return View(viewModel);
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult Create(ActivityViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.ErrorMessage = "Проверьте поля!";
                return View(viewModel);
            }

            try
            {
                _service.Create(viewModel.Activity);
                viewModel.SuccessMessage = "Запись была создана успешно!";
            }
            catch (Exception ex)
            {
                viewModel.ErrorMessage = "Произошла ошибка при создании записи" + Environment.NewLine + ex.Message;
            }
            return View(viewModel);
        }
    }
}