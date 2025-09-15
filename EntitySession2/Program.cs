using EntitySession2.Data;
using EntitySession2.Data.Configurations;
using EntitySession2.Models;
using Microsoft.EntityFrameworkCore;

namespace EntitySession2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Enities02Dbcontext dbcontext = new Enities02Dbcontext();
            dbcontext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;

            #region Create
            //Employee employee = new Employee()
            //{

            //    Age = 27,
            //    Salary = 5000,
            //    EmpName = "Sayed"



            //};



            //dbcontext.Employees.Add(employee);
            //var state = dbcontext.Entry(employee).State;
            //Console.WriteLine("before Add");
            //Console.WriteLine(state);
            //dbcontext.SaveChanges();
            //Console.WriteLine("after changes");
            //var state2 = dbcontext.Entry(employee).State;
            //Console.WriteLine(state2);

            //Employee employee = new Employee()
            //{

            //    Age = 33,
            //    Salary = 504350,
            //    EmpName = "hesham"



            //};
            //dbcontext.Employees.Add(employee);
            //dbcontext.SaveChanges();

            #endregion


            #region readData
           var employee= dbcontext.Employees.SingleOrDefault(e => e.EmpId == 1);
            if (employee != null)
            {
                Console.WriteLine($"{employee.EmpName} - {employee.Salary} ");
            }
            #endregion
        }
    }
}
