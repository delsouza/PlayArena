using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JogoModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Empresa { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public int QuantidadeDisponivel { get; set; }
        public DateTime DataLancamento { get; set; }
        public decimal Preco { get; set; }
        public string Capa { get; set; }
    }
}
