﻿using ARCL.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCL.BusinessService.Interface
{
    public interface IScoreService
    {
        IQueryable<Score> GetScores();

        void AddScore(Score Item);

        void AddScores(IEnumerable<Score> Items);
    }
}
