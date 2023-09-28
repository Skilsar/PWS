using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PWS_3.Models
{
    [XmlRoot("Student")]
    public class StudentDto
    {

        public int Id { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public bool IdSpecified { get; set; } = true;

        public string Name { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public bool NameSpecified { get; set; } = true;

        public string Number { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public bool NumberSpecified { get; set; } = true;

        [XmlArrayItem("Link")]
        public Link[] Links { get; set; }

        public StudentDto(Student student)
        {
            this.Id = student.Id;
            this.Number = student.Phone;
            this.Name = student.Name;
        }

        public StudentDto()
        {
            this.Id = 0;
            this.Number = null;
            this.Name = null;
        }

    }
}