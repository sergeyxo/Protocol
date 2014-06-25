using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Protocol.Models.Bases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Protocol.Models
{
    public class School:BaseEntity
    {
        [Display(Name = "Школа")]
        public override string Name { get; set; }
        public ICollection<Group> Groups    { get; set; }

    }
}