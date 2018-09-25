using Monstrosity.BLL.Interfaces;
using Monstrosity.BLL.Models;
using Monstrosity.Portal.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Monstrosity.Portal.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _service;

        public ContactController(IContactService service)
        {
            _service = service;
        }

        // GET: Contact
        public ActionResult Index()
        {
            var viewModel = new ContactListViewModel();
            IEnumerable<ContactDTO> contacts = new List<ContactDTO>();
            try
            {
                viewModel.Contacts = _service.GetAll();
            }
            catch (Exception ex)
            {
                viewModel.ErrorMessage = $"Can't load contact list. {ex.Message}";
            }
            return View(viewModel);
        }
    }
}