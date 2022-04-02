using ApiPrueba.Models;
using System;
using System.Data.Entity;


namespace ApiPrueba.DataSchema
{
    public class Context : DbContext
    {
        public Context() : base("APIPrueba")
        {

        }
        public DbSet<Productos> Productos { get; set; }
    }
}