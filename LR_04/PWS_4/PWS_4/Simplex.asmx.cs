using System.IO;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace PWS_4
{
    [WebService(Namespace = "http://VSA/", Description = "Simplex ASMX Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    public class Simplex : WebService
    {
        [WebMethod(MessageName = "ASMX.ADD", Description = "Sum of 2 numbers")]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod(MessageName = "ASMX.CONCAT", Description = "Concat of string and double")]
        public string Concat(string s, double d)
        {
            return s + " " + d.ToString();
        }

        [WebMethod(MessageName = "ASMX.SUM", Description = "Sum of fileds of two [A] objects. Return [A] object")]
        public A Sum(A a1, A a2)
        {
            ParseBody(Context.Request);
            return new A(a1.s + a2.s, a1.k + a2.k, a1.f + a2.f);
        }

        public static string ParseBody(HttpRequest request)
        {
            
            request.InputStream.Position = 0;
            var body = string.Empty;

            using (Stream receiveStream = request.InputStream)
            {
                using (StreamReader readStream = new StreamReader(receiveStream, true))
                {
                    body = readStream.ReadToEnd();
                }
            }

            return body;
        }

        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        [WebMethod(MessageName = "ASMX.ADDS", Description = "Sum of 2 int. Response JSON")]
        public int Adds(int x, int y)
        {
            return x + y;
        }
    }
}
