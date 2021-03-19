using System.Collections.Generic;
using CluedIn.Crawling.Trinet.Core;

namespace CluedIn.Crawling.Trinet.Integration.Test
{
  public static class TrinetConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { TrinetConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
