using CluedIn.Crawling.Trinet.Core;

namespace CluedIn.Crawling.Trinet
{
    public class TrinetCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<TrinetCrawlJobData>
    {
        public TrinetCrawlerJobProcessor(TrinetCrawlerComponent component) : base(component)
        {
        }
    }
}
