using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpUnpack
{
    public class RequestRepo
    {
        private static List<TargetRequest> _repo = new List<TargetRequest>();

        public static void Add(TargetRequest request)
        {
            if (_repo.Count > 100)
                _repo.Clear();

            _repo.Add(request);
        }

        public static IEnumerable<TargetRequest> GetAll()
        {
            return _repo;
        }
    }
}
