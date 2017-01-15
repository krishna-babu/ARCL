using ARCL.BusinessService.Interface;
using ARCL.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ARCL.WebApi.Controllers
{
    public class TeamController : BaseController
    {
        ITeamService service = null;
        public TeamController(ITeamService _service)
        {
            service = _service;
        }

        [HttpGet]
        public IEnumerable<Team> All()

        {
            return service.GetTeams();
        }
    }
}
