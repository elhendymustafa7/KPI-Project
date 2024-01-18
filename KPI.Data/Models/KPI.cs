using System.ComponentModel.DataAnnotations;

namespace KPI.Data.Models
{
    public class Kpi
    {
        [Key]
        public int KPIDNum { get; set; }
        public string KPIDNescription { get; set; }
        public int DepNo { get; set; }
        public bool MeasurementUnit { get; set; }
        public int TargetedValue { get; set; }
    }
}
