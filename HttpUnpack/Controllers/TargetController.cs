using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HttpUnpack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TargetController : ControllerBase
    {

        private readonly ILogger<TargetController> _logger;

        public TargetController(ILogger<TargetController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var req = new TargetRequest(GetSource(), GetHeaders(), GetQuery());
            RequestRepo.Add(req);

            return "GET Ok.";
        }

        [HttpPost]
        public string Post()
        {
            var req = new TargetRequest(GetSource(), GetHeaders(), GetQuery(), GetBody());
            RequestRepo.Add(req);

            return "POST Ok.";
        }

        private string GetHeaders()
        {
            string retval = "";
            foreach (var header in HttpContext.Request.Headers)
                retval += header.Key + ": " + header.Value + Environment.NewLine;

            return retval;
        }

        private string GetQuery()
        {
            string retval = "";
            retval = HttpContext.Request.QueryString.ToString();

            return retval;
        }

        private string GetBody()
        {
            string retval = "";
            var rdr = new StreamReader(HttpContext.Request.Body);
            retval = rdr.ReadToEnd();
            return retval;
        }

        private string GetSource()
        {
            string retval = "";
            retval = HttpContext.Connection.RemoteIpAddress.ToString();

            return retval;
        }
    }
}
