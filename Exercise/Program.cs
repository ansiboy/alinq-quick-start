using System;
using System.Linq;
using ALinq;
using ALinq.Mapping;
using NorthwindDemo;
using System.Reflection;

namespace ALinqQuickStart.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var db = new SQLiteNorthwind("Northwind.db3");
            var custQuery = db.Customers.Where(c => c.City == "London");

            foreach (Customer custObj in custQuery)
            {
                Console.WriteLine("CustomerID: {0}", custObj.CustomerID);
                Console.WriteLine("\tOriginal value: {0}", custObj.City);
                custObj.City = "Paris";
                Console.WriteLine("\tUpdated value: {0}", custObj.City);
            }

            ChangeSet cs = db.GetChangeSet();
            Console.Write("Total changes: {0}", cs);
            // Freeze the console window.
            Console.ReadLine();

            db.SubmitChanges();

           
        }

        static void t()
        {
var db = new SQLiteNorthwind("Northwind.db3");

Customer newCust = new Customer();
newCust.City = "Auburn";
newCust.CustomerID = "AUBUR";
newCust.CompanyName = "AubCo";
db.Customers.InsertOnSubmit(newCust);

try
{
    db.SubmitChanges(ConflictMode.ContinueOnConflict);
}
catch (ChangeConflictException e)
{
    Console.WriteLine("Optimistic concurrency error.");
    Console.WriteLine(e.Message);
    Console.ReadLine();
    foreach (ObjectChangeConflict occ in db.ChangeConflicts)
    {
        MetaTable metatable = db.Mapping.GetTable(occ.Object.GetType());
        Customer entityInConflict = (Customer)occ.Object;
        Console.WriteLine("Table name: {0}", metatable.TableName);
        Console.Write("Customer ID: ");
        Console.WriteLine(entityInConflict.CustomerID);
        foreach (MemberChangeConflict mcc in occ.MemberConflicts)
        {
            object currVal = mcc.CurrentValue;
            object origVal = mcc.OriginalValue;
            object databaseVal = mcc.DatabaseValue;
            MemberInfo mi = mcc.Member;
            Console.WriteLine("Member: {0}", mi.Name);
            Console.WriteLine("current value: {0}", currVal);
            Console.WriteLine("original value: {0}", origVal);
            Console.WriteLine("database value: {0}", databaseVal);
        }
    }
}
catch (Exception ee)
{
    // Catch other exceptions.
    Console.WriteLine(ee.Message);
}
finally
{
    Console.WriteLine("TryCatch block has finished.");
}
        }
    }


}
