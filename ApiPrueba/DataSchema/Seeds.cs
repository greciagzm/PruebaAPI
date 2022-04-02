using ApiPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPrueba.DataSchema
{
        public class Seeds
        {
            

            public static List<Productos> GetProductos()
            {

                List<Productos> productos = new List<Productos>()
            {
                new Productos()
                {
                   NombreProducto = "Producto #1",
                   SKU = "A-001",
                   Precio = 100,
                   Activo = true
                },

                new Productos()
                {
                   NombreProducto = "Producto #2",
                   SKU = "A-002",
                   Precio = 80,
                   Activo = true
                },

                new Productos()
                {
                   NombreProducto = "Producto #3",
                   SKU = "A-003",
                   Precio = 50,
                   Activo = false
                }

            };

                return productos;
            }

         

        }


 }
