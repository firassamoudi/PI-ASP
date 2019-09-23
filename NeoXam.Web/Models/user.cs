namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [Key]
        public int idU { get; set; }

        [Column(TypeName = "bit")]
        public bool actif { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(254)]
        public string email_canonical { get; set; }

        public int? enabled { get; set; }

        public DateTime? lastLogin { get; set; }

        [StringLength(254)]
        public string password { get; set; }

        [StringLength(254)]
        public string Role { get; set; }

        [StringLength(254)]
        public string username { get; set; }

        [StringLength(254)]
        public string username_canonical { get; set; }

        [StringLength(255)]
        public string CAN_CIN { get; set; }

        [StringLength(255)]
        public string Emp_CIN { get; set; }

        public virtual candidat candidat { get; set; }

        public virtual employe employe { get; set; }
    }
}
