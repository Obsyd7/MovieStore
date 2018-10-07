namespace MovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (1, 'Romance')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (2, 'Drama')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (3, 'Comedy')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (4, 'Horror')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (5, 'Action')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (6, 'Thriller')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (7, 'Science Fiction')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (8, 'Drama')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (9, 'Fantasy')");
        }
        
        public override void Down()
        {
        }
    }
}
