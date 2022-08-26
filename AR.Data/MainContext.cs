using AR.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace AR.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Client> Client {get; set;}
    }
}
