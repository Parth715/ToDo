using Microsoft.EntityFrameworkCore;

namespace ToDoList.Model
{
    public class ToDoDBContext : DbContext
    {
       public DbSet<Person> Persons { get; set; }
       public DbSet<Item> Items { get; set; }
        public ToDoDBContext(DbContextOptions<ToDoDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Person>(p =>
            {
                p.ToTable("Person");
                p.HasKey(p => p.Id);
                p.Property(p => p.Name).IsRequired(true);
            });
            builder.Entity<Item>(p =>
            {
                p.ToTable("Items");
                p.HasKey(p => p.Id);
                p.Property(p => p.Description);
                p.Property(p => p.DateTime);
                p.Property(p => p.Completed);
                p.HasOne(p => p.Person).WithMany(p => p.Items).HasForeignKey(p => p.PersonId).OnDelete(DeleteBehavior.Restrict);
            });
        }


    }
}
