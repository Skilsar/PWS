using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PWS_3.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PWS_3.Controllers
{
    public class StudentsController : ApiController
    {
        DB_Context context = new DB_Context();

        [HttpGet]
        public object Get(HttpRequestMessage request)
        {
            Uri uri = request.RequestUri;
            string format = HttpUtility.ParseQueryString(uri.Query).Get("format");
            try
            {
                int limit, offset, minid, maxid;
                string sort;
                limit = HttpUtility.ParseQueryString(uri.Query).Get("limit") != null ? Int32.Parse(HttpUtility.ParseQueryString(uri.Query).Get("limit")) : 999999;
                sort = HttpUtility.ParseQueryString(uri.Query).Get("sort");
                offset = HttpUtility.ParseQueryString(uri.Query).Get("offset") != null ? Int32.Parse(HttpUtility.ParseQueryString(uri.Query).Get("offset")) : 0;
                minid = HttpUtility.ParseQueryString(uri.Query).Get("minid") != null ? Int32.Parse(HttpUtility.ParseQueryString(uri.Query).Get("minid")) : 0;
                maxid = HttpUtility.ParseQueryString(uri.Query).Get("maxid") != null ? maxid = Int32.Parse(HttpUtility.ParseQueryString(uri.Query).Get("maxid")) : 1000;
                string columns = HttpUtility.ParseQueryString(uri.Query).Get("columns");
                string globallike = HttpUtility.ParseQueryString(uri.Query).Get("globallike");
                string like = HttpUtility.ParseQueryString(uri.Query).Get("like");
                List<Student> students = context.GetList(limit, sort, offset, minid, maxid, like, globallike);

                bool isId = false, isName = false, isNumber = false;
                if (columns != "")
                {
                    if (columns.Contains("id"))
                        isId = true;
                    if (columns.Contains("name"))
                        isName = true;
                    if (columns.Contains("number"))
                        isNumber = true;
                }
                else
                {
                    isId = true;
                    isName = true;
                    isNumber = true;
                }

                List<StudentDto> result = new List<StudentDto>();
                foreach (Student student in students)
                {
                    StudentDto dto = new StudentDto(student);
                    dto.Links = new Link[]
                        {
                            new Link("/api/students/" + student.Id, "GET", "Получить информацию"),
                            new Link("/api/students/" + student.Id, "PUT", "Обновить информацию"),
                            new Link("/api/students/" + student.Id, "DELETE", "Удалить студента")
                        };
                    dto.IdSpecified = isId;
                    dto.NameSpecified = isName;
                    dto.NumberSpecified = isNumber;
                    result.Add(dto);
                }

                if (format == "json")
                {
                    return Json(result);
                }
                else
                {
                    return Content(HttpStatusCode.OK, result, Configuration.Formatters.XmlFormatter);
                }
            }
            catch (Exception e)
            {
                if (format == "json")
                {
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.JsonFormatter);
                }
                else
                {
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.XmlFormatter);
                }
            }
        }

        [HttpGet]
        public object Get(int id, HttpRequestMessage request)
        {
            Uri uri = request.RequestUri;
            string format = HttpUtility.ParseQueryString(uri.Query).Get("format");
            try
            {
                Student student = context.GetOne(id);

                StudentDto dto = new StudentDto(student);
                Link[] links = new Link[]
                {
                    new Link("/api/students/" + id, "PUT", "Update"),
                    new Link("/api/students/" + id, "DELETE", "Delete")
                };
                dto.Links = links;
                if (format == "json")
                {
                    return Json(dto);
                }
                else
                {
                    return Content(HttpStatusCode.OK, dto, Configuration.Formatters.XmlFormatter);
                }
            }
            catch (Exception e)
            {
                if (format == "json")
                {
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.JsonFormatter);
                }
                else
                {
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.XmlFormatter);
                }
            }
        }

        [HttpPost]
        public object Post(HttpRequestMessage request)
        {
            Uri uri = request.RequestUri;
            string format = HttpUtility.ParseQueryString(uri.Query).Get("format");
            var body = request.Content;
            string json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);
            if (data.name == null || data.number == null)
            {
                if (format == "json")
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(400), Configuration.Formatters.JsonFormatter);
                else
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(400), Configuration.Formatters.XmlFormatter);
            }

            try
            {
                string nam = Convert.ToString(data.name);
                string num = Convert.ToString(data.number);
                Student student = context.Post(nam, num);
                StudentDto dto = new StudentDto(student);

                Link[] links = new Link[]
                {
                    new Link("/api/students/" + student.Id, "GET", "Получить студента"),
                };
                dto.Links = links;

                if (format == "json")
                    return Json(dto);
                else
                    return Content(HttpStatusCode.OK, dto, Configuration.Formatters.XmlFormatter);
            }
            catch (Exception e)
            {
                if (format == "json")
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.JsonFormatter);
                else
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.XmlFormatter);
            }
        }

        [HttpPut]
        public object Put(int id, HttpRequestMessage request)
        {
            Uri uri = request.RequestUri;
            string format = HttpUtility.ParseQueryString(uri.Query).Get("format");
            var body = request.Content;
            string json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);
            try
            {
                Student student = context.Put(id, Convert.ToString(data.name), Convert.ToString(data.number));
                StudentDto dto = new StudentDto(student);
                Link[] links = new Link[]
                {
                    new Link("/api/students/" + id, "GET", "Получить студента"),
                    new Link("/api/students/" + id, "DELETE", "Удалить студента")
                };
                dto.Links = links;

                if (format == "json")
                    return Json(dto);
                else
                    return Content(HttpStatusCode.OK, dto, Configuration.Formatters.XmlFormatter);
            }
            catch (Exception e)
            {
                if (format == "json")
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.JsonFormatter);
                else
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.XmlFormatter);
            }

        }

        [HttpDelete]
        public object Delete(int id, HttpRequestMessage request)
        {
            Uri uri = request.RequestUri;
            string format = HttpUtility.ParseQueryString(uri.Query).Get("format");
            var body = request.Content;
            string json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);
            try
            {
                Student student = context.Delete(id);
                StudentDto dto = new StudentDto(student);

                if (format == "json")
                    return Json(dto);
                else
                    return Content(HttpStatusCode.OK, dto, Configuration.Formatters.XmlFormatter);
            }
            catch (Exception e)
            {
                if (format == "json")
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.JsonFormatter);
                else
                    return Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.XmlFormatter);
            }
        }

    }
}
