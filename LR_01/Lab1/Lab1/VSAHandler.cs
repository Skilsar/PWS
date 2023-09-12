using System;
using System.Web;
using System.Web.SessionState;

namespace Lab1
{
    public class VSAHandler : IHttpHandler, IRequiresSessionState
    {

        #region Члены IHttpHandler

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            var method = context.Request.HttpMethod;
            var response = context.Response;
            VsaSession state;

            if (context.Session["state"] == null) {
                context.Session["state"] = new VsaSession();
            }
           
            state = context.Session["state"] as VsaSession;
            

            if (method.Equals("GET"))
            {
                int stackValue = state.Peek();
                response.AddHeader("Content-Type", "appliction/json");
                response.Write("{\"RESULT\":" + (stackValue + Result.value) + "}");
            }else if (method.Equals("POST"))
            {
                int resultNewValue = Int32.Parse(context.Request.QueryString["RESULT"]);
                Result.value = resultNewValue;
                response.StatusCode = 200;
                response.End();
            }
            else if (method.Equals("PUT"))
            {
                int addParam = Int32.Parse(context.Request.QueryString["ADD"]);
                state.Push(addParam);
                response.StatusCode = 200;
                response.End();
            }
            else if (method.Equals("DELETE"))
            {
                int deletedValue  =  state.Pop();
                response.AddHeader("Content-Type", "appliction/json");
                response.Write("{\"DELETED_STACK_ELEMENT\":" + deletedValue + "}");
            }
        }

        #endregion
    }
}
