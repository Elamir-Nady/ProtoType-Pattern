using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType_Pattern
{
    public abstract class EmployeePrototype
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Address EmpAddress { get; set; }
        public abstract EmployeePrototype ShallowCopy();
        public abstract EmployeePrototype DeepCopy();
        public override string ToString()
        {
            return $@"
            ID: {this.ID}
            Name: {this.Name}
            Address: {this.EmpAddress.City},{this.EmpAddress.StreetName},{this.EmpAddress.Building}";
        }
    }
}
