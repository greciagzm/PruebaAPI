using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiPrueba.Models
{
    public class Productos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public string SKU { get; set; }
        public float Precio { get; set; }
        public bool Activo { get; set; }

    }
}