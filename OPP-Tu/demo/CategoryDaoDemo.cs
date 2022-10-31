using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.dao;
using ConsoleApp3.Entity;

namespace ConsoleApp3.demo
{
    internal class CategoryDaoDemo
    {
        Category category=new Category();
        public void insertTest()
        {
            Database.Instants.insertTable("category", category);
        }
        public void updateTest()
        {
            int id = int.Parse(Console.ReadLine());
            Database.Instants.updateTableById(id, category);
        }
        public void deleteTest()
        {
            Database.Instants.deleteTable("category", category);
        }
        public object findAllTest()
        {
            return Database.Instants.selectTable("category");
        }
        public void updateTest(BaseEntity row)
        {
            Database.Instants.updateTableById(row.Id, row);
        }
    }
}
