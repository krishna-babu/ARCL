namespace ARCL.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Player
    {
        public Player()
        {
            RunsScored = new HashSet<Score>();
            Bowled= new HashSet<Score>();
            Fielded = new HashSet<Score>();
            NonStrikerBalls = new HashSet<Score>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string BirthPlace { get; set; }

        public int? Role { get; set; }

        public short? BattingStyle { get; set; }

        public short? BowlineStyle { get; set; }

        public string Profile { get; set; }

        public string ProfilePic { get; set; }

        [StringLength(50)]
        public string Nickname { get; set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Score> RunsScored { get; set; }
        public virtual ICollection<Score> Bowled { get; set; }
        public virtual ICollection<Score> Fielded { get; set; }
        public virtual ICollection<Score> NonStrikerBalls { get; set; }
    }
}
