using System;

namespace ProtoType_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            EmployeePrototype RegEmp1 = new RegEmployee();
            RegEmp1.Name = "Amir";
            RegEmp1.ID = 1;
            RegEmp1.EmpAddress = new Address { City = "sohag", StreetName = "Eltabona St", Building = "75" };
            EmployeePrototype RegEmp2= RegEmp1.ShallowCopy();
            Console.WriteLine("======RegEmp1 Original Values======");
            Console.WriteLine(RegEmp1.ToString());
            Console.WriteLine("======RegEmp2 Copy Values======");
            Console.WriteLine(RegEmp2.ToString());

            RegEmp2.EmpAddress.City = "Cairo";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("======RegEmp1 After Change Values======");
            Console.WriteLine(RegEmp1.ToString());
            Console.WriteLine("======RegEmp2  Values======");
            Console.WriteLine(RegEmp2.ToString());

            Console.ForegroundColor = ConsoleColor.White;

            EmployeePrototype RegEmp3 = RegEmp1.DeepCopy();
            Console.WriteLine("======RegEmp1 Original Values======");
            Console.WriteLine(RegEmp1.ToString());
            Console.WriteLine("======RegEmp2 Copy Values======");
            Console.WriteLine(RegEmp3.ToString());

            RegEmp3.EmpAddress.City = "Assuit";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("======RegEmp1 After Change Values======");
            Console.WriteLine(RegEmp1.ToString());
            Console.WriteLine("======RegEmp2  Values======");
            Console.WriteLine(RegEmp3.ToString());

        }
    }
}
