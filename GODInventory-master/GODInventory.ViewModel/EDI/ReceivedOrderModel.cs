using GODInventory.MyLinq;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace GODInventory.ViewModel.EDI
{
    public class ReceivedOrderModel
    {
        
        //1 データID       3 1
        //2 管理連番        13 4
        //3 システム管理日付 8 17
        //4 データ作成日      8 25
        //5 データ作成時刻 6 33
        //6 法人 コード  2 39
        //7 法人名漢字   20 41
        //8 法人名 カナ  15 61
        //9 店舗 コード  3 76

        //10 店舗名漢字  20 79
        //11 店舗名カナ  15  99
        //12 部門 コード 2   114
        //13 部門名漢字  20  116
        //14 部門名カナ  15  136
        //15 仕入先コード 6   151
        //16 仕入先名漢字 20  157
        //17 仕入先名カナ 15  177
        //18 支払仕入先コード   6   192
        //19 支払仕入先名漢字   20  198
        //20 支払仕入先名カナ   15  218
        //21 出荷業務仕入先コード 6   233
        //22 伝票区分   2   239
        //23 赤黒区分   1   241

        //24 伝票番号   8   242
        //25 行番号    2   250
        //26 元伝票番号  8   252
        //27 発生日        8   260
        //28 仕入計上日  8   268
        //29 商品コード区分   1   276
        //30 ＪＡＮコード     13  277
        //31 商品 コード     8   290
        //32 オプション使用欄   20  298
        //33 ＧＴＩＮ       14  318
        //34 品名漢字       20  332
        //35 品名 カナ      25  352
        //36 規格名漢字      20  377
        //37 規格名カナ      25  397
        //38 数量             6   422
        //39 総額取引区分     1   428

        //40 原単価(税抜 )   9   429
        //41 原単価(税込 )   9   438
        //42 原価金額(税抜 )  9   447
        //43 原価金額(税込 )  9   456
        //44 税区分        1   465
        //45 税率         4   466
        //46 税額         9   470
        //47 売単価（税抜  ）  7   479
        //48 売単価（税込  ）  7   486
        //49 特価区分         1   493
        //50 PB区分         1 494
        //51 原価区分       1   495
        //52 受領区分       2   496
        //53 理由区分       2   498
        //54 理由コード      2   500
        //55 理由漢字       20  502
        //56 連絡事項１      30  522
        //57 連絡事項２      30  552
        //58 納品先店舗コード   3   582

        //59 納品先店舗名漢字   20  585
        //60 納品先店舗名カナ   15  605
        //61 センター経由区分   1   620
        //62 センターコード    5   621
        //63 センター名漢字    20  626
        //64 予備     55 646

        byte[] データID;
        byte[] 管理連番;
        byte[] システム管理日付;
        byte[] データ作成日;
        byte[] データ作成時刻;
        byte[] 法人コード;
        byte[] 法人名漢字;
        byte[] 法人名カナ;
        byte[] 店舗コード;

        byte[] 店舗名漢字;
        byte[] 店舗名カナ;
        byte[] 部門コード;
        byte[] 部門名漢字;
        byte[] 部門名カナ;
        byte[] 仕入先コード;
        byte[] 仕入先名漢字;
        byte[] 仕入先名カナ;
        byte[] 支払仕入先コード;
        byte[] 支払仕入先名漢字;
        byte[] 支払仕入先名カナ;
        byte[] 出荷業務仕入先コード;
        byte[] 伝票区分;
        byte[] 赤黒区分;

        byte[] 伝票番号;
        byte[] 行番号;
        byte[] 元伝票番号;
        byte[] 発生日;
        byte[] 仕入計上日;
        byte[] 商品コード区分;
        byte[] ＪＡＮコード;
        byte[] 商品コード;
        byte[] オプション使用欄;
        byte[] ＧＴＩＮ;
        byte[] 品名漢字;
        byte[] 品名カナ;
        byte[] 規格名漢字;
        byte[] 規格名カナ;
        byte[] 数量;
        byte[] 総額取引区分;

        byte[] 原単価_税抜_;
        byte[] 原単価_税込_;
        byte[] 原価金額_税抜_;
        byte[] 原価金額_税込_;
        byte[] 税区分;
        byte[] 税率;
        byte[] 税額;
        byte[] 売単価_税抜_;
        byte[] 売単価_税込_;
        byte[] 特価区分;
        byte[] PB区分;
        byte[] 原価区分;
        byte[] 受領区分;
        byte[] 理由区分;
        byte[] 理由コード;
        byte[] 理由漢字;
        byte[] 連絡事項１;
        byte[] 連絡事項２;
        byte[] 納品先店舗コード;

        byte[] 納品先店舗名漢字;
        byte[] 納品先店舗名カナ;
        byte[] センター経由区分;
        byte[] センターコード;
        byte[] センター名漢字;
        byte[] 予備;
        byte[] nr;

        v_receivedorder entity;

        public ReceivedOrderModel(BinaryReader br)
        {
            this.データID = br.ReadBytes(3);
            Debug.Assert(DataID == "C02");
            this.管理連番 = br.ReadBytes(13);
            this.システム管理日付 = br.ReadBytes(8);
            this.データ作成日 = br.ReadBytes(8);
            this.データ作成時刻 = br.ReadBytes(6);//
            this.法人コード = br.ReadBytes(2);//  2 39
            this.法人名漢字 = br.ReadBytes(20);//   20 41
            this.法人名カナ = br.ReadBytes(15);//  15 61
            this.店舗コード = br.ReadBytes(3);//  3 76

            this.店舗名漢字 = br.ReadBytes(20);//  20 79
            this.店舗名カナ = br.ReadBytes(15);//  15  99
            this.部門コード = br.ReadBytes(2);// 2   114
            this.部門名漢字 = br.ReadBytes(20);//  20  116
            this.部門名カナ = br.ReadBytes(15);//  15  136
            this.仕入先コード = br.ReadBytes(6);// 6   151
            this.仕入先名漢字 = br.ReadBytes(20);// 20  157
            this.仕入先名カナ = br.ReadBytes(15);// 15  177
            this.支払仕入先コード = br.ReadBytes(6);//   6   192
            this.支払仕入先名漢字 = br.ReadBytes(20);//   20  198
            this.支払仕入先名カナ = br.ReadBytes(15);//   15  218
            this.出荷業務仕入先コード = br.ReadBytes(6);// 6   233
            this.伝票区分 = br.ReadBytes(2);//   2   239
            this.赤黒区分 = br.ReadBytes(1);//   1   241

            this.伝票番号 = br.ReadBytes(8);//   8   242
            this.行番号 = br.ReadBytes(2);//   2   250
            this.元伝票番号 = br.ReadBytes(8);//  8   252
            this.発生日 = br.ReadBytes(8);//        8   260
            this.仕入計上日 = br.ReadBytes(8);//  8   268
            this.商品コード区分 = br.ReadBytes(1);//   1   276
            this.ＪＡＮコード = br.ReadBytes(13);//     13  277
            this.商品コード = br.ReadBytes(8);//    8   290
            this.オプション使用欄 = br.ReadBytes(20);//   20  298
            this.ＧＴＩＮ = br.ReadBytes(14);//       14  318
            this.品名漢字 = br.ReadBytes(20);//       20  332
            this.品名カナ = br.ReadBytes(25);//      25  352
            this.規格名漢字 = br.ReadBytes(20);//      20  377
            this.規格名カナ = br.ReadBytes(25);//      25  397
            this.数量 = br.ReadBytes(6);//            6   422
            this.総額取引区分 = br.ReadBytes(1);//    1   428

            this.原単価_税抜_ = br.ReadBytes(9);//   9   429
            this.原単価_税込_ = br.ReadBytes(9);//   9   438
            this.原価金額_税抜_ = br.ReadBytes(9);//  9   447
            this.原価金額_税込_ = br.ReadBytes(9);//  9   456
            this.税区分 = br.ReadBytes(1);//      1   465
            this.税率 = br.ReadBytes(4);//         4   466
            this.税額 = br.ReadBytes(9);//        9   470
            this.売単価_税抜_ = br.ReadBytes(7);//  7   479
            this.売単価_税込_ = br.ReadBytes(7);//  7   486
            this.特価区分 = br.ReadBytes(1);//        1   493
            this.PB区分 = br.ReadBytes(1);//       1 494
            this.原価区分 = br.ReadBytes(1);//       1   495
            this.受領区分 = br.ReadBytes(2);//       2   496
            this.理由区分 = br.ReadBytes(2);//       2   498
            this.理由コード = br.ReadBytes(2);//      2   500
            this.理由漢字 = br.ReadBytes(20);//       20  502
            this.連絡事項１ = br.ReadBytes(30);//      30  522
            this.連絡事項２ = br.ReadBytes(30);//      30  552
            this.納品先店舗コード = br.ReadBytes(3);//   3   582

            this.納品先店舗名漢字 = br.ReadBytes(20);//   20  585
            this.納品先店舗名カナ = br.ReadBytes(15);//   15  605
            this.センター経由区分 = br.ReadBytes(1);//   1   620
            this.センターコード = br.ReadBytes(5);//   5   621
            this.センター名漢字 = br.ReadBytes(20);//    20  626
            this.予備 = br.ReadBytes(55);//    55  626
            this.nr = br.ReadBytes(2); // \n\r
            Debug.Assert(this.nr[0] == 0x0D && this.nr[1] == 0x0A);
        }

        public v_receivedorder ConverToEntity(GODDbContext ctx )
        {
            this.entity = FindMatchedOrder(ctx);

            if (entity != null)
            {

            }

            return entity;
        }


        public CustomMySqlParameters ToSqlArguments()
        {
            //52 受領区分       2   496
            //53 理由区分       2   498
            //54 理由コード      2   500
            //55 理由漢字       20  502
            //56 連絡事項１      30  522
            //57 連絡事項２      30  552

            var o = this.entity;
            string sql = @"UPDATE  `t_orderdata` SET
`受領確認`= 1, `受領数量`= @p1 
WHERE id受注データ= @P0;";

            MySqlParameter[] parameters = { new MySqlParameter("@p1", this.ReceivedQuantity), new MySqlParameter("@p0", this.entity.id受注データ) };

            return new CustomMySqlParameters(parameters, sql);
        }

        public string ToRawSql() {

            var o = this.entity;
            string format = @"UPDATE  `t_orderdata` SET `受領確認`= 1, `受領数量`= {2}, `Status`=4 WHERE `Status`=3 and `伝票番号`= {0} and `店舗コード`={1};";

            return String.Format(format, this.InvoiceCode, this.StoreCode, this.ReceivedQuantity);
        
        }

        public int InvoiceCode {
            get { return Convert.ToInt32(Encoding.ASCII.GetString(this.伝票番号));  }
        }

        public int StoreCode
        {
            get { return Convert.ToInt32(Encoding.ASCII.GetString(this.店舗コード)); }
        }

        public string DataID
        {
            get { return Encoding.ASCII.GetString(this.データID); }
        }

        public int ReceivedQuantity {
            get { return Convert.ToInt32(Encoding.ASCII.GetString(this.数量))/10; }
        }


        private v_receivedorder FindMatchedOrder(GODDbContext ctx)
        {
            var date = DateTime.Now.AddMonths(-3);
            var order = (from t_orderdata o in ctx.t_orderdata
                         where o.店舗コード == StoreCode && o.伝票番号 == InvoiceCode && o.受注日 > date && o.受領確認 == false
                         select( new v_receivedorder { id受注データ=o.id受注データ, 店舗コード=o.店舗コード, 伝票番号= o.伝票番号 })).FirstOrDefault();
            return order;
        }


    }
}
