namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addagetomovis : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "age", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "age");
        }
    }
}
