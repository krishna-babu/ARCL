using ARCL.BusinessService.Interface;
using ARCL.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;

namespace ARCL.WebApi.Controllers
{
    public class SeasonController : ApiController
    {
        ISeasonService service = null;
        public SeasonController(ISeasonService _service)
        {
            service = _service;
        }

        [EnableQuery]
        public IQueryable<Season> Get()
        {
            return service.GetSeasons();
        }
    }
}
