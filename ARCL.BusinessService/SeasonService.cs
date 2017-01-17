using ARCL.BusinessService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARCL.DBModel;
using ARCL.Repository.Interface;
using ARCL.Repository;

namespace ARCL.BusinessService
{
    public class SeasonService : ISeasonService
    {
        ISeasonRepository repo = null;

        public SeasonService(ISeasonRepository _repository)
        {
            repo = _repository;
        }

        public IQueryable<Season> GetSeasons()
        {
            return repo.GetAll();
        }
    }
}
