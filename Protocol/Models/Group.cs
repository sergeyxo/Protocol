using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Protocol.Models.Bases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Protocol.Models
{
    public class Group:BaseEntity
    {
        [Display(Name = "Группа")]
        public override string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}