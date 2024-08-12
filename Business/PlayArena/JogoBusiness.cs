using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using static Business.PlayArenaWAPI.JogoBusiness;
using DAO.Interface;
using Models;
using Business.PlayArena.Interface;
using System.Text.Json;

namespace Business.PlayArena
{
    public class JogoBusiness : IJogoBusiness
    {
		public JogoModel ObterJogoPorId(int idJogo)
		{
			HttpClient clientJogo = new HttpClient();

			clientJogo.Timeout = Timeout.InfiniteTimeSpan;

			string urlJogo = $"https://localhost:7106/api/Jogo/api/jogo/listar/{idJogo}";

			clientJogo.BaseAddress = new Uri(urlJogo);

			Task<HttpResponseMessage> respostaJogo;

			respostaJogo = clientJogo.GetAsync(urlJogo);

			var conteudoJogo = respostaJogo.Result.Content.ReadAsStringAsync();

			var jogo = JsonSerializer.Deserialize<JogoModel>(conteudoJogo.Result);

			return jogo;
		}
	}
}
