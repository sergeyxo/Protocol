using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Protocol.Models.Bases
{
    public class BaseEntity : IUniqueItem,IHasLastModified
    {
        public BaseEntity()
        {
           // CreatedDate = DateTime.Now;
           // Id = Guid.NewGuid();
            ParenId = -1;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public virtual string Name { get; set; }

        public int ParenId { get; set; }
        [ForeignKey("ParenId")]
        public virtual IUniqueItem Parent { get; set; }


      //  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]      
        public DateTime? CreatedDate { get; set; }     
        public String UserCreated { get; set; }     
        public DateTime? LastModified { get; set; }     
        public String UserModified { get; set; }

    }
}