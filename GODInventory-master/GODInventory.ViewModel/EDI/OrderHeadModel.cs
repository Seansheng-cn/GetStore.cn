using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace GODInventory.ViewModel.EDI
{
    public class OrderHeadModel
    {
        Byte[] データID; //1 データID        3 1
        Byte[] 管理連番; //2 管理連番        13 4
        Byte[] システム管理日付; //3 システム管理日付 8 17
        Byte[] データ作成日; //4 データ作成日      8 25
        Byte[] データ作成時刻; //5 データ作成時刻     6 33
        Byte[] 出荷業務仕入先コード; //6 出荷業務仕入先コード 6 39
        Byte[] レコード件数; //7 レコード件数      8 45
        Byte[] レコード長; //8 レコード長       4 53
        Byte[] 予備; //9 予備              644 57
        byte[] nr;

        public OrderHeadModel(Byte[] line)
        {
            //arrays.SelectMany(x => x).ToArray();
            //line.
            //this.データID = 

        }
        public OrderHeadModel(BinaryReader br)
        {
            this.データID = br.ReadBytes(3);
            this.管理連番 = br.ReadBytes(13);
            this.システム管理日付 = br.ReadBytes(8);
            this.データ作成日 = br.ReadBytes(8);
            this.データ作成時刻 = br.ReadBytes(6);
            this.出荷業務仕入先コード = br.ReadBytes(6);
            this.レコード件数 = br.ReadBytes(8);
            this.レコード長 = br.ReadBytes(4);
            this.予備 = br.ReadBytes(644);
            this.nr = br.ReadBytes(2); // \n\r
            Debug.Assert(this.nr[0] == 0x0D && this.nr[1] == 0x0A);

        }


        public int DetailCount {
            get{
                string s = Encoding.ASCII.GetString(this.レコード件数);
                return Convert.ToInt32(s); }
        }


    }
}