using KPI.Data.Models;
using KPI.Infrastructure.Abstracts;
using KPI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.Infrastructure.Repositories
{
    public class KPIRepository : IKPIRepository
    {
        private readonly ApplicationDbContext _context;

        public KPIRepository(ApplicationDbContext context)
        {
            _context = context;
        }   

        public IEnumerable<Kpi> GetKpis(int departmentNum)
        {
            return _context.KPIs.Where(k => k.DepNo == departmentNum).ToList();
        }

        public void AddKpi(Kpi kpi)
        {
            _context.KPIs.Add(kpi);
            //Save();
        }

        public void AddKpis(List<Kpi> kpis)
        {
            _context.KPIs.AddRange(kpis);
            //Save();
        }

        public void RemoveKpi(Kpi kpi)
        {
            _context.KPIs.Remove(kpi);
            //Save();
        }
        public void RemoveKpis(List<Kpi> kpis)
        {
            _context.KPIs.RemoveRange(kpis);
            //Save();
        }

        public void EditKpi(Kpi kpi)
        {
            _context.KPIs.Update(kpi);
            //Save();
        }

        public void EditKpis(List<Kpi> kpis)
        {
            _context.KPIs.UpdateRange(kpis);
            //Save();
        }

        public void Save() => _context.SaveChanges();

        public bool KpiExists(Kpi kpi)
        {
            return _context.KPIs.Any(k => k.KPIDNum == kpi.KPIDNum);
        }
    }
}
