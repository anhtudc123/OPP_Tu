using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entity
{
    interface IEntity
    {
        int Id { get; set; }
        string Name { get; set; }
    }
    public class BaseEntity:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
