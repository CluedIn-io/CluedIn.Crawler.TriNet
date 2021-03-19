using CluedIn.Core;
using CluedIn.Crawling.Trinet.Core;

using ComponentHost;

namespace CluedIn.Crawling.Trinet
{
    [Component(TrinetConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class TrinetCrawlerComponent : CrawlerComponentBase
    {
        public TrinetCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

