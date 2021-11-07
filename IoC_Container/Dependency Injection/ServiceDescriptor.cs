using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Container
{
    public class ServiceDescriptor
    {
        public Type Type { get; }
        public Type ImplementationType { get; }
        public Object Implementation { get;  set; }
        public ServiceLifetime Lifetime { get;  }

        public ServiceDescriptor(object implementation, ServiceLifetime lifeTime)
        {
            Type = implementation.GetType();
            Implementation = implementation;
            Lifetime = lifeTime;
        }

        public ServiceDescriptor(Type type, ServiceLifetime lifeTime)
        {
            Type = type;
            Lifetime = lifeTime;
        }
        public ServiceDescriptor(Type type,Type implementation, ServiceLifetime lifeTime)
        {
            Type = type;
            ImplementationType = implementation;
            Lifetime = lifeTime;
        }
    }


}
