using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IoC_Container
{
    public class DiServiceProvider
    {
        private List<ServiceDescriptor> _serviceDescriptors;
        public DiServiceProvider(List<ServiceDescriptor> serviceDescriptors)
        {
            _serviceDescriptors = serviceDescriptors;
        }

        public T GetService<T>()
        {
            var getService = _serviceDescriptors.SingleOrDefault(x => x.Type == typeof(T));

            if(getService == null)
            {
                throw new Exception($"Service of type {typeof(T).Name} isn't resolved");
            }

            if (getService.Implementation != null)
            {
                return (T)getService.Implementation;
            }

            var implementation = (T)Activator.CreateInstance(getService.ImplementationType ?? getService.Type);

            if(getService.Lifetime == ServiceLifetime.Singleton)
            {
              getService.Implementation = implementation;
            }

            return implementation;
        }
    }
}
