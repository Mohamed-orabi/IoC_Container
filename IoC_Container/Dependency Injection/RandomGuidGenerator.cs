using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Container
{
    public class RandomGuidGenerator
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
    }
}
