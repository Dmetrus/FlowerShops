
using FlowerShops.Context.Contracts.Interface;
using FlowerShops.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Context
{
    public class FlowerShopsContext :
        IFlowerShopsContext
       
    {
        public List<Location> Locations { get; set; }
        public List<Order> Orders { get; set; }
        public List<Person> Persons { get; set; }
        public List<Product> Products { get; set; }

        public List<Service> Services { get; set; }

        public List<Worker> Workers { get; set; }

        public FlowerShopsContext()
        {
                
        }
       
    }
}
