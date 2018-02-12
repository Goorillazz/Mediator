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
        protected IMediator Mediator;
        public Colleague(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
