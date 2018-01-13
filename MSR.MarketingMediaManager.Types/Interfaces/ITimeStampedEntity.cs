using System;

namespace MSR.MarketingMediaManager.Types.Interfaces
{
    public interface ITimeStampedEntity
    {
        int Id { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
    }
}
