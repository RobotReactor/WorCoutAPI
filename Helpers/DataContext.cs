using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WorCout_API.Entities;
using WorCout_API.Models.WorCoutModels;

namespace WorCout_API.Helpers
{
    public class DataContext : DbContext
    {
        
        private readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }
        public DbSet<Calories> Calories { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Workouts> Workouts { get; set; }
        public DbSet<Exercises> Exercises { get; set; }
        public DbSet<MuscleGroups> MuscleGroups { get; set; }
        public DbSet<Muscles> Muscles { get; set; }
/*        public DbSet<Sessions> Sessions { get; set; }*/
        public DbSet<Tempos> Tempos { get; set; }
    }
}