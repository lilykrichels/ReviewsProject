using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewProjectWeek5.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }

        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}