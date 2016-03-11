using Microsoft.AspNet.Mvc;
using JustDemoTest;
// using Microsoft.Extensions.Logging;

namespace JustDemo.Controllers
{
    public class JustDemoController : Controller
    {
        private readonly JustDemoContext _JustDemoContext;
        // private readonly ILogger _logger;
         
        // public CarsController(JustDemoContext JustDemoContext,ILoggerFactory loggerFactory)
        public JustDemoController(JustDemoContext JustDemoContext)
        {
            //If not Inject early, will get Exception, When (JustDemoContext JustDemoContext,ILoggerFactory loggerFactory)
            _JustDemoContext = JustDemoContext;
        }
        
        [Route("api/items")]
        public IActionResult Get()
        {
            var items = _JustDemoContext.GetItems();
            return Ok(items);
        }
        
        [Route("api/errors")]
        public void Post()
        {
            var items = _JustDemoContext.PostItems();            
           
            Response.StatusCode = items?204:404;
           
        }
    }
}

