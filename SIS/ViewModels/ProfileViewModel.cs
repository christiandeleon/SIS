using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS.Models;

namespace SIS.ViewModels
{
    public class ProfileViewModel
    {
        public IEnumerable<Reference> References { get; set; }
        public Personal Personal { get; set; }
    }
}