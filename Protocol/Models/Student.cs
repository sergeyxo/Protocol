using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Protocol.Models.Bases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Protocol.Models
{
    public class Student:BaseEntity
    {
        [Required]
        [Display(Name = "Номер карты")]
        public string NumberCart { get; set; }

        [Display(Name = "Отчество")]
        public string SecondName { get; set; }
        [Required]
        [Display(Name = "Фамилия")]
        public string Family { get; set; }
        [NotMapped]
        [Display(Name = "Полное имя")]
        public string FullName
        {
            get
            {
                return Name+" "+SecondName + " " + Family;
            }
        }
        [Required]
        [Display(Name = "Дата рождения")]
        public DateTime DBO { get; set; }

 
    }
}