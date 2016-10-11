using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using SIS.Models;
using SIS.ViewModels;

namespace SIS.Controllers
{
    public class JobController : Controller
    {
        private ApplicationDbContext _context;

        public JobController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: JobPost
        public ViewResult Index()
        {
            var job = _context.JobPost.ToList();
            return View(job);
        }
   
        [System.Web.Mvc.HttpPost]
        public ActionResult SaveJob(JobPost jobPost)
        {

            if (jobPost.id == 0)
            {
                _context.JobPost.Add(jobPost);
            }
            else {
                var jobPostInDB = _context.JobPost.Single(j => j.id == jobPost.id);
                jobPostInDB.JobName = jobPost.JobName;
                jobPostInDB.JobCode = jobPost.JobCode;
            }

            _context.SaveChanges();

            var viewModel = new JobViewModel()
            {
                JobPost = jobPost
            };

            return RedirectToAction("Index");
        }

        public ActionResult New()
        {
            return PartialView("JobForm");
        }

        public ActionResult Edit(int id)
        {
            var jobPost = _context.JobPost.SingleOrDefault(j => j.id == id);

            if (jobPost == null)
                return HttpNotFound();

            var viewModel = new JobViewModel()
            {
                JobPost = jobPost
            };

            return PartialView("JobForm", viewModel);
        }


    }
}