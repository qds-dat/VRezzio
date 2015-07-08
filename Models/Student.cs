using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VRezzio.Models
{
    public class Student
    {
        public int ID { get; set; }

        [ForeignKey("Account")]
        public int UserId { get; set; }
        public virtual Account Account { get; set; }

        public string FullName { get; set; }

        [ForeignKey("University")]
        public int UniversityId { get; set; }

        public virtual University University {get;set;}

        public string HighSchool { get; set; }
        public string PhoneNunber { get; set; }
        public float SATScore { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Introduction { get; set; }
        public string Activity1 { get; set; }
        public string ActivityPhoto1 { get; set; }
        public string Activity2 { get; set; }
        public string ActivityPhoto2 { get; set; }
        public string Activity3 { get; set; }
        public string ActivityPhoto3 { get; set; }
        public string Conclusion { get; set; }
        public string Video { get; set; }

        public int Rate { get; set; }
        public eStudentStatus Status { get; set; }
        public ICollection<PhotoVideo> PhotoVideos { get; set; }
    }
}