namespace ARCL.DBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedID1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Score");
            AlterColumn("dbo.Score", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Score", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Score");
            AlterColumn("dbo.Score", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Score", "Id");
        }
    }
}
