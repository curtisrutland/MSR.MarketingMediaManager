using System.Data.Entity.ModelConfiguration;
using MSR.MarketingMediaManager.Types.Interfaces;

namespace MSR.MarketingMediaManager.Entities.EntityConfiguration
{
    internal class TimeStampedEntiyMap<T> : EntityTypeConfiguration<T> where T: class, ITimeStampedEntity
    {
        public TimeStampedEntiyMap()
        {
            Property(x => x.CreatedOn).IsRequired();
            Property(x => x.ModifiedOn).IsRequired();
            HasKey(x => x.Id);
        }
    }
}