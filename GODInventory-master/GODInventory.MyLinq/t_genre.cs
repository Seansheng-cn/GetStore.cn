namespace GODInventory.MyLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("god_inventory.t_genre")]
    public partial class t_genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idジャンル { get; set; }

        [Required]
        [StringLength(255)]
        public string ジャンル名 { get; set; }
    }
}
