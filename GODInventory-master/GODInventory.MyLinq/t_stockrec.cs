namespace GODInventory.MyLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("god_inventory.t_stockrec")]
    public partial class t_stockrec
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime 日付 { get; set; }

        [Required]
        [StringLength(255)]
        public string 区分 { get; set; }

        public int 自社コード { get; set; }

        public int 数量 { get; set; }

        [StringLength(255)]
        public string 状態 { get; set; }

        [StringLength(255)]
        public string 元 { get; set; }

        [StringLength(255)]
        public string 先 { get; set; }

        [StringLength(255)]
        public string 納品書番号 { get; set; }
    }
}
