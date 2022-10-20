using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightMaker.ProjectQueen_sBox.Core.Entities
{
    public class BeehiveMaintenanceStatus : IEntity
    {
        public int Id { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public string? MaintenanceNote { get; set; }
        public bool IsCriticalAlert { get; set; }
    }
}
