using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.dao;
using ConsoleApp3.Entity;

namespace ConsoleApp3.demo
{
    public class ProductDaoDemo
    {
        Database Data = new Database();

        public bool insertTest(BaseIdAndName row)
        {
            try
            {
                Data.insertProductTable(row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int updateTest(BaseIdAndName row)
        {
            Data.updateProductTable(row.Id, row);
            return 0;
        }
        public bool deleteTest(BaseIdAndName row)
        {
            try
            {
                Data.deleteProduct(row.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public object findAllTest()
        {
            return Data.selectTable("product");
        }
        public object findById(int id)
        {
            for (int i = 0; i < Data.ListProduct().Count; i++)
            {
                if (id == Data.ListProduct()[i].Id)
                {
                    return Data.ListProduct()[i];
                }
                
            }
            return null;
        }
        public object findByNameTest(string name)
        {
            int n = Data.ListProduct().Count;
            for (int i = 0; i < n; i++)
            {
                if (name == Data.ListProduct()[i].Name)
                {
                    return Data.ListProduct()[i];
                }
                
            }
            return null;
        }
    }
}
