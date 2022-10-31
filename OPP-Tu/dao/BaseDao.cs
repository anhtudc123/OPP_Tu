using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Entity;

namespace ConsoleApp3.dao
{
    public interface IDao
    {
        bool insertDao(BaseEntity row, String name);
        int updateDao(string name, BaseEntity row);
        bool deleteDao(string name, BaseEntity row);
        object findAllDao(string name);
        object findByIdDao(int id, string nameTable);
    }
    public class BaseDao:IDao
    {
        /// <summary>
        /// input data from one of three table(product, category, accessotion)
        /// </summary>
        /// <param name="row">choose one of three table(product, category, accessotion)</param> 
        /// <param name="name">inserted name</param> 
        /// <returns>true if successful, false if not</returns> 
        public bool insertDao(BaseEntity row, String name)
        {
            try
            {
                Database.Instants.insertTable(name, row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// update data from one of three table(product, category, accessotion)
        /// </summary>
        /// <param name="name">hoose from one of three table(product, category, accessotion)</param> c
        /// <param name="row">data from one of three table(product, category, accessotion)</param> 
        /// <returns>0 if successful</returns> 
        public int updateDao(string name, BaseEntity row)
        {
            Database.Instants.updateTable(name, row);
            return 0;
        }
        /// <summary>
        /// delelte one of three table
        /// </summary>
        /// <param name="name">name of one table</param> 
        /// <param name="row">location from one of three table(product, category, accessotion)</param> 
        /// <returns> true if successful, else false</returns>
        public bool deleteDao(string name, BaseEntity row)
        {
            try
            {
                Database.Instants.deleteTable(name, row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// return one of three table(product, category, acessotion)
        /// </summary>
        /// <param name="name">choose one of three table</param> 
        /// <returns>chosen table</returns> 
        public object findAllDao(string name)
        {
            return Database.Instants.selectTable(name);
        }
        /// <summary>
        /// find table name through id
        /// </summary>
        /// <param name="id">id of a table in three table</param>
        /// <param name="name">name of a table</param> 
        /// <returns>a product in the table</returns> 
        public object findByIdDao(int id, string name)
        {
            if (name == "product")
            {
                for (int i = 0; i < Database.Instants.ListProduct().Count; i++)
                {
                    if (id == Database.Instants.ListProduct()[i].Id)
                    {
                        return Database.Instants.ListProduct()[i];
                    }
                }
            }
            if (name == "category")
            {
                for (int i = 0; i < Database.Instants.ListCategory().Count; i++)
                {
                    if (id == Database.Instants.ListCategory()[i].Id)
                    {
                        return Database.Instants.ListCategory()[i];
                    }
                }
            }
            if (name == "accessotion")
            {
                for (int i = 0; i < Database.Instants.ListAccessotion().Count; i++)
                {
                    if (id == Database.Instants.ListAccessotion()[i].Id)
                    {
                        return Database.Instants.ListAccessotion()[i];
                    }
                }
            }
            return null;
        }

    }
}
