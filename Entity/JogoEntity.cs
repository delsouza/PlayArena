using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class JogoEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Empresa { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public int QuantidadeDisponivel { get; set; }
        public DateTime DataLancamento { get; set; }
        public decimal Preco { get; set; }
        public string Capa { get; set; }
		public string Descricao { get; set; }

		public static explicit operator JogoModel(JogoEntity source)
        {
            if (source != null)
            {
                return new JogoModel()
                {
                    Id = source.Id,
                    Nome = source.Nome,
                    Empresa = source.Empresa,
                    Genero = source.Genero,
                    QuantidadeDisponivel = source.QuantidadeDisponivel,
                    DataLancamento = source.DataLancamento,
                    Preco = source.Preco,
                    Capa = source.Capa,
                    Descricao=source.Descricao
                };
            }
            else
                return null;
        }
    }
}
