namespace Mediator
{
    public abstract class JobsuchenderBase
    {
        protected readonly Jobcenter Jobcenter;

        protected JobsuchenderBase(Jobcenter jobcenter)
        {
            Jobcenter = jobcenter;
        }

        public abstract void BegutachtetJob(string text, int id);
    }
}