namespace MovieStreamer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MovieItemModels", newName: "MovieEntities");
            DropColumn("dbo.MovieEntities", "AvailableToWatch");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovieEntities", "AvailableToWatch", c => c.Boolean(nullable: false));
            RenameTable(name: "dbo.MovieEntities", newName: "MovieItemModels");
        }
    }
}
