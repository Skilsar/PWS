using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PWSLab_04_WebForms
{
    public class MyPerfectService : Simplex
    {
        [return: XmlElement("addResult")]
        public override int Add(int x, int y)
        {
            Stream str = this.Context.Request.InputStream;
            str.Position = 0;
            StreamReader sr = new StreamReader(this.Context.Request.InputStream);
            string s = sr.ReadToEnd();
            sr.Close();

            return x + y;
        }

        [return: XmlElement("addsResult")]
        public override int Adds(int x, int y)
        {
            return x + y;
        }

        [return: XmlElement("concatResult")]
        public override string Concat(string s, double d)
        {
            return s + " " + d.ToString();
        }

        [return: XmlElement("sumResult")]
        public override A Sum(A a1, A a2)
        {
            return new A(a1.s + a2.s, a1.k + a2.k, a1.f + a2.f);
        }
    }
}