namespace IntegrationTest.Services
{
    using Microsoft.Extensions.DependencyInjection;
    using Repository.XMLData;
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class StartDI
    {
        private static IServiceProvider ServiceProvider { get; set; }
        public static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IXMLStruct, XMLStruct>();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
