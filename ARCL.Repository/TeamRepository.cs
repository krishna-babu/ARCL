using ARCL.DBModel;
using ARCL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCL.Repository
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public TeamRepository(ARCLContext context) : base(context)
        {

        }
    }
}
