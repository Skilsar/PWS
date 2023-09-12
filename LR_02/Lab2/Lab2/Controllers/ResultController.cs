using Lab2.classes;
using System.Web.Http;


namespace Lab2.Controllers
{
    [Route("api/result")]
    public class ResultController : ApiController
    {
        [HttpGet]
        public IHttpActionResult getResult()
        {
            return Json(VsaState.GetResult());
        }


        [HttpPost]
        public IHttpActionResult setResult([FromUri] int result)
        {
            VsaState.SetResult(result);
            return Ok();
        }


        [HttpPut]
        public IHttpActionResult pushValueToStack([FromUri] int add) {
            VsaState.Push(add);
            return Ok(); 
        }


        [HttpDelete]
        public IHttpActionResult popValueFromStack() {
            VsaState.Pop();
            return Ok(); 
        }  


    }
}