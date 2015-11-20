namespace proyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class core : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.empleadoes", "chofer_idchofer", "dbo.chofers");
            DropIndex("dbo.empleadoes", new[] { "chofer_idchofer" });
            DropColumn("dbo.chofers", "pasajeroidpasajero");
            DropColumn("dbo.empleadoes", "chofer_idchofer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.empleadoes", "chofer_idchofer", c => c.Int());
            AddColumn("dbo.chofers", "pasajeroidpasajero", c => c.Int(nullable: false));
            CreateIndex("dbo.empleadoes", "chofer_idchofer");
            AddForeignKey("dbo.empleadoes", "chofer_idchofer", "dbo.chofers", "idchofer");
        }
    }
}
