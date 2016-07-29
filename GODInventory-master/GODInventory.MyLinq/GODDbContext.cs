namespace GODInventory.MyLinq
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GODDbContext : DbContext
    {
        public GODDbContext()
            : base("name=GODDbContext")
        {
            
        }

        public virtual DbSet<t_date> t_date { get; set; }
        public virtual DbSet<t_genre> t_genre { get; set; }
        public virtual DbSet<t_itemlist> t_itemlist { get; set; }
        public virtual DbSet<t_maruken_trans> t_maruken_trans { get; set; }
        public virtual DbSet<t_orderdata> t_orderdata { get; set; }
        public virtual DbSet<t_rcvdata> t_rcvdata { get; set; }
        public virtual DbSet<t_shoplist> t_shoplist { get; set; }
        public virtual DbSet<t_stockrec> t_stockrec { get; set; }
        public virtual DbSet<t_stockstate> t_stockstate { get; set; }
        public virtual DbSet<t_edidata> t_edidata { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<t_genre>()
                .Property(e => e.ジャンル名)
                .IsUnicode(false);

            modelBuilder.Entity<t_itemlist>()
                .Property(e => e.得意先)
                .IsUnicode(false);

            modelBuilder.Entity<t_itemlist>()
                .Property(e => e.商品名)
                .IsUnicode(false);

            modelBuilder.Entity<t_itemlist>()
                .Property(e => e.規格)
                .IsUnicode(false);

            modelBuilder.Entity<t_itemlist>()
                .Property(e => e.配送担当)
                .IsUnicode(false);

            modelBuilder.Entity<t_itemlist>()
                .Property(e => e.単位)
                .IsUnicode(false);

            modelBuilder.Entity<t_maruken_trans>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<t_maruken_trans>()
                .Property(e => e.店舗名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_maruken_trans>()
                .Property(e => e.キャンセル)
                .IsUnicode(false);

            modelBuilder.Entity<t_maruken_trans>()
                .Property(e => e.品名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_maruken_trans>()
                .Property(e => e.規格名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_maruken_trans>()
                .Property(e => e.単位)
                .IsUnicode(false);

            modelBuilder.Entity<t_maruken_trans>()
                .Property(e => e.実際配送担当)
                .IsUnicode(false);

            modelBuilder.Entity<t_maruken_trans>()
                .Property(e => e.県別)
                .IsUnicode(false);

            modelBuilder.Entity<t_maruken_trans>()
                .Property(e => e.納品指示)
                .IsUnicode(false);

            modelBuilder.Entity<t_maruken_trans>()
                .Property(e => e.備考)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.店舗名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.ダブリ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.在庫状態)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.キャンセル)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.品名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.規格名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.単位)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.実際配送担当)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.納品指示)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.納品場所名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.備考)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.法人名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.法人名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.店舗名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.仕入先名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.仕入先名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.発注形態名称漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.部門名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.部門名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.ＧＴＩＮ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.品名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.規格名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.発注単位名称漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.発注単位名称カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.回答納期)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.色名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.柄名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.サイズ名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.納品先店舗名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.納品先店舗名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.納品場所名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.センター名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_orderdata>()
                .Property(e => e.センター名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.法人名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.法人名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.店舗名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.店舗名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.部門名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.部門名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.仕入先名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.仕入先名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.支払仕入先名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.支払仕入先名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.ＧＴＩＮ)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.品名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.品名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.規格名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.規格名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.理由漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.連絡事項１)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.連絡事項２)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.納品先店舗名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.納品先店舗名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_rcvdata>()
                .Property(e => e.センター名漢字)
                .IsUnicode(false);

            modelBuilder.Entity<t_shoplist>()
                .Property(e => e.店名)
                .IsUnicode(false);

            modelBuilder.Entity<t_shoplist>()
                .Property(e => e.店名カナ)
                .IsUnicode(false);

            modelBuilder.Entity<t_shoplist>()
                .Property(e => e.配送担当)
                .IsUnicode(false);

            modelBuilder.Entity<t_shoplist>()
                .Property(e => e.郵便番号)
                .IsUnicode(false);

            modelBuilder.Entity<t_shoplist>()
                .Property(e => e.県別)
                .IsUnicode(false);

            modelBuilder.Entity<t_shoplist>()
                .Property(e => e.県内エリア)
                .IsUnicode(false);

            modelBuilder.Entity<t_shoplist>()
                .Property(e => e.住所)
                .IsUnicode(false);

            modelBuilder.Entity<t_shoplist>()
                .Property(e => e.電話番号)
                .IsUnicode(false);

            modelBuilder.Entity<t_shoplist>()
                .Property(e => e.FAX番号)
                .IsUnicode(false);

            modelBuilder.Entity<t_stockrec>()
                .Property(e => e.区分)
                .IsUnicode(false);

            modelBuilder.Entity<t_stockrec>()
                .Property(e => e.状態)
                .IsUnicode(false);

            modelBuilder.Entity<t_stockrec>()
                .Property(e => e.元)
                .IsUnicode(false);

            modelBuilder.Entity<t_stockrec>()
                .Property(e => e.先)
                .IsUnicode(false);

            modelBuilder.Entity<t_stockrec>()
                .Property(e => e.納品書番号)
                .IsUnicode(false);

            modelBuilder.Entity<t_stockstate>()
                .Property(e => e.在庫状態)
                .IsUnicode(false);
        }
    }
}
