namespace ARCL.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string BannerMessage { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
