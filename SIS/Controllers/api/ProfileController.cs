using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SIS.Models;

namespace SIS.Controllers.api
{
    public class ProfileController : ApiController
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

        //public IEnumerable<Personal> getJobList()
        //{
        //    return _context.JobPost.ToList();
        //}

    }
}
