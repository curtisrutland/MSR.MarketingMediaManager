using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSR.MarketingMediaManager.Types.Interfaces;

namespace MSR.MarketingMediaManager.Types
{
    public class Area : ITimeStampedEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime ModifiedOn { get; set; }
        public string Name { get; set; }
    }
}
