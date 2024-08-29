﻿using Entity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interface
{
    public interface IPlayArenaDAO : IBaseDAO<JogoEntity>
    {
        public JogoModel EditarJogo(JogoModel jogo);
    }
}
