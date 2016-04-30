using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Services
{
    public abstract class CampaignKeeperService
    {
        protected CampaignKeeperServiceSettings settings;
        public IList<string> Messages { get; set; }

        public CampaignKeeperService(CampaignKeeperServiceSettings settings)
        {
            this.settings = settings;
            Messages = new List<string>();
        }

        protected virtual async Task<bool> ParseResponse(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode && response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var json = JObject.Parse((await response.Content.ReadAsStringAsync()));
            }
            else if (!response.IsSuccessStatusCode)
            {
                this.Messages.Add(response.ReasonPhrase);
            }
            return response.IsSuccessStatusCode;
        }

        protected void SetClient(HttpClient client)
        {
            client.BaseAddress = this.settings.ApiBaseUri;
        }
    }
}
