using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b4product;
using ConsoleApp3.dao;
using ConsoleApp3.Entity;

namespace ConsoleApp3.demo
{
    internal class DatebaseDemo
    {
        BaseIdAndName row = new BaseIdAndName();
        List<Product> listProduct = (List<Product>)Database.Instants.selectTable("product");
        List<Category> listCategory = (List<Category>)Database.Instants.selectTable("category");
        List<Accessotion> listAccesory = (List<Accessotion>)Database.Instants.selectTable("accessory");
        public int insertTable(string name, BaseIdAndName row)
        {
            name = Console.ReadLine();
            Database.Instants.insertTable(name, row);
            return 0;
        }
        public int updateTable(string name, BaseIdAndName row)
        {
            name = Console.ReadLine();
            Database.Instants.updateTable(name, row);
            return 0;
        }
        public bool deleteTable(string name, BaseIdAndName row)
        {
            name = Console.ReadLine();
            Database.Instants.deleteTable(name, row);
            return false;
        }
        public void truncateTableTest()
        {
            string name = Console.ReadLine();
            Database.Instants.trucateTable(name);
        }
        public void initDataBase()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Product product = new Product() { Id = random.Next(0, 10), Name = "ProductName" + random.Next(0, 10), categoryId = random.Next(0, 10) };
                Database.Instants.insertTable("product", product);
                Category category = new Category() { Id = random.Next(0, 10), Name = "CategoryName" + random.Next(0, 10) };
                Database.Instants.insertTable("category", category);
                Accessotion accessotion = new Accessotion() { Id = random.Next(0, 10), Name = "accessoryName" + random.Next(0, 10) };
                Database.Instants.insertTable("accessory", accessotion);
            }
        }
        public void printTableTest(BaseIdAndName row)
        {
            var Type = row.GetType().Name;
            if(Type == "Product")
            {
                for (int i = 0; i < listProduct.Count; i++)
                {
                    Console.WriteLine(listProduct[i].Id + " - " + listProduct[i].Name + " - " + listProduct[i].categoryId);
                }
            }
            if(Type == "Category")
            {
                for (int i=0; i < listCategory.Count; i++)
                {
                    Console.WriteLine(listCategory[i].Id + " - " + listCategory[i].Name);
                }
            }
            if (Type == "Accessory")
            {
                for(int i=0; i < listAccesory.Count; i++)
                {
                    Console.WriteLine(listAccesory[i].Id + " - " + listAccesory[i].Name);
                }
            }
        }
        public void updateTableByIdTest()
        {
            int id = int.Parse(Console.ReadLine());
            Database.Instants.updateTableById(id, row);
        }

    }
}
