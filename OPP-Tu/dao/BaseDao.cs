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
        /// input data from one of three table product, category or accessotion
        /// @param row=choose one of three table(product, category, accessotion)
        /// @param name
        /// returns true if if successful false if not
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
        /// update data from one of three table(product, category, accessotion)
        /// @param name="name"choose one of three table(product, category, acessotion)
        /// @param name="row"data from one of three table(product,category, accessotion)
        /// returns 1 if successful, else 0
        public int updateDao(string name, BaseEntity row)
        {
            Database.Instants.updateTable(name, row);
            return 0;
        }
        /// delete one of three table
        /// @param name="name"choose one of three table(product, category, acessotion)</param>
        /// @param name="row" location to be delete</param>
        /// returns true if successful
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
        /// return one of three table(product, category, acessotion)
        /// @param name="name"choose one of three table(product, category, acessotion)
        /// returns one of three table(product, category, acessotion)
        public object findAllDao(string name)
        {
            return Database.Instants.selectTable(name);
        }
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
