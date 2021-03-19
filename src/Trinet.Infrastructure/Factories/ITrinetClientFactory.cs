using CluedIn.Crawling.Trinet.Core;

namespace CluedIn.Crawling.Trinet.Infrastructure.Factories
{
    public interface ITrinetClientFactory
    {
        TrinetClient CreateNew(TrinetCrawlJobData trinetCrawlJobData);
    }
}
