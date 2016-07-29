using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GODInventory.MyLinq
{

    public  class v_pendingorder 
    {


        public int id受注データ { get; set; }

        public DateTime? 発注日 { get; set; }

        public DateTime? 受注日 { get; set; }

        public DateTime? 出荷日 { get; set; }

        public DateTime? 納品日 { get; set; }

        public int 店舗コード { get; set; }

        public string 店舗名カナ { get; set; }

        public int? 社内伝番 { get; set; }

        public short? 行数 { get; set; }

        public short? 最大行数 { get; set; }

        public short? ジャンル { get; set; }

        public int 伝票番号 { get; set; }

        public short 発注形態区分 { get; set; }

        public string 発注形態名称漢字 { get; set; }

        public int 発注数量 { get; set; }


        public int 実際出荷数量 { get; set; }

        public int 自社コード { get; set; }

        public string 規格名漢字 { get; set; }

        public int 商品コード { get; set; }

        public long ＪＡＮコード { get; set; }


        public string 品名漢字 { get; set; }

        public int? 口数 { get; set; }

        public int? 納品口数 { get; set; }

        public string 単位 { get; set; }

        public int? 重量 { get; set; }

        public int 原単価_税抜_ { get; set; }


        public int 原価金額_税抜_ { get; set; }


        public int 納品原価金額 { get; set; }


        public int? 売単価_税抜_ { get; set; }

        public int 出荷業務仕入先コード { get; set; }

        public bool 一旦保留 { get; set; }

        public string 実際配送担当 { get; set; }
        
        public DateTime? 配送担当受信時刻 { get; set; }


        public short 配送担当受信 { get; set; }

        public string 店舗名漢字 { get; set; }

        public bool 受領 { get; set; }

        public string ダブリ { get; set; }


        public string キャンセル { get; set; }

        public DateTime? キャンセル時刻 { get; set; }

        public int 在庫数 { get; set; }

        public string 在庫状態 { get; set; }

        public string 納品場所名カナ { get; set; }
        
        public string 納品場所名漢字 { get; set; }

        // shop
        public int 店番 { get; set; }

        public string 店名 { get; set; }

        public string 県別 { get; set; }

        public string 住所 { get; set; }

        public string 電話番号 { get; set; }

        public long 出荷No { get; set; }
        // fixed
        public string 直送区分 { get; set; }

        public long ASN管理連番 { get; set; }
        public int Status { get; set; }
    }

}
