using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
	public class ImagemJogoModel
	{
		[Key]
		[JsonPropertyName("id")]
		public int Id { get; set; }
		public int Id_Jogo { get; set; }
		public string URL { get; set; } = string.Empty;
	}
}
