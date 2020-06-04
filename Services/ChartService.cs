using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChartsAPI.Domain.Interfaces;
using ChartsAPI.Domain.Models;

namespace ChartsAPI.Services
{
    public class ChartService : IChartService
    {
        private ChartsContext _context;

        public ChartService(ChartsContext context)
        {
            this._context = context;
        }

        async Task<IEnumerable<ChartDetails>> IChartService.GetAll()
        {
            var charts = _context.ChartDetails.ToListAsync();
            return await charts;
        }

        async Task<ChartDetails> IService<ChartDetails>.GetById(int id)
        {
            var chart = _context.ChartDetails.Where(c => c.Id == id).SingleOrDefaultAsync();
            return await chart;
        }

        async Task<IEnumerable<ChartDetails>> IChartService.GetByTypeId(int id)
        {
            var charts = from t in _context.ChartTypes join c in _context.ChartDetails on t.Id equals c.Type where c.Type == id select c;
            return await charts.ToListAsync();
        }
    }
}
