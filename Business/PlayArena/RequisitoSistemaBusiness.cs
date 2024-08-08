using Azure.Core;
using Business.PlayArena.Interface;
using DAO;
using DAO.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business.PlayArena
{
    public class RequisitoSistemaBusiness : IRequisitoSistemaBusiness
    {
        public RequisitoSistemaBusiness()
        {
        }

        public RequisitoModel ObterRequisitoPorIdJogo(int idJogo)
        {
			HttpClient clientRequisito = new HttpClient();

			clientRequisito.Timeout = Timeout.InfiniteTimeSpan;

			string urlRequisito = $"https://localhost:7106/api/Jogo/api/jogo/RequisitoSistema/{idJogo}";

			clientRequisito.BaseAddress = new Uri(urlRequisito);

			Task<HttpResponseMessage> respostaRequisito;

			respostaRequisito = clientRequisito.GetAsync(urlRequisito);

			var conteudoRequisito = respostaRequisito.Result.Content.ReadAsStringAsync();

			var requisitos = JsonSerializer.Deserialize<RequisitoModel>(conteudoRequisito.Result);

			return requisitos;
        }
    }
}

