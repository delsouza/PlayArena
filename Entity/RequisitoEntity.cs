using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entity
{
	public class RequisitoEntity
	{
		[Key]
		[JsonPropertyName("id")]
		public int Id { get; set; }

		public int Id_Jogo { get; set; }
		[JsonPropertyName("processador")]
		public string Processador { get; set; } = string.Empty;
		[JsonPropertyName("sistemaOperacional")]
		public string SistemaOperacional { get; set; } = string.Empty;

		public static explicit operator RequisitoModel(RequisitoEntity source)
		{
			if (source != null)
			{
				return new RequisitoModel()
				{
					Id = source.Id,
					Id_Jogo = source.Id_Jogo,
					Processador = source.Processador,
					SistemaOperacional = source.SistemaOperacional

				};
			}
			else
				return null;
		}
	}
}
