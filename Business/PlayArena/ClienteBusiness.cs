using Business.PlayArena.Interface;
using DAO.Interface;
using Entity;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PlayArena
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteDAO _clienteDAO;
        private readonly ApplicationDbContext _context;

        public ClienteBusiness(IClienteDAO clienteDAO, ApplicationDbContext context)
        {
            _clienteDAO = clienteDAO;
            _context = context;
        }

        public async Task Cadastro(ClienteModel cliente)
        {

            var Clientes = await _clienteDAO.ListarPor(i => i.Email == cliente.Email).SingleOrDefaultAsync();

            if (Clientes != null)
            {
                throw new Exception("Essa conta já existe!");
            }

            var ClienteEntity = (ClienteEntity)cliente;

            _clienteDAO.Criar(ClienteEntity);

            await _context.SaveChangesAsync();
        }

        public async Task<ClienteEntity> Login(string email, string senha)
        {
            var cliente = await _clienteDAO.ListarPor(i => i.Email == email && i.Senha == senha).SingleOrDefaultAsync();

            return cliente;
        }

        public async Task<ClienteEntity> ObterClientePorEmail(string email)
        {
            var ObterClientePorEmail = await _clienteDAO.ListarPor(i => i.Email == email).SingleOrDefaultAsync();

            return ObterClientePorEmail;
        }

        public async Task<ClienteEntity> ObterClientePorId(int id)
        {
            var ObterClientePorId = await _clienteDAO.ListarPor(i => i.Id == id).SingleOrDefaultAsync();

            return ObterClientePorId;
        }

    }
}
