using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartsAPI.Domain.Models;

namespace ChartsAPI.Domain.Interfaces
{
    public interface IChartService : IService<ChartDetails>
    {
        public Task<IEnumerable<ChartDetails>> GetAll();
        public Task<IEnumerable<ChartDetails>> GetByTypeId(int id);
    }
}
