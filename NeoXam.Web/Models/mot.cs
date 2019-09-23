namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mot")]
    public partial class mot
    {
        [Required]
        [StringLength(31)]
        public string DTYPE { get; set; }

        [Key]
        public int idMot { get; set; }

        [StringLength(254)]
        public string label { get; set; }

        [StringLength(254)]
        public string pattern { get; set; }

        public int idLang { get; set; }

        public virtual langage_naturel langage_naturel { get; set; }
    }
}
