using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VendaModel
    {
        [Key]
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Jogo { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
