using Entity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PlayArena.Interface
{
    public interface IClienteBusiness
    {
        public Task Cadastro(ClienteModel cliente);
        public Task<ClienteEntity> Login(string email, string senha);
        public Task<ClienteEntity> ObterClientePorEmail(string email);
        public Task<ClienteEntity> ObterClientePorId(int id);
    }
}
