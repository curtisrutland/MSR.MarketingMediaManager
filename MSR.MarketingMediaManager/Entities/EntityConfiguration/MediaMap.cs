using MSR.MarketingMediaManager.Types;

namespace MSR.MarketingMediaManager.Entities.EntityConfiguration
{
    internal class MediaMap : TimeStampedEntiyMap<Media>
    {
        public MediaMap()
        {
            Property(x => x.MimeType).IsRequired().HasMaxLength(250);
            Property(x => x.Content).IsRequired();
            Property(x => x.Thumbnail).IsRequired();
        }
    }
}