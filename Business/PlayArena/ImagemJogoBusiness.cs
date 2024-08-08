using Business.PlayArena.Interface;
using DAO;
using DAO.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business.PlayArena
{
    public class ImagemJogoBusiness : IImagemJogoBusiness
    {
		public ImagemJogoBusiness()
		{
		}

		public ImagemJogoModel ObterImagemJogoPorId(int idImagem)
        {
			HttpClient clientImagem = new HttpClient();

			clientImagem.Timeout = Timeout.InfiniteTimeSpan;

			string urlImagem = $"https://localhost:7106/api/Jogo/api/jogo/ImagemJogo/{idImagem}";

			clientImagem.BaseAddress = new Uri(urlImagem);

			Task<HttpResponseMessage> respostaImagem;

			respostaImagem = clientImagem.GetAsync(urlImagem);

			var conteudoImagem = respostaImagem.Result.Content.ReadAsStringAsync();

			var imagemJogo = JsonSerializer.Deserialize<ImagemJogoModel>(conteudoImagem.Result);

			return imagemJogo;

			//var imagem = _imagemJogoDAO.ListarPor(x => x.Id == idImagem).FirstOrDefault();
            //return (ImagemJogoModel)imagem;
        }
    }
}
