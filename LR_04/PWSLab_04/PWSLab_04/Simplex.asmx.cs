using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using PWSLab_04.Models;

namespace PWSLab_04
{
    /// <summary>
    /// Сводное описание для Simplex
    /// </summary>
    [WebService(Namespace = "http://vrl/", Description = "Simple web service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [ScriptService]
    public class Simplex : System.Web.Services.WebService
    {
        [WebMethod(MessageName = "add", Description = "Sum of two integer numbers")]
        public int Add(int x, int y)
        {
            Stream str = this.Context.Request.InputStream;
            str.Position = 0;
            StreamReader sr = new StreamReader(this.Context.Request.InputStream);
            string s = sr.ReadToEnd();
            sr.Close();

            return x + y;
        }

        [WebMethod(MessageName = "concat", Description = "Concatination of string and double")]
        public string Concat(string s, double d)
        {
            return s + " " + d.ToString();
        }

        [WebMethod(MessageName = "sum", Description = "Sum of fields of two [A] objects. Return [A] object")]
        public A Sum(A a1, A a2)
        {
            return new A(a1.s + a2.s, a1.k + a2.k, a1.f + a2.f);
        }

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod(MessageName = "adds", Description = "Sum of two integer numbers. Response JSON")]
        public int Adds(int x, int y)
        {
            return x + y;
        }

    }
}
