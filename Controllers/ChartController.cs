using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChartsAPI.Domain.Models;
using ChartsAPI.Domain.Interfaces;

namespace ChartsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly IChartService chartService;

        public ChartController(IChartService chartService)
        {
            this.chartService = chartService;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<ChartDetails>> GetById(int id)
        {
            return await chartService.GetById(id);
        }

        [HttpGet]
        [Route("GetByTypeId")]
        public async Task<IEnumerable<ChartDetails>> Get(int id)
        {
            return await chartService.GetByTypeId(id);
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IEnumerable<ChartDetails>> Get()
        {
            return await chartService.GetAll();
        }
    }
}