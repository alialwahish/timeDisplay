using Microsoft.AspNetCore.Mvc;


namespace TimeDisp{


    public class TimeController : Controller{

        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View();
        }
    }
}