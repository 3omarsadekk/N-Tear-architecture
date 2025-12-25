using BL.Model_Manager;
using BL.Models;

namespace PLConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Ch;
            Department_Manager department_Manager = new Department_Manager();
            do
            {
                Console.WriteLine("a-Display All Departments");
                Console.WriteLine("b-Add Departments");
                Console.WriteLine("c-Delete Departments");
                Console.WriteLine("e-Exit");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Entar Choice Charactar");
                Ch = char.Parse(Console.ReadLine());

                switch (Ch)
                {
                    case 'a':

                        Console.WriteLine("-------------------Display All Departments-------------------");
                        List<Department> departments = department_Manager.GetAll(); ;
                        foreach (var department in departments)
                        {
                            Console.WriteLine(value: $"Number:{department.Dept_Id}\t Name:" +
                                $"{department.Dept_Name}");
                        }
                        Console.WriteLine("-------------------------------------------------");
                        break;
                    case 'b':
                        Console.WriteLine("-----------------------Added New Form-----------------------");
                        Console.WriteLine("Entar Department Number");
                        int Dnum = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entar Department name");
                        var Dname = Console.ReadLine();
                        Department deptData = new Department { Dept_Id = Dnum, Dept_Name = Dname };
                        bool IsAdded = department_Manager.Add(deptData);
                        if (IsAdded)
                        {
                        Console.WriteLine("Department Is Added");
                        }
                        else
                        {
                            Console.WriteLine("Department is invalid and cannot be added");
                        }
                        break;
                    case 'c':
                        Console.WriteLine("----------------------Delete Department---------------------------");

                        Console.WriteLine("Entar Department Number");
                        int DelDnum = int.Parse(Console.ReadLine());
                        var isDeleted = department_Manager.Delete(DelDnum);
                        if (isDeleted)
                        {
                            Console.WriteLine("Department Is deleted");
                        }
                        else
                        {
                            Console.WriteLine("Department is invalid and cannot be added Delete");
                        }

                        break;
                    case 'e':
                        break;
                }
            }
            while (Ch != 'e');


        }





    }
}

