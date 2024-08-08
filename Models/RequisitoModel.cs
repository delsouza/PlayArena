using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
	public class RequisitoModel
	{
		[Key]
		[JsonPropertyName("id")]
		public int Id { get; set; }
		public int Id_Jogo { get; set; }
		[JsonPropertyName("processador")]
		public string Processador { get; set; } = string.Empty;
		[JsonPropertyName("sistemaOperacional")]
		public string SistemaOperacional { get; set; } = string.Empty;
	}
}
