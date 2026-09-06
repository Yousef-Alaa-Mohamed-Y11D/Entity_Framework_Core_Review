using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework_Core_Review
{
    public static class CRUD
    {
        //static ApplicationDbContext Db = new ApplicationDbContext();
        //public static void AddEmployee( string Name)
        //{
        //    Db.Employees.Add(new Employee { Name = Name });
        //    Db.SaveChanges();
        //    Console.WriteLine("Add Sucsss...");
        //}

        //public static void GetAll()
        //{
        //    var employees = Db.Employees.ToList();
        //    foreach (var emp in employees)
        //    {
        //        Console.WriteLine($"ID : {emp.ID} | Name : {emp.Name}");
        //    }

        //}

        //public static void GetById(int id)
        //{
        //    if(id == 0 && id == null)
        //    {
        //        Console.WriteLine("Id NotFound.");
        //    }
        //    var emp = Db.Employees.FirstOrDefault(x => x.ID == id);
        //    Console.WriteLine($"Name : {emp?.Name}");
        //}
    }
}
