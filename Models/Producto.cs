using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S11_PC3_Simulacro.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Debe escribir el nombre del producto")]
        public string NombreProducto { get; set; }

        [Required(ErrorMessage="Debe ingresar el url de la imagen")]
        public string Foto{ get; set; }

        [Required(ErrorMessage="Debe ingresar la descripción del producto")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage="Debe ingresar el precio de compra")]
        public Decimal Precio { get; set; }
        
        [Required(ErrorMessage="Debe ingresar su número de contacto")]
        public string CelularContacto { get; set; }

        [Required(ErrorMessage="Debe ingresar el lugar desde donde compra")]
        public string Lugar { get; set; }

        [Required(ErrorMessage="Debe ingresar el nombre del comprador")]
        public string NombreDelComprador { get; set; }

        //[Required(ErrorMessage="Debe escoger una categoría")]
        //public string Categoria { get; set; }

        
        public Categoria Categoria { get; set;}


        public int CategoriaId { get; set; }

        public DateTime FechaPublicacion { get; set; }

        public Producto (){
            FechaPublicacion = DateTime.Now;
        }

    }
}