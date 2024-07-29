using Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using static Business.JogoBusiness;
using DAO.Interface;
using Models;

namespace Business
{
        public class JogoBusiness : IJogoBusiness
        {
            private readonly IPlayArenaDAO _playArenaDAO;

            public JogoBusiness(IPlayArenaDAO playArenaDAO)
            {
                _playArenaDAO = playArenaDAO;   
            }

            public List<JogoModel> ListarJogo()
            {
            var list = new List<JogoModel>();
            var listaentity = _playArenaDAO.Listar();
            foreach (var jogo in listaentity)
            {
                var jogoCasting = (JogoModel)jogo;
                list.Add(jogoCasting);

            }
            return list;

            }

            public JogoModel ObterJogoPorId(int id)
            {
                var jogo = _playArenaDAO.ListarPor(x => x.Id == id).FirstOrDefault();

                return (JogoModel)jogo;
            }
        }
}
