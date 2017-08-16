using System;
using System.Linq;
using ALinq;
using ALinq.Mapping;

namespace ALinqQuickStart.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dc = new Northwind();
            dc.Log = Console.Out;
            var categories = dc.Categories.Where(c => c.CategoryID > 1);
            foreach (var c in categories)
            {
                Console.WriteLine("{0} {1} {2}", c.CategoryID, c.CategoryName, c.Description);
            }

            var category = dc.Categories.Single(o => o.CategoryID == 2);
            category.CategoryName = "Computer";
            dc.SubmitChanges();
        }
    }

    [Table(Name = "Categories")]
    public class Category
    {
        [Column(Name = "CategoryID", IsPrimaryKey = true)]
        public int CategoryID { get; set; }

        [Column(Name = "CategoryName", UpdateCheck = UpdateCheck.Never)]
        public string CategoryName { get; set; }

        [Column(Name = "Description", UpdateCheck = UpdateCheck.Never)]
        public string Description { get; set; }

        [Column(Name = "Picture", UpdateCheck = UpdateCheck.Never)]
        public Binary Picture { get; set; }
    }

    [Provider(typeof(ALinq.SQLite.SQLiteProvider))]
    public class Northwind : DataContext
    {
        static string dbPath = "Northwind.db3";

        public Northwind() : base(dbPath)
        {
        }

        public Table<Category> Categories
        {
            get
            {
                return this.GetTable<Category>();
            }
        }
    }
}
