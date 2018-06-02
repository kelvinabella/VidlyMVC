namespace VidlyMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMovieGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Fantasy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Suspense')");
            Sql("INSERT INTO Genres (Name) VALUES ('Animation')");
            Sql("INSERT INTO Genres (Name) VALUES ('Horror')");
            Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romance')");
            Sql("INSERT INTO Genres (Name) VALUES ('Family')");
            Sql("INSERT INTO Genres (Name) VALUES ('Musical')");
        }

        public override void Down()
        {
        }
    }
}
