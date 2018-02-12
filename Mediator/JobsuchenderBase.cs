namespace Mediator
{
    public abstract class JobsuchenderBase : Colleague
    {
        protected readonly Jobcenter Jobcenter;

        protected JobsuchenderBase(Jobcenter jobcenter, IMediator mediator) : base(mediator)
        {
            Jobcenter = jobcenter;
        }

        public abstract void BegutachtetJob(string text, int id);
    }
}