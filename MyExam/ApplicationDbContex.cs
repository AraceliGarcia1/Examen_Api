using Microsoft.EntityFrameworkCore;
using MyExam.Models;
namespace MyExam
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){

        }
        public DbSet<Propietario>? Propietarios { get; set; } 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }





    }


}