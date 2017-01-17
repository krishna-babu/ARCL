namespace ARCL.DBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMatch : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.__RefactorLog",
                c => new
                    {
                        OperationKey = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.OperationKey);
            
            CreateTable(
                "dbo.Match",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Team1 = c.Int(nullable: false),
                        Team2 = c.Int(nullable: false),
                        MatchDay = c.DateTime(),
                        Venue = c.String(maxLength: 50, fixedLength: true),
                        SeasonId = c.Int(),
                        Status = c.Short(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Season", t => t.SeasonId)
                .ForeignKey("dbo.Team", t => t.Team1)
                .ForeignKey("dbo.Team", t => t.Team2)
                .Index(t => t.Team1)
                .Index(t => t.Team2)
                .Index(t => t.SeasonId);
            
            CreateTable(
                "dbo.Season",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Description = c.String(),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        BannerMessage = c.String(unicode: false),
                        Logo = c.Binary(storeType: "image"),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        DOB = c.DateTime(),
                        BirthPlace = c.String(maxLength: 50),
                        Role = c.Int(),
                        BattingStyle = c.Short(),
                        BowlineStyle = c.Short(),
                        Profile = c.String(),
                        ProfilePic = c.String(),
                        Nickname = c.String(maxLength: 50),
                        Height = c.Int(),
                        Weight = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(),
                        FullPhotoUrl = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(maxLength: 10, fixedLength: true),
                        State = c.String(maxLength: 10, fixedLength: true),
                        Mobile = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        FederationIdentifier = c.String(maxLength: 50),
                        Password = c.String(),
                        IsActive = c.Boolean(),
                        LastLoginDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "UserId", "dbo.User");
            DropForeignKey("dbo.Match", "Team2", "dbo.Team");
            DropForeignKey("dbo.Match", "Team1", "dbo.Team");
            DropForeignKey("dbo.Match", "SeasonId", "dbo.Season");
            DropIndex("dbo.Players", new[] { "UserId" });
            DropIndex("dbo.Match", new[] { "SeasonId" });
            DropIndex("dbo.Match", new[] { "Team2" });
            DropIndex("dbo.Match", new[] { "Team1" });
            DropTable("dbo.User");
            DropTable("dbo.Players");
            DropTable("dbo.Team");
            DropTable("dbo.Season");
            DropTable("dbo.Match");
            DropTable("dbo.__RefactorLog");
        }
    }
}
