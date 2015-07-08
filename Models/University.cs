using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Web;
namespace VRezzio.Models
{
    [Table("University")]
    public class University
    {
        public University()
        {
            ActiveStatus = eSchoolStatus.Peding;
            CreateDate = DateTime.Now;
        }

        [Key]
        public int ID { get; set; }

        [ForeignKey("Account")]
        public int UserId { get; set; }
        public virtual Account Account { get; set; }

        [Required]
        [MaxLength(20)]
        public string OfficePhone { get; set; }

        [Required]
        [MaxLength(20)]
        public string MobilePhone { get; set; }

        [Required]
        [MaxLength(100)]
        public string UniversityName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        public eTitle PrincipalTitle { get; set; }

        [Required]
        public string PrincipalFirstName { get; set; }

        [Required]
        public string PrincipalLastName { get; set; }

        public DateTime CreateDate { get; set; }

        public eSchoolStatus ActiveStatus { get; set; }

        public ICollection<Student> Students { get; set; }
       

    }
}