namespace GODInventory.MyLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    //using System.Data.Entity.Spatial;

    [Table("god_inventory.t_stockstate")]
    public partial class t_stockstate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 自社コード { get; set; }

        public int 在庫数 { get; set; }

        [Required]
        [StringLength(255)]
        public string 在庫状態 { get; set; }
    }
}
