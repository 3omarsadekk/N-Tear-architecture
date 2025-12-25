namespace BL.Models
{
    public class Department
    {


        public int Dept_Id { get; set; }           
        public string Dept_Name { get; set; }        
        public string Dept_Desc { get; set; }          
        public string Dept_Location { get; set; }     
        public Nullable<int> Dept_Manager { get; set; }         
        public DateTime? Manager_hiredate { get; set; } 


    }
}
