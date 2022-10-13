using System.Collections.Generic;
using System.Linq;
using WebApiCoreproject.Models.Repository;

namespace WebApiCoreproject.Models.DataManager
{
    public class EmpManager:IDataRepository<Employee>
    {
        readonly EmpContext _EmpContext;
        public EmpManager (EmpContext context)
        {
            _EmpContext = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _EmpContext.Employees.ToList();
        }
        public Employee Get(int id)
        {
            return _EmpContext.Employees.FirstOrDefault(x => x.Emp_Id == id);
        }

        public void Add(Employee entity)
        {
            _EmpContext.Employees.Add(entity);
            _EmpContext.SaveChanges();
        }
        public void Update(Employee employee,Employee entity)
        {
            employee.Emp_FirstName = entity.Emp_FirstName;
            employee.Emp_lastName = entity.Emp_lastName;
            employee.Emp_dob=entity.Emp_dob;
            employee.Emp_Contact=entity.Emp_Contact;
            employee.Emp_Email = entity.Emp_Email;
        }
        public void Delete(Employee employee)
        {
            _EmpContext.Employees.Remove(employee);
            _EmpContext.SaveChanges ();
        }

    }
}
