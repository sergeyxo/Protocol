using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Protocol.Models.Bases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Protocol.Models
{
    public class SectionSchools:BaseEntity
    {
        [Display(Name = "Секция")]
        public override string Name { get; set; }
        public ICollection<School> Schools  { get; set;}
    }
}