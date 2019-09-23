namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("note")]
    public partial class note
    {
        [Key]
        public int idNote { get; set; }

        [Column("note")]
        public int? note1 { get; set; }

        [StringLength(255)]
        public string CIN { get; set; }

        public virtual employe employe { get; set; }
    }
}
