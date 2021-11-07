using System;

namespace IoC_Container
{
    class Program
    {
        static void Main(string[] args)
        {

            var services = new DiServiceCollection();

            //services.RegisterSingleton(new RandomGuidGenerator());
            //services.RegisterSingleton<RandomGuidGenerator>();
            //services.RegisterTransient<RandomGuidGenerator>();
            
            
            services.RegisterSingleton<IPrintFullName, PrintClass2>();
            var serviceProvider = services.ServiceProvider();

            var service1 = serviceProvider.GetService<IPrintFullName>();
            
            service1.print();

            //var service1 = serviceProvider.GetService<RandomGuidGenerator>();
            //var service2 = serviceProvider.GetService<RandomGuidGenerator>();

            //Console.WriteLine(service1.Guid);
            //Console.WriteLine(service2.Guid);
            Console.ReadKey();
        }
    }
}
