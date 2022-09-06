using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuAPIv2
{
    // API Exception
    public class OsuAPIException : Exception
    {
        public OsuAPIException(string message) : base(message)
        {
        }
    }
}
