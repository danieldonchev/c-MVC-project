namespace MovieStreamer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieItemModels",
                c => new
                    {
                        imdbID = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Year = c.String(),
                        Rated = c.String(),
                        Released = c.String(),
                        Genre = c.String(),
                        Director = c.String(),
                        Writer = c.String(),
                        Actors = c.String(),
                        Plot = c.String(),
                        Awards = c.String(),
                        Poster = c.String(),
                        Type = c.String(),
                        imdbRating = c.String(),
                        AvailableToWatch = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.imdbID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieItemModels");
        }
    }
}
