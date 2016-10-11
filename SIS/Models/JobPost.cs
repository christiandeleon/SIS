using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SIS.Models
{
    public class JobPost
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(5)]
        [Display(Name = "Job Code")]
        public string JobCode { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Job Name")]
        public string JobName { get; set; }

        [StringLength(4)]
        public string Status { get; set; }

        [Required]
        public int UserId { get; set; }
        
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }
}