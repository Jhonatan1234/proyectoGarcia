namespace proyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.boletoes",
                c => new
                    {
                        num_boleto = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        Destino = c.String(),
                        precio = c.Int(nullable: false),
                        idbus = c.Int(nullable: false),
                        idchofer = c.Int(nullable: false),
                        idpasajero = c.Int(nullable: false),
                        idempleado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.num_boleto)
                .ForeignKey("dbo.busses", t => t.idbus, cascadeDelete: true)
                .ForeignKey("dbo.chofers", t => t.idchofer, cascadeDelete: true)
                .ForeignKey("dbo.pasajeroes", t => t.idpasajero, cascadeDelete: true)
                .Index(t => t.idbus)
                .Index(t => t.idchofer)
                .Index(t => t.idpasajero);
            
            CreateTable(
                "dbo.busses",
                c => new
                    {
                        idbus = c.Int(nullable: false, identity: true),
                        clase_bus = c.String(),
                        marca_bus = c.String(),
                        color_bus = c.String(),
                    })
                .PrimaryKey(t => t.idbus);
            
            CreateTable(
                "dbo.chofers",
                c => new
                    {
                        idchofer = c.Int(nullable: false, identity: true),
                        Nombrecho = c.String(),
                        Apellidocho = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.idchofer);
            
            CreateTable(
                "dbo.empleadoes",
                c => new
                    {
                        idempleado = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        Apellido = c.String(),
                        direccion = c.String(),
                        genero = c.String(),
                    })
                .PrimaryKey(t => t.idempleado);
            
            CreateTable(
                "dbo.pasajeroes",
                c => new
                    {
                        idpasajero = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        nacionalidad = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.idpasajero);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.boletoes", "idpasajero", "dbo.pasajeroes");
            DropForeignKey("dbo.boletoes", "idchofer", "dbo.chofers");
            DropForeignKey("dbo.boletoes", "idbus", "dbo.busses");
            DropIndex("dbo.boletoes", new[] { "idpasajero" });
            DropIndex("dbo.boletoes", new[] { "idchofer" });
            DropIndex("dbo.boletoes", new[] { "idbus" });
            DropTable("dbo.pasajeroes");
            DropTable("dbo.empleadoes");
            DropTable("dbo.chofers");
            DropTable("dbo.busses");
            DropTable("dbo.boletoes");
        }
    }
}
