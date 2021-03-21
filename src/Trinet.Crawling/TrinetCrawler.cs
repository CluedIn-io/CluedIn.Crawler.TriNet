using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Trinet.Core;
using CluedIn.Crawling.Trinet.Infrastructure.Factories;

namespace CluedIn.Crawling.Trinet
{
    public class TrinetCrawler : ICrawlerDataGenerator
    {
        private readonly ITrinetClientFactory clientFactory;
        public TrinetCrawler(ITrinetClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is TrinetCrawlJobData trinetcrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(trinetcrawlJobData);

            //retrieve data from provider and yield objects

            foreach (var employee in client.GetEmployee())
            {
                yield return employee;
            }
        }       
    }
}
