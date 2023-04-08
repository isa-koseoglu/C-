namespace DesingPatternBuilder.Classes.ContactBuilder
{
    public class EmployeeInternal : EmployeeAbs
    {
        public override EmployeeAbs SetAddress(string address)
        {
            Employeee.Address = address;
            return this;
        }

        public override EmployeeAbs SetEmail(string email)
        {
            Employeee.Email = email;
            return this;
        }

        public override EmployeeAbs SetLastName(string lastName)
        {
            Employeee.LastName = lastName;
            return this;
        }

        public override EmployeeAbs SetName(string name)
        {
            Employeee.Name = name;
            return this;
        }

        public override EmployeeAbs SetPhone(string phone)
        {
            Employeee.Phone = phone;
            return this;
        }
    }
}