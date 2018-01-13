using MSR.MarketingMediaManager.Types;

namespace MSR.MarketingMediaManager.Entities.EntityConfiguration
{
    internal class AlbumTypeMap : TimeStampedEntiyMap<AlbumType>
    {
        public AlbumTypeMap()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(100);
        }
    }
}