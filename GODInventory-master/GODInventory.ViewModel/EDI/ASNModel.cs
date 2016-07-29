using GODInventory.MyLinq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace GODInventory.ViewModel.EDI
{
    public class ASNModel
    {
        //1 データID               3  1
        //2 管理連番                13  4
        //3 システム管理日付        8 17
        //4 データ作成日            8 25
        //5 データ作成時刻        6    33
        //6 法人 コード           2   39
        //7 店舗 コード           3   41
        //8 部門 コード           2   44
        //9 仕入先 コード         6   46
        //10 出荷業務仕入先コード    6 52
        //11 伝票区分               2 58
        //12 伝票番号               8 60
        //13 行番号                2 68
        //14 元伝票番号              8 70
        //15 発注日                8 78
        //16 納品予定日              8 86
        //17 入荷予定日          8 94
        //18 入荷予定時刻         4 102
        //19 出荷日                8 106

        //20 発注形態区分         2 114
        //21 入力区分       1 116
        //22 直送区分       1 117
        //23 運送区分       1 118
        //24 出荷 No          18 119
        //25 梱包識別区分     1 137
        //26 梱包 No          20 138
        //27 出荷総梱数      5 158
        //28 出荷 ケース数    5 163
        //29 出荷 バラ混載箱数  5 168
        //30 商品 コード区分   1 173
        //31 ＪＡＮコード     13 174
        //32 商品 コード     8 187
        //33 オプション使用欄   20 195
        //34 ＧＴＩＮ           14 215
        //35 品名漢字       20 229
        //36 品名 カナ      25 249
        //37 規格名漢字      20 274
        //38 規格名カナ      25 294
        //39 発注数        6 319
        //40 納品数        6 325
        //41 訂正理由区分     2 331
        //42 総額取引区分     1 333
        //43 原単価(税抜 )   9 334
        //44 原単価(税込 )   9 343
        //45 原価金額(税抜 )  9 352
        //46 原価金額(税込 )  9 361
        //47 税額             9 370
        //48 税区分            9 379
        //49 税率             4 380
        //50 売単価（税抜  ）  7 384
        //51 売単価（税込）    7 391

        //52 納品先店舗コード   3 398
        //53 納品場所コード    1 401
        //54 納品場所名漢字    6 402
        //55 納品場所カナ         6 408
        //56 センター経由区分   1 414
        //57 センターコード    5 415
        //58 便区分            1 420
        //59 カゴ車No          20 421
        //60 梱包 サイズ(縦)      5 441
        //61 梱包 サイズ(高さ)     5 446
        //62 梱包 サイズ(横)      5 451
        //63 梱包重量           5 456
        //64 重量識別区分     1 461 
        //65 納入形態区分     1 462
        //66 出荷単位区分     2 463
        //67 単位入数           6 465
        //68 予備  （数値  ） 2 471
        //69 予備             28 473
        ASNHeadModel head;
        t_orderdata entity;

        Byte[] データID;//1 データID               3  1
        Byte[] 管理連番;//2 管理連番                13  4
        Byte[] システム管理日付;//3 システム管理日付        8 17
        Byte[] データ作成日;//4 データ作成日            8 25
        Byte[] データ作成時刻;//5 データ作成時刻        6    33
        Byte[] 法人コード;//6 法人コード           2   39
        Byte[] 店舗コード;//7 店舗コード           3   41
        Byte[] 部門コード;//8 部門コード           2   44
        Byte[] 仕入先コード;//9 仕入先コード         6   46
        Byte[] 出荷業務仕入先コード;//10 出荷業務仕入先コード    6 52
        Byte[] 伝票区分;//11 伝票区分               2 58
        Byte[] 伝票番号;//12 伝票番号               8 60
        Byte[] 行番号;//13 行番号                2 68
        Byte[] 元伝票番号;//14 元伝票番号              8 70
        Byte[] 発注日;//15 発注日                8 78
        Byte[] 納品予定日;//16 納品予定日              8 86
        Byte[] 入荷予定日;//17 入荷予定日          8 94
        Byte[] 入荷予定時刻;//18 入荷予定時刻         4 102
        Byte[] 出荷日;//19 出荷日                8 106
        Byte[] 発注形態区分;//20 発注形態区分         2 114

        Byte[] 入力区分;//21 入力区分       1 116
        Byte[] 直送区分;//22 直送区分       1 117
        Byte[] 運送区分;//23 運送区分       1 118
        Byte[] 出荷No;//24 出荷No          18 119
        Byte[] 梱包識別区分;//25 梱包識別区分     1 137
        Byte[] 梱包No;//26 梱包No          20 138
        Byte[] 出荷総梱数;//27 出荷総梱数      5 158
        Byte[] 出荷ケース数;//28 出荷ケース数    5 163
        Byte[] 出荷バラ混載箱数;//29 出荷バラ混載箱数  5 168
        Byte[] 商品コード区分;//30 商品コード区分   1 173
        Byte[] ＪＡＮコード;//31 ＪＡＮコード     13 174
        Byte[] 商品コード;//32 商品コード     8 187
        Byte[] オプション使用欄;//33 オプション使用欄   20 195
        Byte[] ＧＴＩＮ;//34 ＧＴＩＮ           14 215
        Byte[] 品名漢字;//35 品名漢字       20 229
        Byte[] 品名カナ;//36 品名カナ      25 249
        Byte[] 規格名漢字;//37 規格名漢字      20 274
        Byte[] 規格名カナ;//38 規格名カナ      25 294
        Byte[] 発注数;//39 発注数        6 319
        Byte[] 納品数;//40 納品数        6 325
        Byte[] 訂正理由区分;//41 訂正理由区分     2 331
        Byte[] 総額取引区分;//42 総額取引区分     1 333
        Byte[] 原単価_税抜_;//43 原単価(税抜 )   9 334
        Byte[] 原単価_税込_;//44 原単価(税込 )   9 343
        Byte[] 原価金額_税抜_;//45 原価金額(税抜 )  9 352
        Byte[] 原価金額_税込_;//46 原価金額(税込 )  9 361
        Byte[] 税額;//47 税額             9 370
        Byte[] 税区分; //48 税区分            9 379
        Byte[] 税率;//49 税率             4 380
        Byte[] 売単価_税抜_;//50 売単価（税抜  ）  7 384
        Byte[] 売単価_税込_;//51 売単価（税込）    7 391

        Byte[] 納品先店舗コード;//52 納品先店舗コード   3 398
        Byte[] 納品場所コード;//53 納品場所コード    1 401
        Byte[] 納品場所名漢字;//54 納品場所名漢字    6 402
        Byte[] 納品場所カナ;//55 納品場所カナ         6 408
        Byte[] センター経由区分;//56 センター経由区分   1 414
        Byte[] センターコード;//57 センターコード    5 415
        Byte[] 便区分;//58 便区分            1 420
        Byte[] カゴ車No;//59 カゴ車No          20 421
        Byte[] 梱包サイズ_縦_;//60 梱包サイズ(縦)      5 441
        Byte[] 梱包サイズ_高さ_;//61 梱包サイズ(高さ)     5 446
        Byte[] 梱包サイズ_横_;//62 梱包サイズ(横)      5 451
        Byte[] 梱包重量;//63 梱包重量           5 456
        Byte[] 重量識別区分;//64 重量識別区分     1 461 
        Byte[] 納入形態区分;//65 納入形態区分     1 462
        Byte[] 出荷単位区分;//66 出荷単位区分     2 463
        Byte[] 単位入数;//67 単位入数           6 465
        Byte[] 予備_数値_;//68 予備  （数値  ） 2 471
        Byte[] 予備;//69 予備             28 473

        //public ASNModel(string line) {
        //    this.データID = line.Substring(0, 3); //1 データID               3  1
        //    this.管理連番 = line.Substring(3, 13);//2 管理連番                13  4
        //    this.システム管理日付 = line.Substring(16, 8);//3 システム管理日付        8 17
        //    this.データ作成日 = line.Substring(24, 8);//4 データ作成日            8 25
        //    this.データ作成時刻 = line.Substring(32, 6);//5 データ作成時刻        6    33
        //    this.法人コード = line.Substring(38, 2);//6 法人コード           2   39
        //    this.店舗コード = line.Substring(40, 3);//7 店舗コード           3   41
        //    this.部門コード = line.Substring(43, 2);//8 部門コード           2   44
        //    this.仕入先コード = line.Substring(45, 6);//9 仕入先コード         6   46
        //    this.出荷業務仕入先コード = line.Substring(51, 6);//10 出荷業務仕入先コード    6 52
        //    this.伝票区分 = line.Substring(57, 2);//11 伝票区分               2 58
        //    this.伝票番号 = line.Substring(59, 8);//12 伝票番号               8 60
        //    this.行番号 = line.Substring(67, 2);//13 行番号                2 68
        //    this.元伝票番号 = line.Substring(69, 8);//14 元伝票番号              8 70
        //    this.発注日 = line.Substring(77, 8);//15 発注日                8 78
        //    this.納品予定日 = line.Substring(85, 8);//16 納品予定日              8 86
        //    this.入荷予定日 = line.Substring(93, 8);//17 入荷予定日          8 94
        //    this.入荷予定時刻 = line.Substring(101, 4);//18 入荷予定時刻         4 102
        //    this.出荷日 = line.Substring(105, 8);//19 出荷日                8 106
        //    this.発注形態区分 = line.Substring(113, 2);//20 発注形態区分         2 114
        //}

        public ASNModel( ASNHeadModel head, t_orderdata order)
        {
            this.head = head;
            this.entity = order;

            this.データID = head.データID ; //1 データID               3  1
            this.管理連番 = head.管理連番;  //2 管理連番                13  4
            this.システム管理日付 = head.システム管理日付; //3 システム管理日付        8 17
            this.データ作成日 = head.データ作成日;  //4 データ作成日            8 25
            this.データ作成時刻 = head.データ作成時刻;//5 データ作成時刻        6    33
            
            this.法人コード = Encoding.ASCII.GetBytes( order.法人コード.ToString( "D2") ); //6 法人コード           2   39
            this.店舗コード = Encoding.ASCII.GetBytes( order.店舗コード.ToString( "D3") ); //7 店舗コード           3   41
            this.部門コード = Encoding.ASCII.GetBytes( order.部門コード.ToString( "D2") ); //8 部門コード           2   44
            this.仕入先コード = Encoding.ASCII.GetBytes(order.仕入先コード.ToString("D6"));  //9 仕入先コード         6   46
            this.出荷業務仕入先コード = Encoding.ASCII.GetBytes(order.出荷業務仕入先コード.ToString("D6")); //10 出荷業務仕入先コード    6 52
            this.伝票区分 = Encoding.ASCII.GetBytes(order.伝票区分.ToString("D2")); //11 伝票区分               2 58
            
            this.伝票番号 = Encoding.ASCII.GetBytes(order.伝票番号.ToString("D8"));//12 伝票番号               8 60
            this.行番号 = Encoding.ASCII.GetBytes(order.行番号.ToString("D2")); //13 行番号                2 68
            this.元伝票番号 = Encoding.ASCII.GetBytes( "00000000");//14 元伝票番号              8 70
           
            this.発注日 = EDITxtHandler.DateToBytes( order.発注日 );//15 発注日                8 78
            this.納品予定日 = EDITxtHandler.DateToBytes(order.納品予定日); //16 納品予定日              8 86
            if( this.head.TotalQuantity >0)
            {
                this.入荷予定日 = EDITxtHandler.DateToBytes(order.納品日); //17 入荷予定日          8 94
            }
            else
            {
                this.入荷予定日 = EDITxtHandler.GetZeroedBytes( 8 ); //17 入荷予定日          8 94
            }

            this.入荷予定時刻 = EDITxtHandler.GetZeroedBytes(4);//18 入荷予定時刻         4 102
            this.出荷日 = EDITxtHandler.DateToBytes(order.出荷日);//19 出荷日                8 106
            this.発注形態区分 = Encoding.ASCII.GetBytes(order.発注形態区分.ToString("D2")); //20 発注形態区分         2 114


            this.入力区分 = Encoding.ASCII.GetBytes("0") ;//21 入力区分       1 116
            this.直送区分 = Encoding.ASCII.GetBytes("0"); //22 直送区分       1 117
            this.運送区分 = Encoding.ASCII.GetBytes("1"); //23 運送区分       1 118
            this.出荷No = Encoding.ASCII.GetBytes(order.出荷No.ToString("D18"));//24 出荷No          18 119
            this.梱包識別区分 = Encoding.ASCII.GetBytes("0"); //25 梱包識別区分     1 137
            this.梱包No = EDITxtHandler.GetZeroedBytes(20);  //26 梱包No          20 138
            if (this.head.TotalQuantity > 0)
            {
                this.出荷総梱数 = Encoding.ASCII.GetBytes("00001"); ;//27 出荷総梱数      5 158
            }
            else
            {
                this.出荷総梱数 = Encoding.ASCII.GetBytes("00000"); ;//27 出荷総梱数      5 158
            }

            this.出荷ケース数= EDITxtHandler.GetZeroedBytes(5); //28 出荷ケース数    5 163
            this.出荷バラ混載箱数 = EDITxtHandler.GetZeroedBytes(5); ;//29 出荷バラ混載箱数  5 168
            this.商品コード区分 = Encoding.ASCII.GetBytes(order.商品コード区分.ToString("D1"));//30 商品コード区分   1 173
            this.ＪＡＮコード = Encoding.ASCII.GetBytes(order.ＪＡＮコード.ToString("D13"));//31 ＪＡＮコード     13 174
            this.商品コード= Encoding.ASCII.GetBytes(order.商品コード.ToString("D8"));//32 商品コード     8 187
            this.オプション使用欄 = EDITxtHandler.GetSpacedBytes(20);//33 オプション使用欄   20 195
            this.ＧＴＩＮ = EDITxtHandler.GetSpacedBytes(14); //34 ＧＴＩＮ           14 215

            var jis = EncodingUtility.ConvertUtf8ToShiftJisBytes(order.品名漢字);
            this.品名漢字 = EDITxtHandler.PadLeftBytes(jis, 20); //35 品名漢字       20 229

            jis = EncodingUtility.ConvertUtf8ToShiftJisBytes(order.品名カナ);
            this.品名カナ = EDITxtHandler.PadLeftBytes(jis, 25);//36 品名カナ      25 249

            jis = EncodingUtility.ConvertUtf8ToShiftJisBytes(order.規格名漢字);
            this.規格名漢字 = EDITxtHandler.PadLeftBytes(jis, 20);//37 規格名漢字      20 274

            jis = EncodingUtility.ConvertUtf8ToShiftJisBytes(order.規格名カナ);
            this.規格名カナ = EDITxtHandler.PadLeftBytes(jis, 25);//38 規格名カナ      25 294
            this.発注数 = Encoding.ASCII.GetBytes(order.発注数量.ToString("D6"));//39 発注数        6 319
            // 納品数 = 納品口数*口数 ?
            this.納品数 = Encoding.ASCII.GetBytes(order.実際出荷数量.ToString("D6")); //40 納品数        6 325

            //tbd..
            this.訂正理由区分= Encoding.ASCII.GetBytes( 99.ToString("D2"));;//41 訂正理由区分     2 331

            this.総額取引区分 = Encoding.ASCII.GetBytes(order.総額取引区分.ToString("D1"));//42 総額取引区分     1 333
            // v99
            this.原単価_税抜_ = Encoding.ASCII.GetBytes((order.原単価_税抜_*100).ToString("D9")); //43 原単価(税抜 )   9 334
            // v99
            this.原単価_税込_ = Encoding.ASCII.GetBytes( Convert.ToInt32((order.原単価_税抜_ * (1+ order.税率 )* 100)).ToString("D9")); //44 原単価(税込 )   9 343
            this.原価金額_税抜_ = Encoding.ASCII.GetBytes(order.原価金額_税抜_.ToString("D9")); //45 原価金額(税抜 )  9 352
            this.原価金額_税込_ = Encoding.ASCII.GetBytes(Convert.ToInt32(order.原価金額_税込_).ToString("D9")); //46 原価金額(税込 )  9 361

            this.税額 = Encoding.ASCII.GetBytes( Convert.ToInt32(order.原価金額_税込_- order.原価金額_税抜_).ToString("D9"));//47 税額             9 370
            this.税区分 = Encoding.ASCII.GetBytes(order.税区分.ToString("D1"));  //48 税区分            1 379
            // 0.05 * 1000 => 50  50.toString("D4") => "0050"
            this.税率= Encoding.ASCII.GetBytes(Convert.ToInt32(order.税率 * 1000).ToString("D4")); //49 税率             4 380
            this.売単価_税抜_ = Encoding.ASCII.GetBytes(order.売単価_税抜_.ToString("D7")); //50 売単価（税抜  ）  7 384
            this.売単価_税込_ = Encoding.ASCII.GetBytes(Convert.ToInt32(order.売単価_税込_).ToString("D7")); //51 売単価（税込）    7 391


            this.納品先店舗コード = Encoding.ASCII.GetBytes(order.納品先店舗コード.ToString("D3")); //52 納品先店舗コード   3 398
            // it is char 
            this.納品場所コード = Encoding.ASCII.GetBytes(order.納品場所コード.ToString("D1")); ;//53 納品場所コード    1 401

            var jis1 = EncodingUtility.ConvertUtf8ToShiftJisBytes(order.納品場所名漢字);
            this.納品場所名漢字 = EDITxtHandler.PadLeftBytes(jis1, 6); //54 納品場所名漢字    6 402
            var jis2 = EncodingUtility.ConvertUtf8ToShiftJisBytes(order.納品場所名カナ);
            this.納品場所カナ = EDITxtHandler.PadLeftBytes(jis2, 6); //55 納品場所カナ         6 408
            this.センター経由区分 = Encoding.ASCII.GetBytes(order.センター経由区分.ToString("D1")); //56 センター経由区分   1 414
            this.センターコード = Encoding.ASCII.GetBytes(order.センターコード.ToString("D5")); //57 センターコード    5 415
            this.便区分 = new Byte[1] { 0x30 };//58 便区分            1 420
            this.カゴ車No = EDITxtHandler.GetZeroedBytes(20); //59 カゴ車No          20 421
            this.梱包サイズ_縦_ = EDITxtHandler.GetZeroedBytes(5); //60 梱包サイズ(縦)      5 441
            this.梱包サイズ_高さ_ = EDITxtHandler.GetZeroedBytes(5); //61 梱包サイズ(高さ)     5 446
            this.梱包サイズ_横_ = EDITxtHandler.GetZeroedBytes(5); //62 梱包サイズ(横)      5 451
            this.梱包重量 = EDITxtHandler.GetZeroedBytes(5); //63 梱包重量           5 456
            this.重量識別区分 = new Byte[1] { 0x30 }; //64 重量識別区分     1 461 
            this.納入形態区分 = new Byte[1] { 0x30 }; //65 納入形態区分     1 462
            this.出荷単位区分 = new Byte[2] { 0x30, 0x30 }; //66 出荷単位区分     2 463
            this.単位入数 = EDITxtHandler.GetZeroedBytes(6);//67 単位入数           6 465
            this.予備_数値_ = new Byte[2] { 0x30, 0x30 }; //68 予備  （数値  ） 2 471
            this.予備 = EDITxtHandler.GetSpacedBytes(28); //69 予備             28 473
            
        }

        public void Serialize(BinaryWriter bw)
        {
            bw.Write(this.ToBytes());
        }

        public Byte[] ToBytes()
        {
            List<Byte> line = new List<byte>(500);
            line.AddRange(this.データID );  
            line.AddRange(this.管理連番 );
            line.AddRange(this.システム管理日付 );
            line.AddRange( this.データ作成日 );
            line.AddRange( this.データ作成時刻 );
            line.AddRange( this.法人コード );
            line.AddRange( this.店舗コード );
            line.AddRange( this.部門コード );
            line.AddRange( this.仕入先コード );
            line.AddRange( this.出荷業務仕入先コード );
            line.AddRange( this.伝票区分 );
            line.AddRange( this.伝票番号 );
            line.AddRange( this.行番号 );
            line.AddRange( this.元伝票番号 );
            line.AddRange( this.発注日 );
            line.AddRange( this.納品予定日 );
            line.AddRange( this.入荷予定日 );
            line.AddRange( this.入荷予定時刻 );
            line.AddRange( this.出荷日 );

            line.AddRange( this.発注形態区分 );
            line.AddRange( this.入力区分 );
            line.AddRange( this.直送区分 );
            line.AddRange( this.運送区分 );
            line.AddRange( this.出荷No );
            line.AddRange( this.梱包識別区分 );
            line.AddRange( this.梱包No );
            line.AddRange( this.出荷総梱数 );
            line.AddRange( this.出荷ケース数 );
            line.AddRange( this.出荷バラ混載箱数 );
            line.AddRange( this.商品コード区分 );
            line.AddRange( this.ＪＡＮコード );
            line.AddRange( this.商品コード );
            line.AddRange( this.オプション使用欄 );
            line.AddRange( this.ＧＴＩＮ );
            line.AddRange( this.品名漢字 );
            line.AddRange( this.品名カナ );
            line.AddRange( this.規格名漢字 );
            line.AddRange( this.規格名カナ );
            line.AddRange( this.発注数 );
            line.AddRange( this.納品数 );
            line.AddRange( this.訂正理由区分 );
            line.AddRange( this.総額取引区分 );
            line.AddRange( this.原単価_税抜_ );
            line.AddRange( this.原単価_税込_ );
            line.AddRange( this.原価金額_税抜_ );
            line.AddRange( this.原価金額_税込_ );
            line.AddRange( this.税額 );
            line.AddRange( this.税区分 );
            line.AddRange( this.税率 );
            line.AddRange( this.売単価_税抜_ );
            line.AddRange( this.売単価_税込_ );

            line.AddRange( this.納品先店舗コード );
            line.AddRange( this.納品場所コード );
            line.AddRange( this.納品場所名漢字 );
            line.AddRange( this.納品場所カナ );
            line.AddRange( this.センター経由区分 );
            line.AddRange( this.センターコード );
            line.AddRange( this.便区分 );
            line.AddRange( this.カゴ車No );
            line.AddRange( this.梱包サイズ_縦_ );
            line.AddRange( this.梱包サイズ_高さ_ );
            line.AddRange( this.梱包サイズ_横_ );
            line.AddRange( this.梱包重量 );
            line.AddRange( this.重量識別区分 ); 
            line.AddRange( this.納入形態区分 );
            line.AddRange( this.出荷単位区分 );
            line.AddRange( this.単位入数 );
            line.AddRange( this.予備_数値_ );
            line.AddRange( this.予備 );

            Debug.Assert(line.Count == 500);

            line.AddRange(EDITxtHandler.NR);
            return line.ToArray();
        }

        /*
        public string GenerateShipNo() {
            int count = 0;
            using (var ctx = new GODDbContext())
            {
                var date = DateTime.Now.AddMonths(-6);
                count = (from t_orderdata o in ctx.t_orderdata
                         where o.ASN管理連番 > 0 && o.店舗コード == this.entity.店舗コード && o.法人コード == this.entity.法人コード && o.発注日 > date
                         group o by o.ASN管理連番 into g
                         select g
                     ).Count();
            }

            var s  = String.Format("{0}{1}{2}{3}{4}", this.entity.法人コード.ToString("D2"), this.entity.店舗コード.ToString("D3"), EDITxtHandler.出荷業務仕入先コード, "01", (count+1).ToString("D5"));
            return s;
        }
        */
    }
}
