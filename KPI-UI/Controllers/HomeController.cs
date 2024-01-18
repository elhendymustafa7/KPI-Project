using KPI.Data.Models;
using KPI.Services.Abstracts;
using KPI_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace KPI_UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IKPIService _kPIService;

        public HomeController(ILogger<HomeController> logger, IKPIService kPIService)
        {
            _logger = logger;
            _kPIService = kPIService;
        }

        [HttpGet]
        public IActionResult Index(int departmentNum)
        {
            return View();
        }
 

        [HttpGet]
        public IActionResult GetKPIs(int departmentNum)
        {
            IEnumerable<Kpi> kpis = _kPIService.GetKpis(departmentNum);

            return Json(kpis);
        }

  

        [HttpPost]
        public ActionResult SaveKPIs([FromBody]List<Kpi> kpis)
        {
            if(_kPIService.Save(kpis)) return Json(new { status = "success" });
            return Json(new { status = "error" });
        }


        [HttpDelete]
        public ActionResult DeleteKPIs([FromBody] Kpi kpi)
        {
            _kPIService.Delete(kpi);
            return Json(new { status = "success" });
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
