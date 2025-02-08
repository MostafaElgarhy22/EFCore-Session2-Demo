namespace EFCore_Session2_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD Operations
            //using var dbContext = new CompanyDbContext();

            //Employee E01 = new Employee() { Name = "Ahmed", Age = 30, Salary = 30000 };
            //Employee E02 = new Employee() { Name = "Rana", Age = 40, Salary = 40000 };

            //Console.WriteLine(dbContext.Entry(E01).State);  // Added
            //Console.WriteLine(dbContext.Entry(E02).State);  // Detached

            //dbContext.Employees.Add(E01);
            //dbContext.Employees.Add(E02);


            //var employee = from e in dbContext.Employees
            //               where e.Code == 1
            //               select e;

            //if(Employee is not null)
            //{
            //Console.WriteLine(dbContext.Entry(E01).State);

            //    dbContext.Employees.Remove(Employee);
            //    dbContext.SaveChanges();
            //    dbContext.Set<Employee>().Remove(Employee);
            //    dbContext.Remove(Employee);
            //} 
            #endregion
        }
    }
}
