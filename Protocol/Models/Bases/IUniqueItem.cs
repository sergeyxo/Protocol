using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protocol.Models.Bases
{
    public interface IUniqueItem
    {
        int Id { get; set; }
        string Name { get; set; }
        int ParenId { get; set; }
        IUniqueItem Parent { get; set; }

    }
}
