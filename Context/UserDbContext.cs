using Microsoft.EntityFrameworkCore;
using Nightclub.Models;

namespace Nightclub.Context
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options): base(options){

        }

        
        public DbSet<Type_document> Type_documents {get; set;}
        public DbSet<Assistant_role> Assistant_roles {get; set;}
        public DbSet<Client> Clients {get; set;}
    }
}