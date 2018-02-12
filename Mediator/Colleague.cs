using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Colleague
    {
        protected IMediator<Colleague> Mediator;
        public Colleague(IMediator<Colleague> mediator)
        {
            Mediator = mediator;
        }
    }
}
