using System;
using MSR.MarketingMediaManager.Types.Interfaces;

namespace MSR.MarketingMediaManager.Types
{
    public class AlbumType : ITimeStampedEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime ModifiedOn { get; set; }
        public string Name { get; set; }
    }
}