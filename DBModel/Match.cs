namespace ARCL.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Match")]
    public partial class Match
    {
        public Match()
        {
            ScoreByEveryBall = new HashSet<Score>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Team1 { get; set; }

        public int Team2 { get; set; }

        public DateTime? MatchDay { get; set; }

        [StringLength(50)]
        public string Venue { get; set; }

        public int? SeasonId { get; set; }

        public short? Status { get; set; }

        public virtual Season Season { get; set; }

        public virtual Team Team1Team { get; set; }

        public virtual Team Team2Team { get; set; }

        public ICollection<Score> ScoreByEveryBall { get; set; }
    }
}
