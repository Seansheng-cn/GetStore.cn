namespace GODInventory.MyLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("god_inventory.t_date")]
    public partial class t_date
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime 日付 { get; set; }
    }
}
