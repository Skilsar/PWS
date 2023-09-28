using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using PWS_3.Models;

namespace PWS_3.Controllers
{
    public class ErrorsController : ApiController
    {
        [HttpGet]
        public object GetErrors(int code, HttpRequestMessage request)
        {
            Uri uri = request.RequestUri;
            string format = HttpUtility.ParseQueryString(uri.Query).Get("format");
            var result = new ErrorDto(code, GetErrorMessage(code));
            if (format == "json")
            {
                return Json(result);
            }
            else
            {
                return Content(HttpStatusCode.OK, result, Configuration.Formatters.XmlFormatter);
            }
        }


        public static string GetErrorMessage(int code)
        {
            switch (code)
            {
                case 500:
                    return "Server Error";
                case 400:
                    return "Invalid parameters";
                default:
                    return "invalid error code";
            }
        }
    }
}