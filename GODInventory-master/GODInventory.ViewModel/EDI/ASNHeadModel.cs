using GODInventory.MyLinq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace GODInventory.ViewModel.EDI
{
    public class ASNHeadModel
    {
        public Byte[] データID; //1 データID        3 1
        public Byte[] 管理連番; //2 管理連番        13 4
        public Byte[] システム管理日付; //3 システム管理日付 8 17
        public Byte[] データ作成日; //4 データ作成日      8 25
        public Byte[] データ作成時刻; //5 データ作成時刻     6 33
        public Byte[] 出荷業務仕入先コード; //6 出荷業務仕入先コード 6 39
        public Byte[] レコード件数; //7 レコード件数      8 45
        public Byte[] レコード長; //8 レコード長       4 53
        public Byte[] 予備; //9 予備              644 57

        public List<t_orderdata> entities;
        public List<ASNModel> models;
        public int totalQuantity;

        public ASNHeadModel( List<t_orderdata> orders)
        {
            this.entities = orders;

            var date = DateTime.Now.ToString("yyyyMMdd");
            var time = DateTime.Now.ToString("HHmmss");
            this.データID = Encoding.ASCII.GetBytes(EDITxtHandler.NYOTEL_ID);
            
            this.管理連番 = Encoding.ASCII.GetBytes( orders.First().ASN管理連番.ToString( "D13"));

            this.システム管理日付 = Encoding.ASCII.GetBytes(date);
            this.データ作成日 = Encoding.ASCII.GetBytes(date);
            this.データ作成時刻 = Encoding.ASCII.GetBytes(time);

            this.出荷業務仕入先コード = Encoding.ASCII.GetBytes( EDITxtHandler.出荷業務仕入先コード.ToString("D6"));
            this.レコード件数 = Encoding.ASCII.GetBytes(orders.Count.ToString( "D8" ) );
            this.レコード長 = Encoding.ASCII.GetBytes( EDITxtHandler.レコード長.ToString("D4") );
            this.予備 = EDITxtHandler.GetSpacedBytes( 444 );


            this.models = new List<ASNModel>( orders.Count);
            foreach ( var o in orders)
            {
                totalQuantity += o.実際出荷数量;
                models.Add(new ASNModel(this, o));
            }

        }
        public ASNHeadModel(BinaryReader br)
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
            br.ReadBytes(2); // \n\r
        }

        public int Serialize(BinaryWriter bw) {
            int count = 0;
            bw.Write(this.ToBytes());

            foreach( var o in this.models)
            {
                o.Serialize(bw);
                count++;
            }
            return count;
        }

        public Byte[] ToBytes() {
            List<Byte> line = new List<byte>();
            line.AddRange(this.データID);
            line.AddRange(this.管理連番);
            line.AddRange(this.システム管理日付);
            line.AddRange(this.データ作成日);
            line.AddRange(this.データ作成時刻);
            line.AddRange(this.出荷業務仕入先コード);
            line.AddRange(this.レコード件数);
            line.AddRange(this.レコード長);
            line.AddRange(this.予備);

            Debug.Assert( line.Count == 500);
            line.AddRange(EDITxtHandler.NR);            
            return line.ToArray();
        }
        

        public int DetailCount
        {
            get
            {
                string s = Encoding.ASCII.GetString(this.レコード件数);
                return Convert.ToInt32(s);
            }
        }

        public int TotalQuantity {
            get { return totalQuantity;  }
        }

        public string SデータID {
            get { return Encoding.ASCII.GetString(this.データID);  }
        }

        public long I管理連番
        {
            get { return Convert.ToInt64(Encoding.ASCII.GetString(this.管理連番)); }
        }
        public int Iレコード件数
        {
            get { return Convert.ToInt32(Encoding.ASCII.GetString(this.レコード件数)); }
        }

        public string ToRawSql()
        {
            string format = @"INSERT INTO `t_edidata`( `データID`, `管理連番`, `レコード件数`,  `created_at`)VALUES ( '{0}',{1},{2},'{3:yyyy-MM-dd HH:mm:ss}');";


            return string.Format(format, this.SデータID, I管理連番, this.Iレコード件数, DateTime.Now);

        }
        // generate 管理連番  length = 13 
        //private byte[] GenerateMID() {
        //    int count = 0;
        //    var now = DateTime.Now.Date;
        //    using (var ctx = new GODDbContext()) {
        //        string sql = "SELECT count(*) FROM t_edidata where `データID`='CH1' and Date(created_at)=Date(NOW());";
        //        var list = ctx.Database.SqlQuery<int>( sql);
        //        count = list.First();
        //    }
        //    string s = DateTime.Now.ToString("yyyyMMdd") + (count + 1).ToString("D5");
        //    return Encoding.ASCII.GetBytes(s);
        //}

    }
}