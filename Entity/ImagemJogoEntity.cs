using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
	public class ImagemJogoEntity
	{
		public int Id { get; set; }
		public int Id_Jogo { get; set; }
		public string URL { get; set; } = string.Empty;

		public static explicit operator ImagemJogoModel(ImagemJogoEntity source)
		{
			if (source != null)
			{
				return new ImagemJogoModel()
				{
					Id = source.Id,
					Id_Jogo = source.Id_Jogo,
					URL = source.URL
				};
			}
			else
				return null;
		}
	}
}
