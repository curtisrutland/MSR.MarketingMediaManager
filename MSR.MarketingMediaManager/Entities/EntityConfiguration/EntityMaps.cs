using System.Data.Entity;

namespace MSR.MarketingMediaManager.Entities.EntityConfiguration
{
    internal static class EntityMaps
    {
        internal static void Configure(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumMap())
                .Add(new AlbumTypeMap())
                .Add(new MediaMap())
                .Add(new AreaMap());
        }
    }
}