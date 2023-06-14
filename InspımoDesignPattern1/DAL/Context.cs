using Microsoft.EntityFrameworkCore;

namespace InspımoDesignPattern1.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAADET\\SQLEXPRESS01 ; initial catalog=InspimoDp1;integrated security=true");
        }
        public DbSet<CustomerProcess> customerProcesses { get; set; }
    }
}
