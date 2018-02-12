using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Jobsuchender : JobsuchenderBase
    {
        public Jobsuchender(Jobcenter jobcenter, IMediator mediator) : base(jobcenter, mediator)
        {
            
        }

        public override void BegutachtetJob(string text, int id)
        {
            var random = new Random();
            var okay = random.Next() % 2 == 0;

            if (okay)
            {
                Jobcenter.AkzeptiereJob(id);
            }

        }

        
    }
}
