using ARCL.BusinessService.Interface;
using ARCL.DBModel;
using ARCL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCL.BusinessService
{
    public class ScoreService : IScoreService
    {
        IScoreRepository repo = null;

        public ScoreService(IScoreRepository _repository)
        {
            repo = _repository;
        }

        public IQueryable<Score> GetScores()
        {
            return repo.GetAll();
        }
    }
}
