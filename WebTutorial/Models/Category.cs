using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTutorial.Models
{
    public class Category
    {
        //tell the db/entity framework core that this needs to be the primary key and needs to be identity
        [Key]
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required]
        public string CategoryName { get; set; }

        [DisplayName("Display Order")]
        [Required]
        [Range(1,int.MaxValue,ErrorMessage = "Display order for category must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
