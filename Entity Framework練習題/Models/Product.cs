namespace Entity_Framework練習題.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Quantity { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Price { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Type { get; set; }
    }
}
