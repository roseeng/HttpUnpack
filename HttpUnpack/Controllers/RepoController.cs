using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpUnpack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RepoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TargetRequest> GetRequests()
        {
            return RequestRepo.GetAll();
        }
    }
}
