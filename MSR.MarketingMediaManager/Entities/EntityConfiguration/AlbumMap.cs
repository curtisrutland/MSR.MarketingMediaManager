using MSR.MarketingMediaManager.Types;

namespace MSR.MarketingMediaManager.Entities.EntityConfiguration
{
    internal class AlbumMap : TimeStampedEntiyMap<Album>
    {
        public AlbumMap()
        {
            Property(x => x.PropertyId).IsRequired().HasMaxLength(10);
            Property(x => x.AlbumTypeId).IsRequired();
        }
    }
}