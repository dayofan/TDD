using Microsoft.Extensions.DependencyInjection;
using StructureMap;
using System;

namespace TDD
{
    public class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection()
                .AddSingleton<IDatabaseHelper, DatabaseHelper>();

            var container = new Container();
            container.Configure(config => 
            {
                config.Scan(_ =>
                {
                    _.AssembliesFromApplicationBaseDirectory();
                    _.WithDefaultConventions();
                });

                config.Populate(services);
            });

            var serviceProvider = container.GetInstance<IServiceProvider>();
        }
    }
}
