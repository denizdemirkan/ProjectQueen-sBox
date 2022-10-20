using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightMaker.ProjectQueen_sBox.Core.Entities
{
    public class ColonyStock : IEntity
    {
        public int Id { get; set; }
        public decimal HoneyKG { get; set; }
        public decimal BeeWaxKG { get; set; }
        public decimal BeePoisonKG { get; set; }
        public decimal ExtraNutritionKG { get; set; }
    }
}
