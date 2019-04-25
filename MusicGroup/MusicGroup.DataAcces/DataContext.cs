namespace MusicGroup.DataAcces
{
    using MusicGroup.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<MusicCrew> MusicCrews { get; set; }
    }
}