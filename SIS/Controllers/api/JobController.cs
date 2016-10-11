using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SIS.Models;
using Newtonsoft.Json;

namespace SIS.Controllers.api
{
    public class JobController : ApiController
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

        public IEnumerable<JobPost> getJobList()
        {
            return _context.JobPost.ToList();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var job = _context.JobPost.SingleOrDefault(j => j.id == id);
            if (job == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.JobPost.Remove(job);
            _context.SaveChanges();

        }
    }
}
