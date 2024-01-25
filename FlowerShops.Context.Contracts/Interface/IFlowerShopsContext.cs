using FlowerShops.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Context.Contracts.Interface
{
    public interface IFlowerShopsContext
    {
        /// <summary>Список <inheritdoc cref="Models.Location"/></summary>
        List<Location> Locations { get; }

        /// <summary>Список <inheritdoc cref="Models.Order"/></summary>
        List<Order> Orders { get; }

        /// <summary>Список <inheritdoc cref="Models.Person"/></summary>
        List<Person> Persons { get; }

        /// <summary>Список <inheritdoc cref="Product"/></summary>
        List<Product> Products { get; }

        /// <summary>Список <inheritdoc cref="Service"/></summary>
        List<Service> Services { get; }

        /// <summary>Список <inheritdoc cref="Worker"/></summary>
        List<Worker> Workers { get; }

       
    }
}

