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
    public class TeamService : ITeamService
    {
        ITeamRepository repo = null;

        public TeamService(ITeamRepository _repo)
        {
            this.repo = _repo;
        }
        public IQueryable<Team> GetTeams()
        {
            return repo.GetAll();
        }

    }
}
