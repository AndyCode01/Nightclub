using Microsoft.EntityFrameworkCore;
using Nightclub.Models;

namespace Nightclub.Context
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options): base(options){

        }

        
        public DbSet<Type_document> Type_documents {get; set;}
        public DbSet<Type_rol> Type_Rols {get; set;}
        public DbSet<Client> Clients {get; set;}
        public DbSet<Artist> Artists {get; set;}
        public DbSet<Assistant> Assistants {get; set;}
        public DbSet<Event> Events {get; set;}
        public DbSet<Event_artist> Event_Artists {get; set;}
        public DbSet<Event_assistant> Event_Assistants {get; set;}
        public DbSet<Ticket> Tickets {get; set;}
        
    }
}