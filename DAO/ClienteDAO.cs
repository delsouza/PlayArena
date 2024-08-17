using DAO.Interface;
using Entity;
using Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ClienteDAO : BaseDAO<ClienteEntity>, IClienteDAO
    {
        private readonly ApplicationDbContext _context;

        public ClienteDAO(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
