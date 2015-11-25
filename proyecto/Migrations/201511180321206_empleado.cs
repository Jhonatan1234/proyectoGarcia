namespace proyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empleado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.busses",
                c => new
                    {
                        idbus = c.Int(nullable: false, identity: true),
                        tipo_bus = c.String(),
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
                        tel = c.String(),
                        pasajeroDireccion = c.String(),
                    })
                .PrimaryKey(t => t.idchofer );
            
            CreateTable(
                "dbo.empleadoes",
                c => new
                    {
                        idempleado = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        Apellido = c.String(),
                        cedula = c.Int(nullable: false),
                        telefono = c.String(),
                        direccion = c.String(),
                        codigo = c.String(),
                        genero = c.String(),
                    })
                .PrimaryKey(t => t.idempleado);
            
            CreateTable(
                "dbo.pasajeroes",
                c => new
                    {
                        idpasajero = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        codigo_pasajero = c.Int(nullable: false),
                        nacionalidad = c.String(),
                        Direccion = c.String(),
                        Destino = c.String(),
                        busscodigobus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idpasajero);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.pasajeroes");
            DropTable("dbo.empleadoes");
            DropTable("dbo.chofers");
            DropTable("dbo.busses");
        }
    }
}
