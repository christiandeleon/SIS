using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SIS.Models;
using SIS.ViewModels;

namespace SIS.Controllers
{
    public class ProfileController : Controller
    {
        private ApplicationDbContext _context;

        public ProfileController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Profile
        [HttpGet]
        public ActionResult ProfileForm()
        {

            return View();
        }
    
        public ActionResult _PersonalForm()
        {
            var reference = _context.Reference;
            var model = new ProfileViewModel()
            {
                References = reference
            };
            return View();
        }

        public List<SelectListItem> getReference()
        {
           
            List<SelectListItem> ls = new List<SelectListItem>();
            var reference = _context.Reference;
            foreach (var temp in reference)
            {
                ls.Add(new SelectListItem() {Text = temp.name, Value = temp.code});
            }

            return ls;
        }

        public ActionResult Create()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult SavePersonal(Personal personal)
        {
           
            if (personal.id == 0)
            {
                _context.Personal.Add(personal);
            }
            else
            {
                var personalInDb = _context.Personal.Single(p => p.id == personal.id);
                personalInDb.firstName = personal.firstName;
                personalInDb.lastName = personal.lastName;
            }

            _context.SaveChanges();

            //var reference = _context.Reference.ToList();
            //var viewModel = new ProfileViewModel
            //{
            //    References = reference
            //};

            return View("ProfileForm");
        }

        public ActionResult NewPersonal()
        {
            return PartialView("_PersonalForm");
        }
    }
}