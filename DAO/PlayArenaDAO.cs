using DAO.Interface;
using Infra.Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Entity;
using System.Net.WebSockets;


namespace DAO
{
    public class PlayArenaDAO : BaseDAO<JogoEntity>, IPlayArenaDAO
    {
        private readonly ApplicationDbContext _db;

        public PlayArenaDAO(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Casting()
        {
            var model = new JogoModel();
            var entity = new JogoEntity();
            model = (JogoModel)entity;
        }
    }
}
