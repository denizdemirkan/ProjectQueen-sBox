using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightMaker.ProjectQueen_sBox.Core.Entities
{
    public class Beehive : IEntity
    {
        public int Id { get; set; }
        public string BeehiveName { get; set; }

        // Navigation Properties
        public Colony Colony { get; set; }
        public BeehiveDetail BeehiveDetail { get; set; }
        public BeehiveMaintenanceStatus BeehiveMaintenanceStatus { get; set; }
        public BeehiveNote? BeehiveNote { get; set; }
    }
}
