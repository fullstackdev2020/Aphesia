namespace Aphesia.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aphesia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String());
            DropColumn("dbo.Products", "Descrption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Descrption", c => c.String());
            DropColumn("dbo.Products", "Description");
        }
    }
}
