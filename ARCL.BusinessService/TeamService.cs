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
        IBaseRepository<Team> repo = null;

        public TeamService(IBaseRepository<Team> _repo)
        {
            this.repo = _repo;
        }
        public IEnumerable<Team> GetTeams()
        {
            return repo.GetAll();
        }

    }
}
