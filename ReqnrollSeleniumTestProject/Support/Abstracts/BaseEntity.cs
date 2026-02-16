namespace ReqnrollSeleniumTestProject.Support.Abstracts
{
    [Binding]
    public abstract class BaseEntity
    {
        protected static readonly ServiceContainer ServiceContainer;

        static BaseEntity()
        {
            ServiceContainer = ServiceContainer.Instance;
        }
    }
}
