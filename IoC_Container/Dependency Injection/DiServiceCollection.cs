using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Container
{
    public class DiServiceCollection
    {
        private List<ServiceDescriptor> serviceDescriptors = new List<ServiceDescriptor>();

        public void RegisterSingleton<TService>(TService service)
        {
            serviceDescriptors.Add(new ServiceDescriptor(service, ServiceLifetime.Singleton));
        }

        public void RegisterSingleton<TService>()
        {
            serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Singleton));
        }
        public void RegisterSingleton<TService,TImplementation>()
        {
            serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Singleton));
        }

        public void RegisterTransient<TService>()
        {
            serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Transient));
        }

        public DiServiceProvider ServiceProvider()
        {
            return new DiServiceProvider(serviceDescriptors);
        }
    }
}
