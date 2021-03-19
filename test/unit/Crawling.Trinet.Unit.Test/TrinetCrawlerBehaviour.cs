using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Trinet;
using CluedIn.Crawling.Trinet.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Trinet.Unit.Test
{
    public class TrinetCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public TrinetCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<ITrinetClientFactory>();

            _sut = new TrinetCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
