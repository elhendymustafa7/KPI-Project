using KPI.Data.Models;
using KPI.Infrastructure.Abstracts;
using KPI.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.Services.Implementations
{
    public class KPIService : IKPIService   
    {
        private readonly IKPIRepository _kPIRepository;

        public KPIService(IKPIRepository kPIRepository)
        {
            _kPIRepository = kPIRepository;
        }

        public IEnumerable<Kpi> GetKpis(int departmentNum)
        {
            return _kPIRepository.GetKpis(departmentNum);
        }

        public bool Save(List<Kpi> kpis)
        {
            if(!IsMoreThan100(kpis))
            {
                foreach (var kpi in kpis)
                {
                    if (!DuplicatedKpiNum(kpis, kpi))
                    {
                        if (_kPIRepository.KpiExists(kpi)) _kPIRepository.EditKpi(kpi);
                        else _kPIRepository.AddKpi(kpi);
                    }
                    else return false;
                }
            }
            _kPIRepository.Save();
            return true;
        }

        private bool IsMoreThan100(List<Kpi> kpis)
        {
            foreach (var kpi in kpis)
            {
                if (kpi.MeasurementUnit && kpi.TargetedValue > 100) return true;
            }
            return false;
        }
        private bool DuplicatedKpiNum(List<Kpi> kpis, Kpi kpi)
        {
            int count = 0;
            foreach (var item in kpis)
            {
                if (kpi.KPIDNum == item.KPIDNum) count++;
            }
            return count > 1;
        }

        public void Delete(Kpi kpi)
        {
            _kPIRepository.RemoveKpi(kpi);
            _kPIRepository.Save();
        }
    }
}
