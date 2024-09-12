using Microsoft.EntityFrameworkCore;

namespace Employee.Data.Entites
{
    public class Department
    {
        public int Dep_Id { get; set; }    
        public string? DepName { get; set; } 
        
        public ICollection<Employees> employees { get; set; } = new List<Employees>();
    }
}
