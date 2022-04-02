namespace ApiPrueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        ProductoID = c.Int(nullable: false, identity: true),
                        NombreProducto = c.String(),
                        SKU = c.String(),
                        Precio = c.Single(nullable: false),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Productos");
        }
    }
}
