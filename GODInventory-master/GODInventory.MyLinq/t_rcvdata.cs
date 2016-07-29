namespace GODInventory.MyLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("god_inventory.t_rcvdata")]
    public partial class t_rcvdata
    {
        [Key]
        public int id受領データ { get; set; }

        [Column(TypeName = "date")]
        public DateTime? 受信日 { get; set; }

        public TimeSpan? 受信時刻 { get; set; }

        public double? 法人コード { get; set; }

        [StringLength(255)]
        public string 法人名漢字 { get; set; }

        [StringLength(255)]
        public string 法人名カナ { get; set; }

        public int? 店舗コード { get; set; }

        [StringLength(255)]
        public string 店舗名漢字 { get; set; }

        [StringLength(255)]
        public string 店舗名カナ { get; set; }

        public double? 部門コード { get; set; }

        [StringLength(255)]
        public string 部門名漢字 { get; set; }

        [StringLength(255)]
        public string 部門名カナ { get; set; }

        public double? 仕入先コード { get; set; }

        [StringLength(255)]
        public string 仕入先名漢字 { get; set; }

        [StringLength(255)]
        public string 仕入先名カナ { get; set; }

        public double? 支払仕入先コード { get; set; }

        [StringLength(255)]
        public string 支払仕入先名漢字 { get; set; }

        [StringLength(255)]
        public string 支払仕入先名カナ { get; set; }

        public double? 出荷業務仕入先コード { get; set; }

        public double? 伝票区分 { get; set; }

        public double? 赤黒区分 { get; set; }

        public double? 伝票番号 { get; set; }

        public double? 行番号 { get; set; }

        public double? 元伝票番号 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? 発生日 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? 仕入計上日 { get; set; }

        public double? 商品コード区分 { get; set; }

        public double? ＪＡＮコード { get; set; }

        public double? 商品コード { get; set; }

        public double? オプション使用欄 { get; set; }

        [StringLength(255)]
        public string ＧＴＩＮ { get; set; }

        [StringLength(255)]
        public string 品名漢字 { get; set; }

        [StringLength(255)]
        public string 品名カナ { get; set; }

        [StringLength(255)]
        public string 規格名漢字 { get; set; }

        [StringLength(255)]
        public string 規格名カナ { get; set; }

        public double? 数量 { get; set; }

        public double? 総額取引区分 { get; set; }

        [Column("原単価(税抜)")]
        public double? 原単価_税抜_ { get; set; }

        [Column("原単価(税込)")]
        public double? 原単価_税込_ { get; set; }

        [Column("原価金額(税抜)")]
        public double? 原価金額_税抜_ { get; set; }

        [Column("原価金額(税込)")]
        public double? 原価金額_税込_ { get; set; }

        public double? 税区分 { get; set; }

        public double? 税率 { get; set; }

        public double? 税額 { get; set; }

        [Column("売単価(税抜)")]
        public double? 売単価_税抜_ { get; set; }

        [Column("売単価(税込)")]
        public double? 売単価_税込_ { get; set; }

        public double? 特価区分 { get; set; }

        public double? PB区分 { get; set; }

        public double? 原価区分 { get; set; }

        public double? 受領区分 { get; set; }

        public double? 理由区分 { get; set; }

        public double? 理由コード { get; set; }

        [StringLength(255)]
        public string 理由漢字 { get; set; }

        [StringLength(255)]
        public string 連絡事項１ { get; set; }

        [StringLength(255)]
        public string 連絡事項２ { get; set; }

        public double? 納品先店舗コード { get; set; }

        [StringLength(255)]
        public string 納品先店舗名漢字 { get; set; }

        [StringLength(255)]
        public string 納品先店舗名カナ { get; set; }

        public double? センター経由区分 { get; set; }

        public double? センターコード { get; set; }

        [StringLength(255)]
        public string センター名漢字 { get; set; }
    }
}
