using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFloorDB.Entities
{
    public class Items
    {
        public int Id { get; set; }

        public Collections CollectionType { get; set; }

        public string Name { get; set; }

        public int? Year { get; set; }

        public Conditions Condition{ get; set; }

        public Rares Rare { get; set; }

        public string StoragePlace { get; set; }

        public double? Price { get; set; }

        public Status Status { get; set; }
    }
}
