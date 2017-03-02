namespace ARCL.DBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class score : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Score",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Match_Id = c.Int(nullable: false),
                        BattingTeam_Id = c.Int(nullable: false),
                        BowlingTeam_Id = c.Int(nullable: false),
                        Stricker_Id = c.Int(nullable: false),
                        Bowler_Id = c.Int(nullable: false),
                        Fielder_Id = c.Int(nullable: false),
                        NonStriker_Id = c.Int(nullable: false),
                        Out = c.Int(),
                        ExtrasType = c.Int(nullable: false),
                        BattingTeam_Id1 = c.Int(),
                        BowlingTeam_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Team", t => t.BattingTeam_Id1)
                .ForeignKey("dbo.Players", t => t.Bowler_Id)
                .ForeignKey("dbo.Players", t => t.Fielder_Id)
                .ForeignKey("dbo.Players", t => t.NonStriker_Id)
                .ForeignKey("dbo.Players", t => t.Stricker_Id)
                .ForeignKey("dbo.Team", t => t.BowlingTeam_Id1)
                .ForeignKey("dbo.Match", t => t.Match_Id, cascadeDelete: true)
                .Index(t => t.Match_Id)
                .Index(t => t.Stricker_Id)
                .Index(t => t.Bowler_Id)
                .Index(t => t.Fielder_Id)
                .Index(t => t.NonStriker_Id)
                .Index(t => t.BattingTeam_Id1)
                .Index(t => t.BowlingTeam_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Score", "Match_Id", "dbo.Match");
            DropForeignKey("dbo.Score", "BowlingTeam_Id1", "dbo.Team");
            DropForeignKey("dbo.Score", "Stricker_Id", "dbo.Players");
            DropForeignKey("dbo.Score", "NonStriker_Id", "dbo.Players");
            DropForeignKey("dbo.Score", "Fielder_Id", "dbo.Players");
            DropForeignKey("dbo.Score", "Bowler_Id", "dbo.Players");
            DropForeignKey("dbo.Score", "BattingTeam_Id1", "dbo.Team");
            DropIndex("dbo.Score", new[] { "BowlingTeam_Id1" });
            DropIndex("dbo.Score", new[] { "BattingTeam_Id1" });
            DropIndex("dbo.Score", new[] { "NonStriker_Id" });
            DropIndex("dbo.Score", new[] { "Fielder_Id" });
            DropIndex("dbo.Score", new[] { "Bowler_Id" });
            DropIndex("dbo.Score", new[] { "Stricker_Id" });
            DropIndex("dbo.Score", new[] { "Match_Id" });
            DropTable("dbo.Score");
        }
    }
}
