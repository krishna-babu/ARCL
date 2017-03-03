namespace ARCL.DBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed_score : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Score", "Over", c => c.Short(nullable: false));
            AddColumn("dbo.Score", "Ball", c => c.Short(nullable: false));
            AddColumn("dbo.Score", "BatsmanScore", c => c.Int(nullable: false));
            AddColumn("dbo.Score", "ExtrasScore", c => c.Int(nullable: false));
            AlterColumn("dbo.Score", "ExtrasType", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Score", "ExtrasType", c => c.Int(nullable: false));
            DropColumn("dbo.Score", "ExtrasScore");
            DropColumn("dbo.Score", "BatsmanScore");
            DropColumn("dbo.Score", "Ball");
            DropColumn("dbo.Score", "Over");
        }
    }
}
