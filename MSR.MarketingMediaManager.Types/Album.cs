using System;
using System.Collections.Generic;
using MSR.MarketingMediaManager.Types.Interfaces;

namespace MSR.MarketingMediaManager.Types
{
    public class Album : ITimeStampedEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string PropertyId { get; set; }
        public int AlbumTypeId { get; set; }
        public virtual AlbumType AlbumType { get; set; }
        public virtual ICollection<Media> Media { get; set; }
    }
}
