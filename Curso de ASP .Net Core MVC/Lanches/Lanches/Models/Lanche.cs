using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanches.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

    }
}
