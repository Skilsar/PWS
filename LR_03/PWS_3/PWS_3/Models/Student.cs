using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PWS_3.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[StringLength(100, ErrorMessage = "max name length is 100 characters")]
        public string Name { get; set; }
        //[StringLength(20, ErrorMessage = "max name length is 20 characters")]
        public string Phone { get; set; }

    }
}