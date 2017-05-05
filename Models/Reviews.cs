using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewProjectWeek5.Models
{
    public class Reviews
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:M/d/yyyy}")]
        public DateTime PublishDate { get; set; } 
        public string Location { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}