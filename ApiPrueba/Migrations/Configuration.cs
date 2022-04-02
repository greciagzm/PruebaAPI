namespace ApiPrueba.Migrations
{
    using ApiPrueba.DataSchema;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApiPrueba.DataSchema.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApiPrueba.DataSchema.Context context)
        {
            context.Productos.AddOrUpdate(
                p => p.NombreProducto, Seeds.GetProductos().ToArray()
              );

            context.SaveChanges();
        }
    }
}
