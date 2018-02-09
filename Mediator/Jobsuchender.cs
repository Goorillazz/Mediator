using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Jobsuchender : JobsuchenderBase
    {
        private readonly Jobcenter _jobcenter;

        public Jobsuchender(Jobcenter jobcenter) : base(jobcenter)
        {
            
        }

        public override void BegutachtetJob(string text, int id)
        {
            var random = new Random();
            var okay = random.Next() % 2 == 0;

            if (okay)
            {
                _jobcenter.AkzeptiereJob(id);
            }

        }

        
    }
}
