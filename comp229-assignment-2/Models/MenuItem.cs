using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace comp229_assignment_2.Models {
    [Table("MenuItems")]
    public class MenuItem {

        public MenuItem() { }

        public int id { get; set; }

        [Required]
        [StringLength(120)]
        public string name { get; set; }

        [Required]
        [StringLength(1024)]
        public string description { get; set; }

        [Required]
        public double price { get; set; }

        [Required]
        public ItemCategoryType category { get; set; }

        [Required]
        public ItemOriginType type { get; set; }

        public ICollection<string> pictures { get; set; }
    }

    public enum ItemCategoryType {
        Appetizer,
        Beverage,
        Salad,
        Beef,
        Chicken,
        Pork,
        Seafood,
        Exotic,
    }

    public enum ItemOriginType
    {
        Brazil,
        China
    }

}