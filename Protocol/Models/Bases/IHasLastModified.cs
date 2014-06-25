using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protocol.Models.Bases
{
    public interface IHasLastModified
    {
        DateTime? CreatedDate { get; set; }
        String UserCreated { get; set; }
        DateTime? LastModified { get; set; }
        String UserModified { get; set; }
    }
}
