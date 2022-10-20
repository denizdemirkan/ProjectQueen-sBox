using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightMaker.ProjectQueen_sBox.Core.Entities
{
    // Material of the beehive, layer count, year of construction  
    public class BeehiveDetail : IEntity
    {
        public int Id { get; set; }
        public string Modernity { get; set; } // Modern or Old
        public int LayerCount;
        public DateTime ConstructionTime { get; set; }
    }
}
