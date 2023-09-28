using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PWS_3.Models
{
    [XmlRoot("Error")]
    public class ErrorDto
    {
        public int Code { get; set; }

        public Link Link { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public bool LinkSpecified { get; set; } = true;

        public string Message { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public bool MessageSpecified { get; set; } = true;



        public ErrorDto()
        {
            Code = 0;
            Link = null;
        }

        public ErrorDto(int code)
        {
            Code = code;
            Link = new Link("/api/errors/" + code, "GET", "Get");
            Message = null;
            MessageSpecified = false;
        }

        public ErrorDto(int code, string mes)
        {
            Code = code;
            Link = null;
            Message = mes;
            LinkSpecified = false;
        }
    }
}