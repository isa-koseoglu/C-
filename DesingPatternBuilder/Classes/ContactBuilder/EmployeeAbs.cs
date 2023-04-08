
using DesingPatternBuilder.Classes.ContactBuilder.Models;

namespace DesingPatternBuilder.Classes.ContactBuilder
{

    public abstract class EmployeeAbs
    {
        protected readonly Employee Employeee;
        public EmployeeAbs()
        {
            this.Employeee = new Employee();
        }
        
public abstract EmployeeAbs SetName(string name);
        public abstract EmployeeAbs SetLastName(string lastName);
        public abstract EmployeeAbs SetEmail(string email);
        public abstract EmployeeAbs SetPhone(string phone);
        public abstract EmployeeAbs SetAddress(string address);
        public Employee Build()=>this.Employeee;

    }
}