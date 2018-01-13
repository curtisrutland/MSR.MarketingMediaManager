using System;
using MSR.MarketingMediaManager.Types.Interfaces;

namespace MSR.MarketingMediaManager.Types
{
    public class MediaRecord : ITimeStampedEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public int AlbumId { get; set; }
        public string MimeType { get; set; }
    }
}