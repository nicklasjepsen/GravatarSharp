using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravatarSharp.Core.Model
{
    public class GetProfileResult
    {
        public GravatarProfile Profile { get; set; }
        public string ErrorMessage { get; set; }
    }
}
