using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class JogoModel
    {
        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nome")]

        public string Nome { get; set; } = string.Empty;
        [JsonPropertyName("empresa")]

        public string Empresa { get; set; } = string.Empty;
        [JsonPropertyName("genero")]

        public string Genero { get; set; } = string.Empty;
        [JsonPropertyName("quantidadeDisponivel")]

        public int QuantidadeDisponivel { get; set; }
        [JsonPropertyName("dataLancamento")]

        public DateTime DataLancamento { get; set; }
        [JsonPropertyName("preco")]

        public decimal Preco { get; set; }
        [JsonPropertyName("capa")]

        public string Capa { get; set; }
    }
}
