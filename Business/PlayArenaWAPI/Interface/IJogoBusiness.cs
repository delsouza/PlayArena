using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PlayArenaWAPI.Interface
{
    public interface IJogoBusiness
    {
        public List<JogoModel> ListarJogo();
        public JogoModel EditarJogo(JogoModel jogo, int id);
        public JogoModel ObterJogoPorId(int id);
    }
}
