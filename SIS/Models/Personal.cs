using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI.WebControls;

namespace SIS.Models
{
    public class Personal
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]

        public int empId { get; set; }

        [Required]
        public int appId { get; set; }

        [StringLength(4)]
        [Display(Name = "Title")]
        public string title { get; set; }

        [Display(Name = "First Name")]
        [StringLength(30)]
        [Required]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(30)]
        [Required]
        public string lastName { get; set; }

        [Display(Name = "Gender")]
        [StringLength(3)]
        public string gender { get; set; }

        [Display(Name = "Birth Date")]
        public System.DateTime? birthDate { get; set; }

        [Display(Name = "Contact No")]
        [StringLength(12)]
        public string contactNo { get; set; }

        [Display(Name = "E-mail")]
        [StringLength(40)]
        public string email { get; set; }

        [Display(Name = "Street")]
        [StringLength(30)]
        public string street { get; set; }

        [Display(Name = "Suburb")]
        [StringLength(30)]
        public string suburb { get; set; }

        [Display(Name = "State")]
        [StringLength(30)]
        public string state { get; set; }


        [Display(Name = "Post Code")]
        [StringLength(4)]
        public string postCode { get; set; }

        [Display(Name = "Name")]
        [StringLength(50)]
        public string kinName { get; set; }

        [Display(Name = "Relationship")]
        [StringLength(30)]
        public string kinRelationship { get; set; }

        [Display(Name = "Contact No")]
        [StringLength(12)]
        public string kinContactNo { get; set; }

        [Required]
        public int userId { get; set; }

        [Required]
        public DateTime dateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime dateUpdated { get; set; } = DateTime.Now;


    }
}