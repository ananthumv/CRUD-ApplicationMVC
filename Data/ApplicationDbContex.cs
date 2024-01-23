using CRUD_ApplicationMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ApplicationMVC.Data
{
    public class ApplicationDbContex : DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options): base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}