namespace VidlyMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedNumberAvialableInMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Short(nullable: false));

            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
        }

        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
