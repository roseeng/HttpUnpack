using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpUnpack
{
    public class TargetRequest
    {
        public DateTime Timestamp { get; set; }
        public string Source { get; set; }


        public string Headers { get; set; }
        public string Query { get; set; }
        public string Body { get; set; }

        public TargetRequest()
        { }

        public TargetRequest(string source, string headers, string query, string body = null)
        {
            Timestamp = DateTime.Now;
            Source = source;
            Headers = headers;
            Query = query;
            Body = body;
        }
    }
}
