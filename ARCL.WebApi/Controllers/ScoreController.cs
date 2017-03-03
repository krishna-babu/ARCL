using ARCL.BusinessService.Interface;
using ARCL.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace ARCL.WebApi.Controllers
{
    public class ScoreController : BaseController
    {

        IScoreService service = null;
        public ScoreController(IScoreService _service)
        {
            service = _service;
        }

        [EnableQuery]
        public IQueryable<Score> Get()
        {
            return service.GetScores();
        }
        [HttpPost]
        public void AddScores(IEnumerable<Score> items)
        {
            service.AddScores(items);
        }
        [HttpPost]
        public void AddScore(Score item)
        {
            service.AddScore(item);
        }

    }
}
