using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
					Processador = source.Processador,
					SistemaOperacional = source.SistemaOperacional
				};
			}
			else
				return null;
		}
	}
}
