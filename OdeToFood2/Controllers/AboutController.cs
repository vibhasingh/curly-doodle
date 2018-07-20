using Microsoft.AspNetCore.Mvc;

namespace OdeToFood2.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            return "9665878945";
        }
        
        public string Address()
        {
            return "India";
        }
    }
}