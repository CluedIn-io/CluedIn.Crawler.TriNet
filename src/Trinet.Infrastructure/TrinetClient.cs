using System;
using System.Net;
using System.Threading.Tasks;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Trinet.Core;
using Newtonsoft.Json;
using RestSharp;
using Microsoft.Extensions.Logging;
using CluedIn.Crawling.Trinet.Core.Models;
using System.Collections.Generic;

namespace CluedIn.Crawling.Trinet.Infrastructure
{
    // TODO - This class should act as a client to retrieve the data to be crawled.
    // It should provide the appropriate methods to get the data
    // according to the type of data source (e.g. for AD, GetUsers, GetRoles, etc.)
    // It can receive a IRestClient as a dependency to talk to a RestAPI endpoint.
    // This class should not contain crawling logic (i.e. in which order things are retrieved)
    public class TrinetClient
    {
        private const string BaseUri = "http://sample.com";

        private readonly ILogger<TrinetClient> log;

        private readonly IRestClient client;

        private readonly TrinetCrawlJobData _trinetCrawlJobData;

        public TrinetClient(ILogger<TrinetClient> log, TrinetCrawlJobData trinetCrawlJobData, IRestClient client) // TODO: pass on any extra dependencies
        {
            if (trinetCrawlJobData == null)
            {
                throw new ArgumentNullException(nameof(trinetCrawlJobData));
            }

            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.log = log ?? throw new ArgumentNullException(nameof(log));
            this.client = client ?? throw new ArgumentNullException(nameof(client));

            // TODO use info from trinetCrawlJobData to instantiate the connection
            client.BaseUrl = new Uri(BaseUri);
            _trinetCrawlJobData = trinetCrawlJobData;
        }

        public IEnumerable<Employee> GetEmployee()
        {
            var authclient = new RestClient("https://api.trinet.com/oauth");
            var authrequest = new RestRequest("accesstoken", Method.GET);
            authrequest.AddParameter("grant_type", "client_credentials");
            authrequest.AddHeader("Authorization", string.Format("Basic {0}", _trinetCrawlJobData.ApiKey));
            var authresponse = authclient.Execute<AuthenticationModel>(authrequest);
            var accessToken = authresponse.Data.AccessToken;

            var client = new RestClient(string.Format("https://api.trinet.com/v1/company/{0}", _trinetCrawlJobData.CompanyId));
            var request = new RestRequest("employees", Method.GET);
            request.AddHeader("grant_type", "client_credentials");
            request.AddHeader("Authorization", string.Format("Bearer {0}", accessToken));
            var response = client.Execute<EmployeeResponse>(request);
            var content = response.Data.Data.EmployeeData;
            return content;
        }

        public AccountInformation GetAccountInformation()
        {
            return new AccountInformation(_trinetCrawlJobData.CompanyId, _trinetCrawlJobData.CompanyId);
        }
    }
}
