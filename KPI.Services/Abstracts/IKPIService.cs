using KPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.Services.Abstracts
{
    public interface IKPIService
    {
        //IEnumerable<Kpi> GetKpis(int departmentNum);
        IEnumerable<Kpi> GetKpis(int departmentNum);
        bool Save(List<Kpi> kpis);
        void Delete(Kpi kpi);
    }
}
