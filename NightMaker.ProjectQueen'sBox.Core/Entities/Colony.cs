using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightMaker.ProjectQueen_sBox.Core.Entities
{
    // Queen Rhaenyra of House Targaryen, first of her name. Queen of the Andals and the Rhoynar.
    // Lady of the Seven Kingdoms and the Protector of the Realm.

    // The Queen and quantific attributes of the colony.
    public class Colony : IEntity
    {
        public int Id { get; set; }

        // Navigation Properties
        public int QueenId { get; set; }
        public Queen Queen { get; set; }
        public int ColonyMaintenanceStatusId { get; set; }
        public ColonyMaintenanceStatus ColonyMaintenanceStatus { get; set; }
        public int ColonyNoteId { get; set; }
        public ColonyNote? ColonyNote { get; set; }
        public int ColonyStockId { get; set; }
        public ColonyStock ColonyStock { get; set; }
        public int ColonyDetailId { get; set; }
        public ColonyDetail ColonyDetail { get; set; }

        // One-To-Many
        public List<Harvest> Harvests { get; set; }
    }
}
