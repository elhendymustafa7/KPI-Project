using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.Infrastructure.Abstracts
{
    public interface IKPIRepository
    {
        IEnumerable<Kpi> GetKpis(int departmentNum);
        void AddKpi(Kpi kpi);
        void AddKpis(List<Kpi> kpi);
        void RemoveKpi(Kpi kpi);
        void EditKpi(Kpi kpi);
        void Save();
        bool KpiExists(Kpi kpi);
    }
}
