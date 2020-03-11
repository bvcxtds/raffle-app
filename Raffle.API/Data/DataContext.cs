using DatingApp.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Raffle.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<User> Users { get; set; }
    }
}