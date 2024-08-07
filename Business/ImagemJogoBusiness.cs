using Business.Interface;
using DAO;
using DAO.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public class ImagemJogoBusiness : IImagemJogoBusiness
	{
		private readonly IImagemJogoDAO _imagemJogoDAO;

		public ImagemJogoBusiness(IImagemJogoDAO imagemJogoDAO)
		{
			_imagemJogoDAO = imagemJogoDAO;
		}

		public ImagemJogoModel ObterImagemJogoPorId(int idImagem)
		{
			var imagem = _imagemJogoDAO.ListarPor(x => x.Id == idImagem).FirstOrDefault();

			return (ImagemJogoModel)imagem;
		}

	}
}
