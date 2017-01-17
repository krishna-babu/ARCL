using ARCL.DBModel;
using System.Linq;

namespace ARCL.BusinessService.Interface
{
    public interface ISeasonService
    {
        IQueryable<Season> GetSeasons();
    }
}