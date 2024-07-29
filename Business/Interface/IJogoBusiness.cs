using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IJogoBusiness
    {
        public List<JogoModel> ListarJogo();
        public JogoModel ObterJogoPorId(int id);
    }
}
