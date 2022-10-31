using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Entity;

namespace ConsoleApp3.dao
{
    public class AccessoryDao:BaseDao
    {
        /// <summary>
        /// Search for an object in the map by name
        /// </summary>
        /// <param name="name"></param> name of choice
        /// <param name="nameTable"></param> choose one of three table (product, category, accessory)
        /// <param name="row"></param> alternative 
        /// <returns></returns>
        public object findByNameDao(string name, string nameTable, BaseEntity row)
        {
            if (nameTable == "product")
            {
                for (int i = 0; i < Database.Instants.ListProduct().Count; i++)
                {
                    if (name == Database.Instants.ListProduct()[i].Name)
                    {
                        return Database.Instants.ListProduct()[i];
                    }
                }
            }
            if (nameTable == "category")
            {
                for (int i = 0; i < Database.Instants.ListCategory().Count; i++)
                {
                    if (name == Database.Instants.ListCategory()[i].Name)
                    {
                        return Database.Instants.ListCategory()[i];
                    }
                }
            }
            if (nameTable == "accessotion")
            {
                for (int i = 0; i < Database.Instants.ListAccessotion().Count; i++)
                {
                    if (name == Database.Instants.ListAccessotion()[i].Name)
                    {
                        return Database.Instants.ListAccessotion()[i];
                    }
                }
            }
            return null;
        }
    }
}
