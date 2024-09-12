namespace Employee.Data.Entites
{
    public class Employees
    {
        public int Emp_Id { get; set; }//
        public int FDep_Id { get; set; }//
        public Department? Department { get; set; } = null!;
        public string? Name { get; set; }//
        public decimal Salary { get; set; }//
        public DateTime BirthDate{ get; set; }//
    }
}
