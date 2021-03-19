using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Trinet.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Trinet.Unit.Test.TrinetProvider
{
    public abstract class TrinetProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<ITrinetClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected TrinetProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<ITrinetClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Trinet.TrinetProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
