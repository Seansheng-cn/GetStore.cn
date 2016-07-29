namespace GODInventory.MyLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("god_inventory.t_itemlist")]
    public partial class t_itemlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 自社コード { get; set; }

        [StringLength(255)]
        public string 得意先 { get; set; }

        public short? ジャンル { get; set; }

        [StringLength(255)]
        public string 商品名 { get; set; }

        [StringLength(255)]
        public string 規格 { get; set; }

        [StringLength(255)]
        public string 配送担当 { get; set; }

        public DateTime? 価格発動日 { get; set; }

        public int? PT入数 { get; set; }

        public decimal? 仕入原価 { get; set; }

        public decimal? 単価 { get; set; }

        public decimal? 売価 { get; set; }

        public int? 商品コード { get; set; }

        public long JANコード { get; set; }

        public double? インストアコード { get; set; }

        public double? 単品重量 { get; set; }

        [StringLength(255)]
        public string 単位 { get; set; }

        public sbyte? PT単位か { get; set; }
    }
}
