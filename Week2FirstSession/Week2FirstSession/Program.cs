using Week2FirstSession;
using System;
using System.Numerics;


class Program

{
    static void Main(string[] args)
    {
        #region Employee_array
        /* Employee[] employees = new Employee[10];
         int index;
         string flag;

         do
         {
             do
             {
                 Console.WriteLine("Choose index 0 -> 9:");
                 index = int.Parse(Console.ReadLine());
             } while (index < 0 || index > 9);

             employees[index] = new Employee();

             Console.WriteLine("Enter id:");
             employees[index].SetId(int.Parse(Console.ReadLine()));

             Console.WriteLine("Enter name:");
             employees[index].SetName(Console.ReadLine());

             do
             {
                 Console.WriteLine("Enter age (18 - 60):");
                 employees[index].SetAge(int.Parse(Console.ReadLine()));
             } while (employees[index].GetAge() < 18 || employees[index].GetAge() > 60);
             do {
                 Console.WriteLine("Enter salary:");
                 employees[index].SetSalary(decimal.Parse(Console.ReadLine()));
             } while (employees[index].GetSalary()<1000||employees[index].GetSalary()>20000);

             Console.WriteLine("Continue, yes or no?");
             flag = Console.ReadLine();
         }
         while (flag.ToLower() == "yes");

         Console.WriteLine("\nEntered Employees:");
         for (int i = 0; i < employees.Length; i++)
         {
             if (employees[i] != null)
             {
                 Console.WriteLine($"\nEmployee at index {i}:");
                 Console.WriteLine($"ID: {employees[i].GetId()}");
                 Console.WriteLine($"Name: {employees[i].GetName()}");
                 Console.WriteLine($"Age: {employees[i].GetAge()}");
                 Console.WriteLine($"Salary: {employees[i].GetSalary()}");
             }
         }*/
        #endregion



        #region complex
        Complex c1 = new Complex();
        Complex c2 = new Complex();
        Complex c3 = new Complex();
       
        c1.SetReal(1);
        c1.SetImg(-4);

        c2.SetReal(0);
        c2.SetImg(-5);

        Console.WriteLine(c1.Print());
        Console.WriteLine(c2.Print());

       
        c3 = c1.Add(c2);

        Console.WriteLine(c3.Print());

        #endregion

    }
}


