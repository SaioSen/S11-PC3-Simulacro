using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S11_PC3_Simulacro.Models
{
    [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage="Debe escribir el nombre del producto")]
        [Column("nombreproducto")]
        public string NombreProducto { get; set; }

        [Column("foto")]
        [Required(ErrorMessage="Debe ingresar el url de la imagen")]
        public string Foto{ get; set; }

        [Column("descripcion")]
        [Required(ErrorMessage="Debe ingresar la descripción del producto")]
        public string Descripcion { get; set; }

        [Column("precio")]
        [Required(ErrorMessage="Debe ingresar el precio de compra")]
        public Decimal Precio { get; set; }
        
        [Column("celularcontacto")]
        [Required(ErrorMessage="Debe ingresar su número de contacto")]
        public string CelularContacto { get; set; }

        [Column("lugar")]
        [Required(ErrorMessage="Debe ingresar el lugar desde donde compra")]
        public string Lugar { get; set; }

        [Column("nombredelcomprador")]
        [Required(ErrorMessage="Debe ingresar el nombre del comprador")]
        public string NombreDelComprador { get; set; }
        [Column("categoria")]
        [Required(ErrorMessage="Debe escoger una categoría")]
        public string Categoria { get; set; }

        [Column("fechapublicacion")]
        [Required(ErrorMessage="Debe ingresar la fecha en la que publica esta busqueda")]
        public DateTime FechaPublicacion { get; set; }
    }
}