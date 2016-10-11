using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SIS.Models
{
    public class Reference
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte id { get; set; }

        [StringLength(10)]
        public string type { get; set; }

        [StringLength(4)]
        public string code { get; set; }

        [StringLength(20)]
        public string name { get; set; }
    }
}