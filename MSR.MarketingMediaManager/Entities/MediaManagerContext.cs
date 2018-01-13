using System.Data.Entity;
using MSR.MarketingMediaManager.Entities.EntityConfiguration;
using MSR.MarketingMediaManager.Types;

namespace MSR.MarketingMediaManager.Entities
{
    public class MediaManagerContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumType> AlbumTypes { get; set; }
        public DbSet<MediaRecord> MediaRecords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) => EntityMaps.Configure(modelBuilder);
    }
}