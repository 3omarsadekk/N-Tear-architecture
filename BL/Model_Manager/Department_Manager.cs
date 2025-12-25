using BL.Models;
using DAL;
using Intarfaces;
using System.Data;

namespace BL.Model_Manager
{
    public class Department_Manager
    {
        public Iiti_Model iti_Model { get; set; }

        public Department_Manager()
        {
            this.iti_Model = new Iti_Model();
        }

        public bool Add(Department department)
        {
            return iti_Model.ExecuteManioulationcommend($"INSERT INTO Department (Dept_Id,Dept_Name) VALUES ({department.Dept_Id},'{department.Dept_Name}')");
        }
         public bool Delete(int denum)
        {
            return iti_Model.ExecuteManioulationcommend($"Delete Department Where Dept_Id = {denum}");

        }

        public List<Department> GetAll()
        {
            List<Department> departments = new List<Department>();
            DataTable dataTable = this.iti_Model.ExecuteDisConnectedQuery("Select * from  Department");
            foreach (DataRow rows in dataTable.Rows)
            {
                Department department = new Department
                {
                    Dept_Id = rows.Field<int>("Dept_Id"),
                    Dept_Name = rows.Field<string>("Dept_Name"),
                    Dept_Desc = rows.Field<string>("Dept_Desc"),
                    Dept_Location = rows.Field<string>("Dept_Location"),
                    Dept_Manager = rows.Field<int?>("Dept_Manager"),          // nullable
                    Manager_hiredate = rows.Field<DateTime?>("Manager_hiredate")
                };
                departments.Add(department);
            }
            return departments;
        }
    }
}
