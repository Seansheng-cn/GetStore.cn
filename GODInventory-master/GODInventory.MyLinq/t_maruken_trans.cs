namespace GODInventory.MyLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("god_inventory.t_maruken_trans")]
    public partial class t_maruken_trans
    {
        [StringLength(255)]
        public string id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? 受注日 { get; set; }

        public short 店舗コード { get; set; }

        [StringLength(255)]
        public string 店舗名漢字 { get; set; }

        public int 伝票番号 { get; set; }

        [StringLength(255)]
        public string キャンセル { get; set; }

        public DateTime? キャンセル時刻 { get; set; }

        public sbyte? ジャンル { get; set; }

        [StringLength(255)]
        public string 品名漢字 { get; set; }

        [StringLength(255)]
        public string 規格名漢字 { get; set; }

        public int? 発注数量 { get; set; }

        public int? 口数 { get; set; }

        public int? 重量 { get; set; }

        [StringLength(255)]
        public string 単位 { get; set; }

        [StringLength(255)]
        public string 実際配送担当 { get; set; }

        [StringLength(255)]
        public string 県別 { get; set; }

        public bool? 配送担当受信 { get; set; }

        public DateTime? 配送担当受信時刻 { get; set; }

        public bool? 専務受信 { get; set; }

        public DateTime? 専務受信時刻 { get; set; }

        [StringLength(255)]
        public string 納品指示 { get; set; }

        [StringLength(255)]
        public string 備考 { get; set; }
    }
}
