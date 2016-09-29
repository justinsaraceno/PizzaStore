using Microsoft.Extensions.DependencyInjection;
using PizzaDomain;
using PizzaStore.PizzaMakers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create an injectable collection of services
            IServiceCollection services = new ServiceCollection();

            // map instances of IPizzaMaker to the concrete maker
            services.AddSingleton<IPizzaMaker, PapaGinos>();
        }
    }
}
