
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GODInventory.ViewModel.EDI
{
    using GODInventory.MyLinq;
    using System.Data.Entity.Validation;

    public class EDITxtHandler
    {
        public static string ASNFileName = "NYOTEI.txt";
        public static string ASNFolder = "nyotei";

        public static string ASNRelativePath {
            get { return Path.Combine(ASNFolder, ASNFileName); }
        }

        public static string NYOTEL_ID {
            get { return "CH1"; }
        }

        public static int 出荷業務仕入先コード {

            get { return 249706;  }
        }

        public static int レコード長 {

            get { return 500;  }
        }

        public static byte[] NR = new byte[2] { 0x0D, 0x0A };

        public static Byte[] DateToBytes( DateTime? nullable_datetime)
        {
            DateTime datetime = nullable_datetime ?? DateTime.Now;
            return Encoding.ASCII.GetBytes(datetime.ToString("yyyyMMdd"));
        }
        public static Byte[] TimeToBytes(DateTime datetime)
        {
            return Encoding.ASCII.GetBytes(datetime.ToString("HHmmss"));
        }
        public static Byte[] TimeTo4Bytes(DateTime datetime)
        {
            return Encoding.ASCII.GetBytes(datetime.ToString("HHmm"));
        }

        // lenght(2) => "  "
        public static byte[] GetSpacedBytes( int length)
        {
            List<Byte> list = new List<byte>(length);
            for( var i = 0; i< length; i++)
            {
                list.Add(0x20);
            }
            return list.ToArray();
        }

        // lenght(2) => "00"
        public static byte[] GetZeroedBytes(int length)
        {
            List<Byte> list = new List<byte>(length);
            for (var i = 0; i < length; i++)
            {
                list.Add(0x30);
            }
            return list.ToArray();
        }

        // pad left with ' '
        public static byte[] PadLeftBytes( byte[] bytes, int length )
        {
            List<byte> new_bytes = new List<byte>(length);
            int delta = length - bytes.Length;

            if (delta>0)
            {
                for(int i = 0; i<length; i++)
                {
                    if( delta -i > 0 )
                    {
                        new_bytes.Add( 0x20 );
                    }
                    else
                    {
                        new_bytes.Add(bytes[i-delta ]);
                    }

                }
                return new_bytes.ToArray();
            }else
            {
                return bytes;
            }

        }


        public static ASNHeadModel GenerateASNTxt(string path, List<t_orderdata> orders)
        {
            var directory_path = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory_path))
            {
                Directory.CreateDirectory(directory_path);
            }
 

            ASNHeadModel order_head;
            using (BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Create, FileAccess.Write)))
            {

                order_head = new ASNHeadModel(orders);

                order_head.Serialize(bw);

                Console.WriteLine(" write head ={0}", order_head.DetailCount);
            }

            return order_head;
        }

        public static void ImportOrderTxt(string path)
        {
            
            
            //File.ReadLines(path, Encoding.)
            File.ReadAllBytes(path);

            var lines = ConvertToUtf8Strings(path);
            List<OrderModel> order_models = new List<OrderModel>();

            try
            {
                //byte[] first_line = null;
                //byte[] line = null;
                using (BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read)))
                {
                    OrderHeadModel order_head = new OrderHeadModel(br);
                    Console.WriteLine(" write head ={0}", order_head.DetailCount);

                    for ( var i = 0; i< order_head.DetailCount; i++)
                    {
                        order_models.Add( new OrderModel(br) );
                    }
                    //while (line = br.ReadBytes(702))
                    //{
                    //}
                }
            }
            catch(EndOfStreamException e)
            {

            }

            using (var ctx = new GODDbContext())
            {
                try
                {
                    var orders = order_models.Select(x => x.ConverToEntity(null,null));
                    var result = ctx.Entry(orders.First()).GetValidationResult();
                    ctx.t_orderdata.AddRange(orders);
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        // get ship no for order  
        public static long GenerateShipNo(GODDbContext ctx, t_orderdata order )
        {
           //一般六个月不能重复。
                var date = DateTime.Now.AddMonths(-6);
                //var orders = (from t_orderdata o in ctx.t_orderdata
                //              where order_ids.Contains(o.id受注データ)
                //              select o).ToList();

                //var grouped_orders = orders.GroupBy( o => new { o.法人コード, o.店舗コード }, o=>o );
               
                   
                int count = (from t_orderdata o in ctx.t_orderdata
                            where o.店舗コード == order.店舗コード && o.法人コード == order.法人コード && o.発注日 > date
                            group o by o.ASN管理連番 into g
                            select g
                        ).Count();
                var s=  String.Format("{0}{1}{2}{3}{4}", order.法人コード.ToString("D2"), order.店舗コード.ToString("D3"), EDITxtHandler.出荷業務仕入先コード, "01", (count + 1).ToString("D5")) ;
                return Convert.ToInt64( s );
                   
        }

        // generate 管理連番  length = 13 
        public static long GenerateMID(GODDbContext ctx) {

            int count = 0;
            var today = DateTime.Now.Date;
            var tommorrow = today.AddDays(1);
            count = (from t_edidata o in ctx.t_edidata
                        where o.created_at >= today && o.created_at< tommorrow && o.データID == "CH1"
                        select o).Count();
  
           
            var s = today.ToString("yyyyMMdd") + (count + 1).ToString("D5");
            return Convert.ToInt64(s);
        }
        
        //public static string GenerateMID()
        //{
        //    string s;           
        //    using (var ctx = new GODDbContext())
        //    {
        //        s = GenerateMID(ctx);
        //    }
        //    return s;
        //}

        private static string[] ConvertToUtf8Strings( string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            string text_in_utf8 = EncodingUtility.ConvertShiftJisToUtf8(bytes);
            return text_in_utf8.Split(System.Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }


    }
}
