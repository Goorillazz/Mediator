using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Jobcenter : Colleague
    {
        public Jobcenter(IMediator<Colleague> mediator) : base(mediator)
        {
        }

        private readonly Dictionary<int, string> _jobs = new Dictionary<int, string>();

        
        
        public void MeldeJob(string text, int id)
        {
            if (_jobs.ContainsKey(id))
                return;

            _jobs.Add(id, text);

            Mediator.Send(text + "_" + id.ToString(),this);            
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
