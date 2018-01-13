using MSR.MarketingMediaManager.Types;

namespace MSR.MarketingMediaManager.Entities.EntityConfiguration
{
    internal class AreaMap : TimeStampedEntiyMap<Area>
    {
        internal AreaMap()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(200);
        }
    }
}