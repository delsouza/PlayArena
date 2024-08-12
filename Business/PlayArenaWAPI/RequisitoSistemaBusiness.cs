using Azure.Core;
using Business.PlayArenaWAPI.Interface;
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

namespace Business.PlayArenaWAPI
{
    public class RequisitoSistemaBusiness : IRequisitoSistemaBusiness
    {
        private readonly IRequisitoSistemaDAO _requisitoSistemaDAO;

        public RequisitoSistemaBusiness(IRequisitoSistemaDAO requisitoSistemaDAO)
        {
            _requisitoSistemaDAO = requisitoSistemaDAO;
        }

        public RequisitoModel ObterRequisitoPorIdJogo(int idJogo)
        {
            var requisito = _requisitoSistemaDAO.ListarPor(x => x.Id_Jogo == idJogo).FirstOrDefault();

            return (RequisitoModel)requisito;
        }
    }
}

