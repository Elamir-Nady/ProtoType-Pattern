using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType_Pattern
{
    public class RegEmployee : EmployeePrototype
    {
        public override EmployeePrototype ShallowCopy ()
        {
            return (RegEmployee)this.MemberwiseClone();
        }

        public override EmployeePrototype DeepCopy()
        {
            RegEmployee emp = new RegEmployee();
            emp= (RegEmployee)this.MemberwiseClone();
            emp.EmpAddress = new Address {
            Building=EmpAddress.Building,
            StreetName=EmpAddress.StreetName,
            City=EmpAddress.City,
            };
            emp.Name = this.Name;

            return emp;
        }

        
    }
}
