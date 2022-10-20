using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightMaker.ProjectQueen_sBox.Core.Entities
{
    public class BeehiveNote : IEntity
    {
        public int Id { get; set; }
        public string? Note { get; set; }
    }
}
