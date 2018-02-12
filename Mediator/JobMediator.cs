using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class JobMediator : IMediator<Colleague>
    {
        public JobMediator()
        {
            Jobsuchender = new List<JobsuchenderBase>();
        }

        public List<JobsuchenderBase> Jobsuchender { get; }
        public Jobcenter Jobcenter { get; set; }

        public void Send(string message, Colleague clo)
        {
            if (clo is JobsuchenderBase)
            {
                int id = Convert.ToInt32(message);
                Jobcenter.AkzeptiereJob(id);
            }
            else
            {
                var textUndId = message.Split('_');
                Jobsuchender.ForEach(j => j.BegutachtetJob(textUndId.ElementAt(0), Convert.ToInt32(textUndId.ElementAt(1))));
            }
        }
    }
}
