using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzaDomain;
using PizzaStore.PizzaMakers;
using System;
using System.Collections.Generic;
using System.IO;

namespace PizzaStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Enable to app to read json setting files
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.GetFullPath(Directory.GetCurrentDirectory()))
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            var configuration = builder.Build();

            // the toppings JSON collection must be got as a section because it's being treated as a dictionary
            var toppingsSection = configuration.GetSection("toppings");
            var toppings = new List<string>();
            toppingsSection.Bind(toppings);

            // create an injectable collection of services
            IServiceCollection services = new ServiceCollection();

            // map instances of IPizzaMaker to the concrete maker
            services.AddSingleton<IPizzaMaker, ZPizza>();

            // create a provider for the mapped services
            IServiceProvider provider = services.BuildServiceProvider();

            // get the mapped instance of IPizzaMaker
            IPizzaMaker pizzaMaker = provider.GetService<IPizzaMaker>();

            var customer = configuration.GetValue<string>("customer");

            // order some pizza
            Console.WriteLine($"Ordering a Large Peperoni & Onion for: {customer}");
            Console.WriteLine();
            pizzaMaker.TakeOrder(Size.Large, new List<string> { "peperoni", "onion" });
            Console.ReadLine();
        }
    }
}
