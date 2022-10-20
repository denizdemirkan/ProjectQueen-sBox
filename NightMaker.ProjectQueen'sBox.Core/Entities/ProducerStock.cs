using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightMaker.ProjectQueen_sBox.Core.Entities
{
    // All stock details of the producer
    public class ProducerStock : IEntity
    {
        public int Id { get; set; }
        public decimal HoneyKG { get; set; }
        public decimal BeeWaxKG { get; set; }
        public decimal BeePoisonKG { get; set; }
        public int ColonyCount { get; set; }
        public int FreeBeeBoxCount { get; set; }
        public int TotalLayerCount { get; set; }
        public decimal? ApproximateHoneyHarvestKG { get; set; }
        public decimal? ApproximateBeeWaxHarvestKG { get; set; }
        public decimal? ApproximateBeePoisonHarvestKG { get; set; }
    }
}
