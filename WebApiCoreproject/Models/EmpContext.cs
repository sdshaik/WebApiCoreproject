using Microsoft.EntityFrameworkCore;
namespace WebApiCoreproject.Models
{
    public class EmpContext:DbContext
    {
        public EmpContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Emp_Id = 1,
                Emp_FirstName = "Jhon",
                Emp_lastName = "Son",
                Emp_dob = new DateTime(2002, 05, 10),
                Emp_Contact = "745676574",
                Emp_Email = "Jhon@gmail.com"
            }, new Employee
            {
                Emp_Id=2,
                Emp_FirstName="sam",
                Emp_lastName="T",
                Emp_dob = new DateTime(1999,03,11),
                Emp_Contact="824534554",
                Emp_Email="sam@gmail.com"
 
            });
        }
    }
   
}
