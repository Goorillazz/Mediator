using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Jobcenter
    {
        public Jobcenter()
        {
            Jobsuchender = new List<JobsuchenderBase>();
        }

        private readonly Dictionary<int, string> _jobs = new Dictionary<int, string>();

        public List<JobsuchenderBase> Jobsuchender { get; set; }
        
        public void MeldeJob(string text, int id)
        {
            if (_jobs.ContainsKey(id))
                return;

            _jobs.Add(id, text);

            Jobsuchender.ForEach(j => j.BegutachtetJob(text,id));
        }


        public void AkzeptiereJob(int id)
        {
            if (_jobs.ContainsKey(id))
            {
                _jobs.Remove(id);
            }
        }
    }
}
