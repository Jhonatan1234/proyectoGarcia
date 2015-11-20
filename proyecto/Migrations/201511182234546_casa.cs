namespace proyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class casa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.chofers", "pasajeroDireccion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.chofers", "pasajeroDireccion");
        }
    }
}
