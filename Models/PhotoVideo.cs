using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VRezzio.Models
{
    public class PhotoVideo
    {
        public int ID { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int Second { get; set; }
        public int PhotoUrl { get; set; }

    }
}