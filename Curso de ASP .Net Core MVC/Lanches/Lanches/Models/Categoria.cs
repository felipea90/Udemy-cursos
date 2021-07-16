using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanches.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }
    }
}
