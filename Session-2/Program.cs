using Session_2.Contexts;

namespace Session_2
{
    internal class Program
    {
        static void Main()
        {
            #region CRUD Operation 
            // CRUD Operation 
            // Create - Reade - Update - Delete
            //
            //


            //AppDbContext context = new AppDbContext();

            //context.Dispose();


            using AppDbContext context = new AppDbContext();

            #region Create - Insert 
            //// Create - Insert 

            //var employee = new Employee()
            //{
            //    Name = "Mohamed Ali",
            //    Salary = 12000,
            //    Address = "Cairo",
            //    Age = 25
            //};

            //Console.WriteLine(context.Entry(employee).State); // Detached

            //employee.Name = "Khaled";

            //Console.WriteLine(context.Entry(employee).State); // Detached

            //context.Employees.Add(employee);

            //Console.WriteLine(context.Entry(employee).State); // Added

            //var Result = context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State); // Unchanged

            //employee.Name = "Omar";

            //Console.WriteLine(context.Entry(employee).State); // Modified


            //Console.WriteLine(Result);


            //context.Employees.Add(employee);
            //context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State); 
            //context.Entry(employee).State = EntityState.Added;
            //Console.WriteLine(context.Entry(employee).State);

            //context.SaveChanges(); 
            #endregion

            #region Read - Select
            // Read - Select 

            //var Result = context.Employees.Where(E => E.Id == 40).FirstOrDefault();
            //var Result = context.Employees.FirstOrDefault(E => E.Id == 40);

            //Console.WriteLine(Result?.Name);
            //Console.WriteLine(Result?.Id);


            //var Result = context.Employees.Select(E => E.Name);

            //foreach ( var item in Result )
            //{
            //    Console.WriteLine( item );
            //}

            #endregion

            #region Update
            // Update 
            //var Result = context.Employees.FirstOrDefault(E => E.Id == 40);

            //Console.WriteLine(context.Entry(Result).State);

            //Result.Name = "Omar Ahmed";

            //Console.WriteLine(context.Entry(Result).State);

            //context.SaveChanges(); 
            #endregion

            #region Delete
            // Delete

            //var Result = context.Employees.FirstOrDefault(E => E.Id == 80);
            //context.Employees.Remove(Result);
            //context.SaveChanges(); 

            #endregion

            #endregion






        }
    }
}
