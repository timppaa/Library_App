using Microsoft.AspNetCore.Mvc;

namespace Library_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet(Name = "SearchBook")]
        public void Search()
        {

        }
    }
}
