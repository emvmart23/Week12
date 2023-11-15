using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Week12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        public List<String> Get()
        {
            return null;
        }
        public string GetById()
    }
}
