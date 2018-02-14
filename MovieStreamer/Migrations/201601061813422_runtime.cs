namespace MovieStreamer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class runtime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieItemModels", "Runtime", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieItemModels", "Runtime");
        }
    }
}
