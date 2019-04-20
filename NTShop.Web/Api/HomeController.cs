using NTShop.Service;
using NTShop.Web.Infrastructure.Core;
using System.Web.Http;

namespace NTShop.Web.Api
{
    [RoutePrefix("api/home")]
   
    public class HomeController : ApiControllerBase
    {
        private IErrorService _errorService;

        public HomeController(IErrorService errorService) : base(errorService)
        {
            this._errorService = errorService;
        }


        [HttpGet]
        [Route("TestMethod")]
        public string TestMethod() {
            return "hello, NT member";
        }
    }
}