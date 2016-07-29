namespace GODInventory.MyLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("t_edidata")]
    public partial class t_edidata
    {
        [Key]
        public int Id { get; set; }

        public string データID { get; set; }

        public long 管理連番 { get; set; }

        public int レコード件数 { get; set; }

        public DateTime created_at { get; set; }

        public bool is_sent { get; set; }
        public DateTime? sent_at { get; set; }
        public bool is_printed { get; set; }
        public DateTime? printed_at { get; set; }
    }
}
