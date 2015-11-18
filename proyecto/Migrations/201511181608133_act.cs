namespace proyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class act : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.chofers", "pasajeroidpasajero", c => c.Int(nullable: false));
            AddColumn("dbo.empleadoes", "chofer_idchofer", c => c.Int());
            AddColumn("dbo.pasajeroes", "bussidbus", c => c.Int(nullable: false));
            CreateIndex("dbo.pasajeroes", "bussidbus");
            CreateIndex("dbo.empleadoes", "chofer_idchofer");
            AddForeignKey("dbo.pasajeroes", "bussidbus", "dbo.busses", "idbus", cascadeDelete: true);
            AddForeignKey("dbo.empleadoes", "chofer_idchofer", "dbo.chofers", "idchofer");
            DropColumn("dbo.chofers", "pasajeroDireccion");
            DropColumn("dbo.pasajeroes", "busscodigobus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.pasajeroes", "busscodigobus", c => c.Int(nullable: false));
            AddColumn("dbo.chofers", "pasajeroDireccion", c => c.String());
            DropForeignKey("dbo.empleadoes", "chofer_idchofer", "dbo.chofers");
            DropForeignKey("dbo.pasajeroes", "bussidbus", "dbo.busses");
            DropIndex("dbo.empleadoes", new[] { "chofer_idchofer" });
            DropIndex("dbo.pasajeroes", new[] { "bussidbus" });
            DropColumn("dbo.pasajeroes", "bussidbus");
            DropColumn("dbo.empleadoes", "chofer_idchofer");
            DropColumn("dbo.chofers", "pasajeroidpasajero");
        }
    }
}
