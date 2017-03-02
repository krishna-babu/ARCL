using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ARCL.DBModel
{

    [Table("Score")]
    public class Score
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int Match_Id { get; set; }
        public virtual Match Match { get; set; }
        public int BattingTeam_Id { get; set; }
        public virtual Team BattingTeam { get; set; }
        public int BowlingTeam_Id { get; set; }
        public virtual Team BowlingTeam { get; set; }
        public int Stricker_Id { get; set; }
        public virtual Player Striker { get; set; }
        public int Bowler_Id { get; set; }
        public virtual Player Bowler { get; set; }
        public int Fielder_Id { get; set; }
        public virtual Player Fielder { get; set; }
        public int NonStriker_Id { get; set; }
        public virtual Player NonStriker { get; set; }
        short Over { get; set; }

        short Ball { get; set; }

        Runs BatsmanScore { get; set; }

        int ExtrasScore { get; set; }
        
        public OutType? Out { get; set; }

        public Extras ExtrasType { get; set; }
    }
}
