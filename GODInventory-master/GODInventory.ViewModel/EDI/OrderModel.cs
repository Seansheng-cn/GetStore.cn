using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GODInventory.ViewModel.EDI
{
    using GODInventory.MyLinq;
    using MySql.Data.MySqlClient;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    public class OrderModel
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
        //11 店舗名カナ  15 99
        //12 仕入先コード 6 114
        //13 仕入先名漢字 20 120
        //14 仕入先名カナ 15 140
        //15 出荷業務仕入先コード 6 155
        //16 伝票区分   2 161
        //17 伝票番号   8 163
        //18 行番号    2 171
        //19 発注日    8 173
        //20 納品予定日  8 181
        //21 発注 データ有効期限 8 189
        //22 EDI発注区分    1 197
        //23 発注形態区分 2 198

        //24 発注形態名称漢字   6 200
        //25 予備  （数値  ） 2 206
        //26 本部発注区分 1 208
        //27 部門 コード 2 209
        //28 部門名漢字  20 211
        //29 部門名カナ  15 231
        //30 ラインコード 2 246
        //31 クラスコード 2 248
        //32 ロケーションコード  6 250
        //33 商品 コード区分   1 256
        //34 ＪＡＮコード     13 257
        //35 商品 コード     8 270
        //36 オプション使用欄   20 278
        //37 ＧＴＩＮ       14 298
        //38 品名漢字       20 312
        //39 品名 カナ      25 332
        //40 規格名漢字      20 357
        //41 規格名カナ  25 377

        //42 発注数        6 402
        //43 最小発注単位数量   6 408
        //44 発注単位名称漢字   8 414
        //45 発注単位名称カナ   4 422 
        //46 総額取引区分     1 426
        //47 原単価(税抜 )   9 427
        //48 原単価(税込 )   9 436
        //49 原価金額(税抜 )  9 445
        //50 原価金額(税込 )  9 454
        //51 税額             9 463
        //52 税区分        1 472
        //53 税率         4 473
        //54 売単価（税抜  ）  7 477
        //55 売単価（税込  ）  7 484
        //56 特価区分       1 491
        //57 PB区分       1 492
        //58 原価区分       1 493
        //59 用度品区分      1 494
        //60 納期回答区分     1 495
        //61 回答納期       8 496

        //62 色名 カナ      6 504
        //63 柄名 カナ      6 510
        //64 サイズ名カナ     5 516
        //65 広告 コード     8 521
        //66 伝票出力単位     3 529
        //67 納品先店舗コード   3 532
        //68 納品先店舗名漢字   20 535
        //69 納品先店舗名カナ   15 555
        //70 納品場所コード    1 570
        //71 納品場所名漢字    6 571
        //72 納品場所名カナ    6 577
        //73 便区分            6 583
        //74 センター経由区分   1 584
        //75 センターコード    5 585
        //76 センター名漢字    20 590
        //77 センター名カナ    15 610
        //78 予備             76 625

        Byte[] データID;   //1 データID       3 1
        Byte[] 管理連番;    //2 管理連番        13 4
        Byte[] システム管理日付;    //3 システム管理日付 8 17
        Byte[] データ作成日; //4 データ作成日      8 25
        Byte[] データ作成時刻; //5 データ作成時刻 6 33
        Byte[] 法人コード; //6 法人コード  2 39
        Byte[] 法人名漢字; //7 法人名漢字   20 41
        Byte[] 法人名カナ; //8 法人名カナ  15 61
        Byte[] 店舗コード; //9 店舗コード  3 76
        Byte[] 店舗名漢字; //10 店舗名漢字  20 79
        Byte[] 店舗名カナ; //11 店舗名カナ  15 99
        Byte[] 仕入先コード; //12 仕入先コード 6 114
        Byte[] 仕入先名漢字; //13 仕入先名漢字 20 120
        Byte[] 仕入先名カナ; //14 仕入先名カナ 15 140
        Byte[] 出荷業務仕入先コード; //15 出荷業務仕入先コード 6 155
        Byte[] 伝票区分; //16 伝票区分   2 161
        Byte[] 伝票番号; //17 伝票番号   8 163
        Byte[] 行番号; //18 行番号    2 171
        Byte[] 発注日; //19 発注日    8 173
        Byte[] 納品予定日; //20 納品予定日  8 181
        Byte[] 発注データ有効期限; //21 発注データ有効期限 8 189
        Byte[] EDI発注区分; //22 EDI発注区分    1 197
        Byte[] 発注形態区分; //23 発注形態区分 2 198

        Byte[] 発注形態名称漢字; //24 発注形態名称漢字   6 200
        Byte[] 予備_数値_; //25 予備  （数値  ） 2 206
        Byte[] 本部発注区分; //26 本部発注区分 1 208
        Byte[] 部門コード; //27 部門コード 2 209
        Byte[] 部門名漢字; //28 部門名漢字  20 211
        Byte[] 部門名カナ; //29 部門名カナ  15 231
        Byte[] ラインコード; //30 ラインコード 2 246
        Byte[] クラスコード; //31 クラスコード 2 248
        Byte[] ロケーションコード; //32 ロケーションコード  6 250
        Byte[] 商品コード区分; //33 商品コード区分   1 256
        Byte[] ＪＡＮコード; //34 ＪＡＮコード     13 257
        Byte[] 商品コード; //35 商品コード     8 270
        Byte[] オプション使用欄; //36 オプション使用欄   20 278
        Byte[] ＧＴＩＮ; //37 ＧＴＩＮ       14 298
        Byte[] 品名漢字; //38 品名漢字       20 312
        Byte[] 品名カナ; //39 品名カナ      25 332
        Byte[] 規格名漢字; //40 規格名漢字      20 357
        Byte[] 規格名カナ; //41 規格名カナ  25 377

        Byte[] 発注数量; //42 発注数        6 402
        Byte[] 最小発注単位数量; //43 最小発注単位数量   6 408
        Byte[] 発注単位名称漢字; //44 発注単位名称漢字   8 414
        Byte[] 発注単位名称カナ; //45 発注単位名称カナ   4 422 
        Byte[] 総額取引区分; //46 総額取引区分     1 426
        Byte[] 原単価_税抜_; //47 原単価(税抜 )   9 427
        Byte[] 原単価_税込_; //48 原単価(税込 )   9 436
        Byte[] 原価金額_税抜_; //49 原価金額(税抜 )  9 445
        Byte[] 原価金額_税込_; //50 原価金額(税込 )  9 454
        Byte[] 税額; //51 税額             9 463
        Byte[] 税区分; //52 税区分        1 472
        Byte[] 税率; //53 税率         4 473
        Byte[] 売単価_税抜_; //54 売単価（税抜  ）  7 477
        Byte[] 売単価_税込_; //55 売単価（税込  ）  7 484
        Byte[] 特価区分; //56 特価区分       1 491
        Byte[] PB区分; //57 PB区分       1 492
        Byte[] 原価区分; //58 原価区分       1 493
        Byte[] 用度品区分; //59 用度品区分      1 494
        Byte[] 納期回答区分; //60 納期回答区分     1 495
        Byte[] 回答納期; //61 回答納期       8 496

        Byte[] 色名カナ; //62 色名カナ      6 504
        Byte[] 柄名カナ; //63 柄名カナ      6 510
        Byte[] サイズ名カナ; //64 サイズ名カナ     5 516
        Byte[] 広告コード; //65 広告コード     8 521
        Byte[] 伝票出力単位; //66 伝票出力単位     3 529
        Byte[] 納品先店舗コード; //67 納品先店舗コード   3 532
        Byte[] 納品先店舗名漢字; //68 納品先店舗名漢字   20 535
        Byte[] 納品先店舗名カナ; //69 納品先店舗名カナ   15 555
        Byte[] 納品場所コード; //70 納品場所コード    1 570
        Byte[] 納品場所名漢字; //71 納品場所名漢字    6 571
        Byte[] 納品場所名カナ; //72 納品場所名カナ    6 577
        Byte[] 便区分; //73 便区分            6 583
        Byte[] センター経由区分; //74 センター経由区分   1 584
        Byte[] センターコード; //75 センターコード    5 585
        Byte[] センター名漢字; //76 センター名漢字    20 590
        Byte[] センター名カナ; //77 センター名カナ    15 610
        Byte[] 予備; //78 予備             76 625

        Byte[] nr;

        public short StoreCode { get; set; }
        public long JanCode { get; set; }

        public OrderModel(BinaryReader br)
        {
           
            this.データID = br.ReadBytes(3);   //1 データID       3 1
            this.管理連番 = br.ReadBytes( 13);    //2 管理連番        13 4
            this.システム管理日付 = br.ReadBytes( 8);    //3 システム管理日付 8 17
            this.データ作成日 = br.ReadBytes( 8); //4 データ作成日      8 25
            this.データ作成時刻 = br.ReadBytes( 6); //5 データ作成時刻 6 33
            this.法人コード = br.ReadBytes( 2); //6 法人コード  2 39
            this.法人名漢字 = br.ReadBytes( 20); //7 法人名漢字   20 41
            this.法人名カナ = br.ReadBytes( 15); //8 法人名カナ  15 61
            this.店舗コード = br.ReadBytes( 3); //9 店舗コード  3 76
            this.店舗名漢字 = br.ReadBytes( 20); //10 店舗名漢字  20 79
            this.店舗名カナ = br.ReadBytes( 15); //11 店舗名カナ  15 99
            this.仕入先コード = br.ReadBytes( 6); //12 仕入先コード 6 114
            this.仕入先名漢字 = br.ReadBytes( 20); //13 仕入先名漢字 20 120
            this.仕入先名カナ = br.ReadBytes( 15); //14 仕入先名カナ 15 140
            this.出荷業務仕入先コード = br.ReadBytes( 6); //15 出荷業務仕入先コード 6 155
            this.伝票区分 = br.ReadBytes( 2); //16 伝票区分   2 161
            this.伝票番号 = br.ReadBytes( 8); //17 伝票番号   8 163
            this.行番号 = br.ReadBytes( 2); //18 行番号    2 171
            this.発注日 = br.ReadBytes( 8); //19 発注日    8 173
            this.納品予定日 = br.ReadBytes( 8); //20 納品予定日  8 181
            this.発注データ有効期限 = br.ReadBytes( 8); //21 発注データ有効期限 8 189
            this.EDI発注区分 = br.ReadBytes( 1); //22 EDI発注区分    1 197
            this.発注形態区分 = br.ReadBytes( 2); //23 発注形態区分 2 198

            this.発注形態名称漢字 = br.ReadBytes( 6); //24 発注形態名称漢字   6 200
            this.予備_数値_ = br.ReadBytes( 2); //25 予備  （数値  ） 2 206
            this.本部発注区分 = br.ReadBytes( 1); //26 本部発注区分 1 208
            this.部門コード = br.ReadBytes( 2); //27 部門コード 2 209
            this.部門名漢字 = br.ReadBytes( 20); //28 部門名漢字  20 211
            this.部門名カナ = br.ReadBytes( 15); //29 部門名カナ  15 231
            this.ラインコード = br.ReadBytes( 2); //30 ラインコード 2 246
            this.クラスコード = br.ReadBytes( 2); //31 クラスコード 2 248
            this.ロケーションコード = br.ReadBytes( 6); //32 ロケーションコード  6 250
            this.商品コード区分 = br.ReadBytes( 1); //33 商品コード区分   1 256
            this.ＪＡＮコード = br.ReadBytes( 13); //34 ＪＡＮコード     13 257
            this.商品コード = br.ReadBytes( 8); //35 商品コード     8 270
            this.オプション使用欄 = br.ReadBytes( 20); //36 オプション使用欄   20 278
            this.ＧＴＩＮ = br.ReadBytes( 14); //37 ＧＴＩＮ       14 298
            this.品名漢字 = br.ReadBytes( 20); //38 品名漢字       20 312
            this.品名カナ = br.ReadBytes( 25); //39 品名カナ      25 332
            this.規格名漢字 = br.ReadBytes( 20); //40 規格名漢字      20 357
            this.規格名カナ = br.ReadBytes( 25); //41 規格名カナ  25 377

            this.発注数量 = br.ReadBytes( 6); //42 発注数        6 402
            this.最小発注単位数量 = br.ReadBytes( 6); //43 最小発注単位数量   6 408
            this.発注単位名称漢字 = br.ReadBytes( 8); //44 発注単位名称漢字   8 414
            this.発注単位名称カナ = br.ReadBytes( 4); //45 発注単位名称カナ   4 422 
            this.総額取引区分 = br.ReadBytes( 1); //46 総額取引区分     1 426
            this.原単価_税抜_ = br.ReadBytes( 9); //47 原単価(税抜 )   9 427
            this.原単価_税込_ = br.ReadBytes( 9); //48 原単価(税込 )   9 436
            this.原価金額_税抜_ = br.ReadBytes( 9); //49 原価金額(税抜 )  9 445
            this.原価金額_税込_ = br.ReadBytes( 9); //50 原価金額(税込 )  9 454
            this.税額 = br.ReadBytes( 9); //51 税額             9 463
            this.税区分 = br.ReadBytes( 1); //52 税区分        1 472
            this.税率 = br.ReadBytes( 4); //53 税率         4 473
            this.売単価_税抜_ = br.ReadBytes( 7); //54 売単価（税抜  ）  7 477
            this.売単価_税込_ = br.ReadBytes( 7); //55 売単価（税込  ）  7 484
            this.特価区分 = br.ReadBytes( 1); //56 特価区分       1 491
            this.PB区分 = br.ReadBytes( 1); //57 PB区分       1 492
            this.原価区分 = br.ReadBytes( 1); //58 原価区分       1 493
            this.用度品区分 = br.ReadBytes( 1); //59 用度品区分      1 494
            this.納期回答区分 = br.ReadBytes( 1); //60 納期回答区分     1 495
            this.回答納期 = br.ReadBytes( 8); //61 回答納期       8 496

            this.色名カナ = br.ReadBytes( 6); //62 色名カナ      6 504
            this.柄名カナ = br.ReadBytes( 6); //63 柄名カナ      6 510
            this.サイズ名カナ = br.ReadBytes( 5); //64 サイズ名カナ     5 516
            this.広告コード = br.ReadBytes( 8); //65 広告コード     8 521
            this.伝票出力単位 = br.ReadBytes( 3); //66 伝票出力単位     3 529
            this.納品先店舗コード = br.ReadBytes( 3); //67 納品先店舗コード   3 532
            this.納品先店舗名漢字 = br.ReadBytes( 20); //68 納品先店舗名漢字   20 535
            this.納品先店舗名カナ = br.ReadBytes( 15); //69 納品先店舗名カナ   15 555
            this.納品場所コード = br.ReadBytes( 1); //70 納品場所コード    1 570
            this.納品場所名漢字 = br.ReadBytes( 6); //71 納品場所名漢字    6 571
            this.納品場所名カナ = br.ReadBytes( 6); //72 納品場所名カナ    6 577
            this.便区分 = br.ReadBytes( 1); //73 便区分            6 583
            this.センター経由区分 = br.ReadBytes( 1); //74 センター経由区分   1 584
            this.センターコード = br.ReadBytes( 5); //75 センターコード    5 585
            this.センター名漢字 = br.ReadBytes( 20); //76 センター名漢字    20 590
            this.センター名カナ = br.ReadBytes( 15); //77 センター名カナ    15 610
            this.予備 = br.ReadBytes( 76); //78 予備             76 625
            this.nr = br.ReadBytes(2);

            this.StoreCode = Convert.ToInt16(Encoding.Default.GetString(this.店舗コード));
            this.JanCode = Convert.ToInt64(Encoding.ASCII.GetString(this.ＪＡＮコード));

            Debug.Assert(StoreCode > 0 && JanCode > 0);
            Debug.Assert(this.nr[0] == 0x0D && this.nr[1] == 0x0A);

        }

        public OrderModel(string line) {
            /*
            this.データID = line.Substring(0, 3);   //1 データID       3 1
            this.管理連番 = line.Substring(3, 13);    //2 管理連番        13 4
            this.システム管理日付 = line.Substring(16, 8);    //3 システム管理日付 8 17
            this.データ作成日 = line.Substring(24, 8); //4 データ作成日      8 25
            this.データ作成時刻 = line.Substring(32, 6); //5 データ作成時刻 6 33
            this.法人コード = line.Substring(38, 2); //6 法人コード  2 39
            this.法人名漢字 = line.Substring(40, 20); //7 法人名漢字   20 41
            this.法人名カナ = line.Substring(60, 15); //8 法人名カナ  15 61
            this.店舗コード = line.Substring(76, 3); //9 店舗コード  3 76
            this.店舗名漢字 = line.Substring(78, 20); //10 店舗名漢字  20 79
            this.店舗名カナ = line.Substring(98, 15); //11 店舗名カナ  15 99
            this.仕入先コード = line.Substring(113, 6); //12 仕入先コード 6 114
            this.仕入先名漢字 = line.Substring(119, 20); //13 仕入先名漢字 20 120
            this.仕入先名カナ = line.Substring(139, 15); //14 仕入先名カナ 15 140
            this.出荷業務仕入先コード = line.Substring(154, 6); //15 出荷業務仕入先コード 6 155
            this.伝票区分 = line.Substring(160, 2); //16 伝票区分   2 161
            this.伝票番号 = line.Substring(162, 8); //17 伝票番号   8 163
            this.行番号 = line.Substring(170, 2); //18 行番号    2 171
            this.発注日 = line.Substring(172, 8); //19 発注日    8 173
            this.納品予定日 = line.Substring(180, 8); //20 納品予定日  8 181
            this.発注データ有効期限 = line.Substring(188, 8); //21 発注データ有効期限 8 189
            this.EDI発注区分 = line.Substring(196, 1); //22 EDI発注区分    1 197
            this.発注形態区分 = line.Substring(197, 2); //23 発注形態区分 2 198

            this.発注形態名称漢字 = line.Substring(199, 6); //24 発注形態名称漢字   6 200
            this.予備数値 = line.Substring(205, 2); //25 予備  （数値  ） 2 206
            this.本部発注区分 = line.Substring(207, 1); //26 本部発注区分 1 208
            this.部門コード = line.Substring(208, 2); //27 部門コード 2 209
            this.部門名漢字 = line.Substring(210, 20); //28 部門名漢字  20 211
            this.部門名カナ = line.Substring(230, 15); //29 部門名カナ  15 231
            this.ラインコード = line.Substring(245, 2); //30 ラインコード 2 246
            this.クラスコード = line.Substring(247, 2); //31 クラスコード 2 248
            this.ロケーションコード = line.Substring(249, 6); //32 ロケーションコード  6 250
            this.商品コード区分 = line.Substring(255, 1); //33 商品コード区分   1 256
            this.ＪＡＮコード = line.Substring(256, 13); //34 ＪＡＮコード     13 257
            this.商品コード = line.Substring(269, 8); //35 商品コード     8 270
            this.オプション使用欄 = line.Substring(277, 20); //36 オプション使用欄   20 278
            this.ＧＴＩＮ = line.Substring(297, 14); //37 ＧＴＩＮ       14 298
            this.品名漢字 = line.Substring(311, 20); //38 品名漢字       20 312
            this.品名カナ = line.Substring(331, 25); //39 品名カナ      25 332
            this.規格名漢字 = line.Substring(356, 20); //40 規格名漢字      20 357
            this.規格名カナ = line.Substring(376, 25); //41 規格名カナ  25 377

            this.発注数量 = line.Substring(401, 6); //42 発注数        6 402
            this.最小発注単位数量 = line.Substring(407, 6); //43 最小発注単位数量   6 408
            this.発注単位名称漢字 = line.Substring(413, 8); //44 発注単位名称漢字   8 414
            this.発注単位名称カナ = line.Substring(421, 4); //45 発注単位名称カナ   4 422 
            this.総額取引区分 = line.Substring(425, 1); //46 総額取引区分     1 426
            this.原単価_税抜_ = line.Substring(426, 9); //47 原単価(税抜 )   9 427
            this.原単価_税込_ = line.Substring(435, 9); //48 原単価(税込 )   9 436
            this.原価金額_税抜_ = line.Substring(444, 9); //49 原価金額(税抜 )  9 445
            this.原価金額_税込_ = line.Substring(453, 9); //50 原価金額(税込 )  9 454
            this.税額 = line.Substring(462, 9); //51 税額             9 463
            this.税区分 = line.Substring(471, 1); //52 税区分        1 472
            this.税率 = line.Substring(472, 4); //53 税率         4 473
            this.売単価_税抜_ = line.Substring(476, 7); //54 売単価（税抜  ）  7 477
            this.売単価_税込_ = line.Substring(483, 7); //55 売単価（税込  ）  7 484
            this.特価区分 = line.Substring(490, 1); //56 特価区分       1 491
            this.PB区分 = line.Substring(491, 1); //57 PB区分       1 492
            this.原価区分 = line.Substring(492, 1); //58 原価区分       1 493
            this.用度品区分 = line.Substring(493, 1); //59 用度品区分      1 494
            this.納期回答区分 = line.Substring(494, 1); //60 納期回答区分     1 495
            this.回答納期 = line.Substring(495, 8); //61 回答納期       8 496

            this.色名カナ = line.Substring(503, 6); //62 色名カナ      6 504
            this.柄名カナ = line.Substring(509, 6); //63 柄名カナ      6 510
            this.サイズ名カナ = line.Substring(515, 5); //64 サイズ名カナ     5 516
            this.広告コード = line.Substring(520, 8); //65 広告コード     8 521
            this.伝票出力単位 = line.Substring(528, 3); //66 伝票出力単位     3 529
            this.納品先店舗コード = line.Substring(531, 3); //67 納品先店舗コード   3 532
            this.納品先店舗名漢字 = line.Substring(534, 20); //68 納品先店舗名漢字   20 535
            this.納品先店舗名カナ = line.Substring(554, 15); //69 納品先店舗名カナ   15 555
            this.納品場所コード = line.Substring(569, 1); //70 納品場所コード    1 570
            this.納品場所名漢字 = line.Substring(570, 6); //71 納品場所名漢字    6 571
            this.納品場所名カナ = line.Substring(576, 6); //72 納品場所名カナ    6 577
            this.便区分 = line.Substring(582, 1); //73 便区分            6 583
            this.センター経由区分 = line.Substring(583, 1); //74 センター経由区分   1 584
            this.センターコード = line.Substring(584, 5); //75 センターコード    5 585
            this.センター名漢字 = line.Substring(589, 20); //76 センター名漢字    20 590
            this.センター名カナ = line.Substring(609, 15); //77 センター名カナ    15 610
            this.予備 = line.Substring(624, 76); //78 予備             76 625
            */
        }

        public t_orderdata ConverToEntity() {
            var now = DateTime.Now;
            var orderdata = new t_orderdata();

            orderdata.受注日 = DateTime.Now;
            orderdata.受注時刻 = new TimeSpan(now.Hour, now.Minute, now.Second);

            orderdata.法人コード = Convert.ToInt16(Encoding.ASCII.GetString(this.法人コード));
            orderdata.法人名漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.法人名漢字).Trim();
            orderdata.法人名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.法人名カナ).Trim();

            orderdata.店舗コード = Convert.ToInt16(Encoding.Default.GetString(this.店舗コード));
            orderdata.店舗名漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.店舗名漢字).Trim();
            orderdata.店舗名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.店舗名カナ).Trim();

            orderdata.仕入先コード = Convert.ToInt32(Encoding.Default.GetString(this.仕入先コード));
            orderdata.仕入先名漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.仕入先名漢字).Trim();
            orderdata.仕入先名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.仕入先名カナ).Trim();
            orderdata.出荷業務仕入先コード = Convert.ToInt32(Encoding.ASCII.GetString(this.出荷業務仕入先コード));
            orderdata.伝票区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.伝票区分));

            orderdata.伝票番号 = Convert.ToInt32( Encoding.ASCII.GetString(this.伝票番号) );
            orderdata.行番号 = Convert.ToInt16(Encoding.ASCII.GetString(this.行番号));
            orderdata.発注日 = DateTime.ParseExact( Encoding.Default.GetString(this.発注日), "yyyyMMdd", CultureInfo.InvariantCulture);
            orderdata.納品予定日 = DateTime.ParseExact(Encoding.Default.GetString(this.納品予定日), "yyyyMMdd", CultureInfo.InvariantCulture);
            orderdata.発注データ有効期限 = DateTime.ParseExact(Encoding.Default.GetString(this.発注データ有効期限), "yyyyMMdd", CultureInfo.InvariantCulture);
            orderdata.EDI発注区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.EDI発注区分));
            orderdata.発注形態区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.発注形態区分));


            orderdata.発注形態名称漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.発注形態名称漢字).Trim();
            orderdata.予備_数値_ = Convert.ToInt32(Encoding.ASCII.GetString(this.予備_数値_));
            orderdata.本部発注区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.本部発注区分));
            orderdata.部門コード = Convert.ToInt16(Encoding.ASCII.GetString(this.部門コード));
            orderdata.部門名漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.部門名漢字).Trim();
            orderdata.部門名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.部門名カナ).Trim();
            orderdata.ラインコード = Convert.ToInt32(Encoding.ASCII.GetString(this.ラインコード));
            orderdata.クラスコード = Convert.ToInt32(Encoding.ASCII.GetString(this.クラスコード));
            orderdata.ロケーションコード = Convert.ToInt32(Encoding.ASCII.GetString(this.ロケーションコード));
            orderdata.商品コード区分 = Convert.ToInt32(Encoding.ASCII.GetString(this.商品コード区分));
            orderdata.ＪＡＮコード = Convert.ToInt64(Encoding.ASCII.GetString(this.ＪＡＮコード));
            orderdata.商品コード = Convert.ToInt32(Encoding.ASCII.GetString(this.商品コード));
            orderdata.オプション使用欄 = EncodingUtility.ConvertShiftJisToUtf8(this.オプション使用欄).Trim(); //36 オプション使用欄   20 278
            orderdata.ＧＴＩＮ = ""; //37 ＧＴＩＮ       14 298
            orderdata.品名漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.品名漢字).Trim();
            orderdata.品名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.品名カナ).Trim();
            orderdata.規格名漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.規格名漢字).Trim();
            orderdata.規格名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.規格名カナ).Trim();


            orderdata.発注数量 = Convert.ToInt32(Encoding.ASCII.GetString(this.発注数量))/10;

            orderdata.最小発注単位数量 = Convert.ToInt32(Encoding.ASCII.GetString(this.最小発注単位数量));
            orderdata.発注単位名称漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.発注単位名称漢字).Trim();
            orderdata.発注単位名称カナ = EncodingUtility.ConvertShiftJisToUtf8(this.発注単位名称カナ).Trim();
            orderdata.総額取引区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.総額取引区分));
            // tbd...
            orderdata.原単価_税抜_ = Convert.ToInt32(Encoding.ASCII.GetString(this.原単価_税抜_))/100;
            orderdata.原単価_税込_ = Convert.ToInt32(Encoding.ASCII.GetString(this.原単価_税込_))/100.0; //48 原単価(税込 )   9 436
            orderdata.原価金額_税抜_ = Convert.ToInt32(Encoding.ASCII.GetString(this.原価金額_税抜_));
            orderdata.原価金額_税込_ = Convert.ToInt32(Encoding.ASCII.GetString(this.原価金額_税込_));

            orderdata.税額 = Convert.ToDouble(Encoding.ASCII.GetString(this.税額));
            orderdata.税区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.税区分)); 
            orderdata.税率 = Convert.ToDouble(Encoding.ASCII.GetString(this.税率))/1000;

            orderdata.売単価_税抜_ = Convert.ToInt32(Encoding.ASCII.GetString(this.売単価_税抜_));
            orderdata.売単価_税込_ = Convert.ToInt32(Encoding.ASCII.GetString(this.売単価_税込_));
            orderdata.特価区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.特価区分));
            orderdata.PB区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.PB区分));
            orderdata.原価区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.原価区分));
            orderdata.用度品区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.用度品区分));
            orderdata.納期回答区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.納期回答区分));
            orderdata.回答納期 = "00000000";

            orderdata.納品先店舗コード = Convert.ToInt16(Encoding.ASCII.GetString(this.納品先店舗コード) );
            orderdata.納品先店舗名漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.納品先店舗名漢字).Trim();
            orderdata.納品場所名漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.納品場所名漢字).Trim();

            orderdata.色名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.色名カナ).Trim();
            orderdata.柄名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.柄名カナ).Trim();
            orderdata.サイズ名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.サイズ名カナ).Trim();
            orderdata.広告コード = Convert.ToInt32(Encoding.ASCII.GetString(this.広告コード));
            orderdata.伝票出力単位 = Convert.ToInt16(Encoding.ASCII.GetString(this.伝票出力単位));
            orderdata.納品先店舗コード = Convert.ToInt16(Encoding.ASCII.GetString(this.納品先店舗コード));
            orderdata.納品先店舗名漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.納品先店舗名漢字).Trim();
            orderdata.納品先店舗名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.納品先店舗名カナ).Trim();
            orderdata.納品場所コード = Convert.ToInt16(Encoding.ASCII.GetString(this.納品場所コード));
            orderdata.納品場所名漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.納品場所名漢字).Trim();
            orderdata.納品場所名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.納品場所名カナ).Trim();
            orderdata.便区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.便区分));
            orderdata.センター経由区分 = Convert.ToInt16(Encoding.ASCII.GetString(this.センター経由区分));
            orderdata.センターコード = Convert.ToInt32(Encoding.ASCII.GetString(this.センターコード));
            orderdata.センター名漢字 = EncodingUtility.ConvertShiftJisToUtf8(this.センター名漢字).Trim();
            orderdata.センター名カナ = EncodingUtility.ConvertShiftJisToUtf8(this.センター名カナ).Trim();

            return orderdata;

        }
        public t_orderdata ConverToEntity(t_shoplist shop, t_itemlist item)
        {
            var orderdata = ConverToEntity();
            
            orderdata.口数 = item.PT入数;
            orderdata.重量 = (int)( item.単品重量 * orderdata.発注数量);
            orderdata.ジャンル = item.ジャンル;
            orderdata.単位 = item.単位;
            orderdata.自社コード = item.自社コード;
            orderdata.実際配送担当 = shop.配送担当;
            orderdata.実際出荷数量 = orderdata.発注数量;
            orderdata.県別 = shop.県別;

            if (orderdata.実際配送担当=="MKL" && (orderdata.ジャンル == 1 || orderdata.ジャンル == 6))
            {
                orderdata.実際配送担当 = "丸健";
            }

            return orderdata;
        }

        public CustomMySqlParameters ToSqlArguments(t_shoplist shop, t_itemlist item)
        {
            //`発注日`, `受注日`, `出荷日`, `納品日`, `店舗コード`, `店舗名漢字`, `社内伝番`, `行数`, `最大行数`, `伝票番号`, `ダブリ`, 
            //`在庫状態`, `キャンセル`, `キャンセル時刻`, `ジャンル`, `ＪＡＮコード`, `商品コード`, `品名漢字`, `規格名漢字`, `発注数量`, 
            //`実際出荷数量`, `口数`, `納品口数`, `重量`, `単位`, `原単価(税抜)`, `原価金額(税抜)`, `納品原価金額`, `売単価（税抜）`, `一旦保留`, 
            //`実際配送担当`, `配送担当受信`, `配送担当受信時刻`, `専務受信`, `専務受信時刻`, `納品指示`, `納品場所コード`, `納品場所名漢字`, 
            //`受領`, `備考`, `週目`, `受領確認`, `受領数量`, `受領金額`, `受領差異数量`, `受領差異金額`, `受注時刻`, `法人コード`, 
            //`法人名漢字`, `法人名カナ`, `店舗名カナ`, `仕入先コード`, `仕入先名漢字`, `仕入先名カナ`, `出荷業務仕入先コード`, 
            //`伝票区分`, `行番号`, `納品予定日`, `発注データ有効期限`, `EDI発注区分`, `発注形態区分`, `発注形態名称漢字`, 
            //`予備（数値）`, `本部発注区分`, `部門コード`, `部門名漢字`, `部門名カナ`, `ラインコード`, `クラスコード`, `商品コード区分`, 
            //`ロケーションコード`, `オプション使用欄`, `ＧＴＩＮ`, `品名カナ`, `規格名カナ`, `最小発注単位数量`, `発注単位名称漢字`, 
            //`発注単位名称カナ`, `総額取引区分`, `原単価(税込)`, `原価金額(税込)`, `税額`, `税区分`, `税率`, `売単価（税込）`, `特価区分`, 
            //`PB区分`, `原価区分`, `用度品区分`, `納期回答区分`, `回答納期`, `色名カナ`, `柄名カナ`, `サイズ名カナ`, `広告コード`, `伝票出力単位`, 
            //`納品先店舗コード`, `納品先店舗名漢字`, `納品先店舗名カナ`, `納品場所名カナ`, `便区分`, `センター経由区分`, `センターコード`, 
            //`センター名漢字`, `センター名カナ
/*
            !受注時刻 = tTimeJ
                    !法人コード = Cells(i, 3).Value
                    !法人名漢字 = Cells(i, 4).Value
                    !法人名カナ = Cells(i, 5).Value
                    !店舗コード = Cells(i, 6).Value
                    !店舗名漢字 = Cells(i, 7).Value
                    !店舗名カナ = Cells(i, 8).Value
                    !仕入先コード = Cells(i, 9).Value
                    !仕入先名漢字 = Cells(i, 10).Value
                    !仕入先名カナ = Cells(i, 11).Value
                    !出荷業務仕入先コード = Cells(i, 12).Value
                    !伝票区分 = Cells(i, 13).Value
                    !伝票番号 = Cells(i, 14).Value
                    !行番号 = Cells(i, 15).Value
                    tDateS = Left(Cells(i, 16).Value, 4) & "/" & Mid(Cells(i, 16).Value, 5, 2) & "/" & Right(Cells(i, 16).Value, 2)
                    !発注日 = CDate(tDateS)
                    tDateS = Left(Cells(i, 17).Value, 4) & "/" & Mid(Cells(i, 17).Value, 5, 2) & "/" & Right(Cells(i, 17).Value, 2)
                    !納品予定日 = CDate(tDateS)
                    tDateS = Left(Cells(i, 18).Value, 4) & "/" & Mid(Cells(i, 18).Value, 5, 2) & "/" & Right(Cells(i, 18).Value, 2)
                    !発注データ有効期限 = CDate(tDateS)
                    !EDI発注区分 = Cells(i, 19).Value
                    !発注形態区分 = Cells(i, 20).Value
                    !発注形態名称漢字 = Cells(i, 21).Value
                    ![予備(数値)] = Cells(i, 22).Value
                    !本部発注区分 = Cells(i, 23).Value
                    !部門コード = Cells(i, 24).Value
                    !部門名漢字 = Cells(i, 25).Value
                    !部門名カナ = Cells(i, 26).Value
                    !ラインコード = Cells(i, 27).Value
                    !クラスコード = Cells(i, 28).Value
                    !ロケーションコード = Cells(i, 29).Value
                    !商品コード区分 = Cells(i, 30).Value
                    !JANコード = Cells(i, 31).Value
                    !商品コード = Cells(i, 32).Value
                    !オプション使用欄 = Cells(i, 33).Value
                    !GTIN = Cells(i, 34).Value
                    !品名漢字 = Cells(i, 35).Value
                    !品名カナ = Cells(i, 36).Value
                    !規格名漢字 = Cells(i, 37).Value
                    !規格名カナ = Cells(i, 38).Value
                    !発注数量 = Cells(i, 39).Value
                    !最小発注単位数量 = Cells(i, 40).Value
                    !発注単位名称漢字 = Cells(i, 41).Value
                    !発注単位名称カナ = Cells(i, 42).Value
                    !総額取引区分 = Cells(i, 43).Value
                    ![原単価(税抜)] = Cells(i, 44).Value
                    ![原単価(税込)] = Cells(i, 45).Value
                    ![原価金額(税抜)] = Cells(i, 46).Value
                    ![原価金額(税込)] = Cells(i, 47).Value
                    !税額 = Cells(i, 48).Value
                    !税区分 = Cells(i, 49).Value
                    !税率 = Cells(i, 50).Value
                    ![売単価(税抜)] = Cells(i, 51).Value
                    ![売単価(税込)] = Cells(i, 52).Value
                    !特価区分 = Cells(i, 53).Value
                    !PB区分 = Cells(i, 54).Value
                    !原価区分 = Cells(i, 55).Value
                    !用度品区分 = Cells(i, 56).Value
                    !納期回答区分 = Cells(i, 57).Value
                    !回答納期 = Cells(i, 58).Value
                    !色名カナ = Cells(i, 59).Value
                    !柄名カナ = Cells(i, 60).Value
                    !サイズ名カナ = Cells(i, 61).Value
                    !広告コード = Cells(i, 62).Value
                    !伝票出力単位 = Cells(i, 63).Value
                    !納品先店舗コード = Cells(i, 64).Value
                    !納品先店舗名漢字 = Cells(i, 65).Value
                    !納品先店舗名カナ = Cells(i, 66).Value
                    !納品場所コード = Cells(i, 67).Value
                    !納品場所名漢字 = Cells(i, 68).Value
                    !納品場所名カナ = Cells(i, 69).Value
                    !便区分 = Cells(i, 70).Value
                    !センター経由区分 = Cells(i, 71).Value
                    !センターコード = Cells(i, 72).Value
                    !センター名漢字 = Cells(i, 73).Value
                    !センター名カナ = Cells(i, 74).Value
                    */
            t_orderdata o = ConverToEntity(shop, item);
            string sql = @"INSERT INTO `t_orderdata`(
`発注日`, `受注日`, `受注時刻`,  `店舗コード`, `店舗名漢字`, 
`伝票番号`, `ＪＡＮコード`, `商品コード`, `品名漢字`, `規格名漢字`, 
`発注数量`, `原単価(税抜)`, `原価金額(税抜)`, `納品原価金額`, `売単価（税抜）`,
`納品場所コード`, `納品場所名漢字`, `法人コード`, `法人名漢字`,`法人名カナ`,
`店舗名カナ`, `仕入先コード`, `仕入先名漢字`, `仕入先名カナ`, `出荷業務仕入先コード`, 
`伝票区分`, `行番号`, `納品予定日`, `発注データ有効期限`, `EDI発注区分`, 
`発注形態区分`, `発注形態名称漢字`, `予備（数値）`, `本部発注区分`, `部門コード`, 
`部門名漢字`, `部門名カナ`, `ラインコード`, `クラスコード`, `商品コード区分`, 
`ロケーションコード`, `オプション使用欄`, `ＧＴＩＮ`, `品名カナ`, `規格名カナ`, 
`最小発注単位数量`, `発注単位名称漢字`, `発注単位名称カナ`, `総額取引区分`, `原単価(税込)`, 
`原価金額(税込)`, `税額`, `税区分`, `税率`, `売単価（税込）`, 
`特価区分`, `PB区分`, `原価区分`, `用度品区分`, `納期回答区分`, 
`回答納期`, `色名カナ`, `柄名カナ`, `サイズ名カナ`, `広告コード`, 
`伝票出力単位`, `納品先店舗コード`, `納品先店舗名漢字`, `納品先店舗名カナ`, `納品場所名カナ`, 
`便区分`, `センター経由区分`, `センターコード`, `センター名漢字`, `センター名カナ`,
`実際配送担当`, `配送担当受信`,`口数`,`重量`,`単位`,
`ジャンル`) 
VALUES (
@p1, @p2, @p3, @p4, @p5, 
@p6, @p7, @p8, @p9, @p10, 
@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, 
@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30, 
@p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, @p39, @p40, 
@p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, 
@p51, @p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, 
@p61, @p62, @p63, @p64, @p65, @p66, @p67, @p68, @p69, @p70, 
@p71, @p72, @p73, @p74, @p75, @p76, @p77, @p78, @p79, @p80,
@p81);";

            MySqlParameter[] parameters = { new MySqlParameter("@p1", o.発注日), new MySqlParameter("@p2", o.受注日), new MySqlParameter("@p3", o.受注時刻), new MySqlParameter("@p4", o.店舗コード), new MySqlParameter("@p5", o.店舗名漢字),
       new MySqlParameter("@p6", o.伝票番号), new MySqlParameter("@p7", o.ＪＡＮコード), new MySqlParameter("@p8", o.商品コード), new MySqlParameter("@p9", o.品名漢字),new MySqlParameter("@p10", o.規格名漢字),
       new MySqlParameter("@p11", o.発注数量), new MySqlParameter("@p12", o.原単価_税抜_), new MySqlParameter("@p13", o.原価金額_税抜_), new MySqlParameter("@p14", o.納品原価金額),new MySqlParameter("@p15", o.売単価_税抜_),
       new MySqlParameter("@p16", o.納品場所コード), new MySqlParameter("@p17", o.納品場所名漢字), new MySqlParameter("@p18", o.法人コード), new MySqlParameter("@p19", o.法人名漢字),new MySqlParameter("@p20", o.法人名カナ),
       new MySqlParameter("@p21", o.店舗名カナ), new MySqlParameter("@p22", o.仕入先コード), new MySqlParameter("@p23", o.仕入先名漢字), new MySqlParameter("@p24", o.仕入先名カナ),new MySqlParameter("@p25", o.出荷業務仕入先コード),
       new MySqlParameter("@p26", o.伝票区分), new MySqlParameter("@p27", o.行番号), new MySqlParameter("@p28", o.納品予定日), new MySqlParameter("@p29", o.発注データ有効期限),new MySqlParameter("@p30", o.EDI発注区分),
       new MySqlParameter("@p31", o.発注形態区分), new MySqlParameter("@p32", o.発注形態名称漢字), new MySqlParameter("@p33", o.予備_数値_), new MySqlParameter("@p34", o.本部発注区分),new MySqlParameter("@p35", o.部門コード),
       new MySqlParameter("@p36", o.部門名漢字), new MySqlParameter("@p37", o.部門名カナ), new MySqlParameter("@p38", o.ラインコード), new MySqlParameter("@p39", o.クラスコード),new MySqlParameter("@p40", o.商品コード区分),
       new MySqlParameter("@p41", o.ロケーションコード), new MySqlParameter("@p42", o.オプション使用欄), new MySqlParameter("@p43", o.ＧＴＩＮ), new MySqlParameter("@p44", o.品名カナ),new MySqlParameter("@p45", o.規格名カナ),
       new MySqlParameter("@p46", o.最小発注単位数量), new MySqlParameter("@p47", o.発注単位名称漢字), new MySqlParameter("@p48", o.発注単位名称カナ), new MySqlParameter("@p49", o.総額取引区分),new MySqlParameter("@p50", o.原単価_税込_),
       new MySqlParameter("@p51", o.原価金額_税込_), new MySqlParameter("@p52", o.税額), new MySqlParameter("@p53", o.税区分), new MySqlParameter("@p54", o.税率),new MySqlParameter("@p55", o.売単価_税込_),
       new MySqlParameter("@p56", o.特価区分), new MySqlParameter("@p57", o.PB区分), new MySqlParameter("@p58", o.原価区分), new MySqlParameter("@p59", o.用度品区分),new MySqlParameter("@p60", o.納期回答区分),
       new MySqlParameter("@p61", o.回答納期), new MySqlParameter("@p62", o.色名カナ), new MySqlParameter("@p63", o.柄名カナ), new MySqlParameter("@p64", o.サイズ名カナ),new MySqlParameter("@p65", o.広告コード),
       new MySqlParameter("@p66", o.伝票出力単位), new MySqlParameter("@p67", o.納品先店舗コード), new MySqlParameter("@p68", o.納品先店舗名漢字), new MySqlParameter("@p69", o.納品先店舗名カナ),new MySqlParameter("@p70", o.納品場所名カナ),
       new MySqlParameter("@p71", o.便区分), new MySqlParameter("@p72", o.センター経由区分), new MySqlParameter("@p73", o.センターコード), new MySqlParameter("@p74", o.センター名漢字),new MySqlParameter("@p75", o.センター名カナ),
       new MySqlParameter("@p76", o.実際配送担当),new MySqlParameter("@p77", o.配送担当受信),new MySqlParameter("@p78", o.口数),new MySqlParameter("@p79", o.重量),new MySqlParameter("@p80", o.単位),
       new MySqlParameter("@p81", o.ジャンル)     };

            return new CustomMySqlParameters(parameters, sql);

        }

        public string ToRawSql(t_shoplist shop, t_itemlist item)
        {
            var isoDateTimeFormat = CultureInfo.InvariantCulture.DateTimeFormat;
            t_orderdata o = ConverToEntity(shop, item);
            string format = @"INSERT INTO `t_orderdata`(
`発注日`, `受注日`, `受注時刻`,  `店舗コード`, `店舗名漢字`, 
`伝票番号`, `ＪＡＮコード`, `商品コード`, `品名漢字`, `規格名漢字`, 
`発注数量`, `原単価(税抜)`, `原価金額(税抜)`, `納品原価金額`, `売単価（税抜）`,
`納品場所コード`, `納品場所名漢字`, `法人コード`, `法人名漢字`,`法人名カナ`,
`店舗名カナ`, `仕入先コード`, `仕入先名漢字`, `仕入先名カナ`, `出荷業務仕入先コード`, 
`伝票区分`, `行番号`, `納品予定日`, `発注データ有効期限`, `EDI発注区分`, 
`発注形態区分`, `発注形態名称漢字`, `予備（数値）`, `本部発注区分`, `部門コード`, 
`部門名漢字`, `部門名カナ`, `ラインコード`, `クラスコード`, `商品コード区分`, 
`ロケーションコード`, `オプション使用欄`, `ＧＴＩＮ`, `品名カナ`, `規格名カナ`, 
`最小発注単位数量`, `発注単位名称漢字`, `発注単位名称カナ`, `総額取引区分`, `原単価(税込)`, 
`原価金額(税込)`, `税額`, `税区分`, `税率`, `売単価（税込）`, 
`特価区分`, `PB区分`, `原価区分`, `用度品区分`, `納期回答区分`, 
`回答納期`, `色名カナ`, `柄名カナ`, `サイズ名カナ`, `広告コード`, 
`伝票出力単位`, `納品先店舗コード`, `納品先店舗名漢字`, `納品先店舗名カナ`, `納品場所名カナ`, 
`便区分`, `センター経由区分`, `センターコード`, `センター名漢字`, `センター名カナ`,
`実際配送担当`, `配送担当受信`,`口数`,`重量`,`単位`,
`ジャンル`,`自社コード`,`実際出荷数量`,`県別`,`Status`) 
VALUES ({0}
'{1:yyyy-MM-dd}','{2:yyyy-MM-dd}','{3:HH:mm:ss}',{4},'{5}',
{6},{7},{8},'{9}','{10}',
{11},{12},{13},{14},{15},{16},'{17}',{18},'{19}','{20}',
'{21}',{22},'{23}','{24}',{25},{26},{27},'{28:yyyy-MM-dd}','{29:yyyy-MM-dd}',{30},
{31},'{32}',{33},{34},{35},'{36}','{37}',{38},{39},{40},
{41},'{42}','{43}','{44}','{45}',{46},'{47}','{48}',{49},{50},
{51},{52},{53},{54},{55},{56},{57},{58},{59},{60},
'{61}','{62}','{63}','{64}',{65},{66},{67},'{68}','{69}','{70}',
{71},{72},{73},'{74}','{75}','{76}',{77},{78},{79},'{80}',
{81},{82},{83},'{84}',{85});";
            var now = DateTime.Now;
            var fazhuri = o.発注日.ToString(isoDateTimeFormat.UniversalSortableDateTimePattern);
            var souzhuri = now.ToString(isoDateTimeFormat.UniversalSortableDateTimePattern);
            var shouzhushike = now.ToString( "HH:mm:ss");
            var napinyudingri = o.納品予定日.ToString(isoDateTimeFormat.UniversalSortableDateTimePattern);
            
            var qixian = DateTime.ParseExact(Encoding.Default.GetString(this.発注データ有効期限), "yyyyMMdd", CultureInfo.InvariantCulture).ToString(isoDateTimeFormat.UniversalSortableDateTimePattern);
            return String.Format(format, "", o.発注日, now, now, o.店舗コード, o.店舗名漢字,
                o.伝票番号, o.ＪＡＮコード, o.商品コード, o.品名漢字, o.規格名漢字, 
                o.発注数量, o.原単価_税抜_, o.原価金額_税抜_, o.納品原価金額, o.売単価_税抜_,
                o.納品場所コード, o.納品場所名漢字, o.法人コード, o.法人名漢字,o.法人名カナ,
                
                o.店舗名カナ, o.仕入先コード, o.仕入先名漢字, o.仕入先名カナ, o.出荷業務仕入先コード,
                o.伝票区分, o.行番号, o.納品予定日, o.発注データ有効期限, o.EDI発注区分, 
                o.発注形態区分, o.発注形態名称漢字, o.予備_数値_, o.本部発注区分, o.部門コード, 
                o.部門名漢字, o.部門名カナ, o.ラインコード, o.クラスコード, o.商品コード区分, 
                
                o.ロケーションコード, o.オプション使用欄, o.ＧＴＩＮ, o.品名カナ, o.規格名カナ, 
                o.最小発注単位数量, o.発注単位名称漢字, o.発注単位名称カナ, o.総額取引区分, o.原単価_税込_, 
                o.原価金額_税込_, o.税額, o.税区分, o.税率, o.売単価_税込_, 
                o.特価区分, o.PB区分, o.原価区分, o.用度品区分, o.納期回答区分, 
                
                o.回答納期, o.色名カナ, o.柄名カナ, o.サイズ名カナ, o.広告コード, 
                o.伝票出力単位, o.納品先店舗コード, o.納品先店舗名漢字, o.納品先店舗名カナ, o.納品場所名カナ, 
                o.便区分, o.センター経由区分, o.センターコード, o.センター名漢字, o.センター名カナ,
                o.実際配送担当, o.配送担当受信,o.口数,o.重量, o.単位,
                o.ジャンル, o.自社コード, o.実際出荷数量,o.県別, o.Status );
                
        }

        private string ConvertDateTimeToString(DateTime datetime) {
            return datetime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
