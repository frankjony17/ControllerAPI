using ControllerAPI.Entities;
using Microsoft.EntityFrameworkCore;


namespace ControllerAPI.Repositories
{
    public class ResponseContext : DbContext
    {
        public ResponseContext(DbContextOptions<ResponseContext> options) : base (options) {}

        public DbSet<SystemClient> SystemClients { get; set; }
        public DbSet<NeonService> NeonServices { get; set; }
        public DbSet<ResponseService> ResponseServices { get; set; }

    }
}
