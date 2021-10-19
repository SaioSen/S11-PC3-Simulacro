using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S11_PC3_Simulacro.Models
{
    public class Categoria
    {
        
        public int Id { get; set; }
        public string NomCategoria { get; set; }

        public ICollection<Producto> Productos {get;set;}
    }
}