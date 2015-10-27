using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SpareSpace.Models
{
    public class SpareSpaceDb : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<BusinessCategory> BusinessCategory { get; set; }
        public DbSet<CardInfo> CardInfo { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Space> Space { get; set; }
        public DbSet<SpaceAttributes> SpaceAttributes { get; set; }
        public DbSet<SpaceCategory> SpaceCategory { get; set; }
        public DbSet<SpaceElement> SpaceElement { get; set; }
        public DbSet<SpaceType> SpaceType { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

		static SpareSpaceDb()
		{
			Database.SetInitializer(new SpareSpaceDbInitializer());
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer(new SpareSpaceDbInitializer());
			base.OnModelCreating(modelBuilder);
		}
	}

	public class SpareSpaceDbInitializer : DropCreateDatabaseIfModelChanges<SpareSpaceDb>
	{
		protected override void Seed(SpareSpaceDb context)
		{
			base.Seed(context);
		}
	}
}
