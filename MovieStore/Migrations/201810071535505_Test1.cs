namespace MovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MovieModels", "NumberAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovieModels", "NumberAvailable", c => c.Byte(nullable: false));
        }
    }
}
