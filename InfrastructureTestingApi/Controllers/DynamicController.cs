using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace InfrastructureTestingApi
{
    [ApiController]
    [Route("[controller]")]
    public class DynamicController : ControllerBase
    {
        public DynamicController()
        {
            
        }

        // GET all action

        // GET by Id action

        [HttpGet("{size}")]
        public ActionResult<PerformancePackage> GetPackage(int size)
        {
            return new PerformancePackage(size);
        }

        // POST action

        // PUT action

        // DELETE action
    }
}