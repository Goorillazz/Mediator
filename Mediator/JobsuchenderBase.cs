namespace Mediator
{
    public abstract class JobsuchenderBase : Colleague
    {
        protected JobsuchenderBase(IMediator<Colleague> mediator) : base(mediator)
        {
        }

        public abstract void BegutachtetJob(string text, int id);
    }
}