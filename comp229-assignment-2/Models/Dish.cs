using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace comp229_assignment_2.Models {
    [Table("Dish")]
    public class Dish {

        public Dish() { }

        public int id { get; set; }

        [Required]
        [StringLength(120)]
        public string name { get; set; }

        [Required]
        [StringLength(1024)]
        public string description { get; set; }

        [Required]
        public double price { get; set; }

        public ICollection<string> pictures { get; set; }
    }
}