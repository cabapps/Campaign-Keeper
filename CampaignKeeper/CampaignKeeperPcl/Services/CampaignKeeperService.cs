using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Services
{
    public class CampaignKeeperService
    {
        public IList<string> Messages { get; set; }

        public CampaignKeeperService()
        {
            Messages = new List<string>();
        }

        #region Public Methods
        public async Task<IList<TItem>> GetItems<TItem>(string apiPath) where TItem : Item, new()
        {
            using (var client = new HttpClient())
            {
                SetClient(client);
                var response = await client.GetAsync(apiPath);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IList<TItem>>();
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<TItem> Get<TItem>(int id, string apiPath) where TItem : Item, new()
        {
            using (var client = new HttpClient())
            {
                SetClient(client);
                var response = await client.GetAsync($"{apiPath}/{id.ToString()}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<TItem>();
                }
                else
                {
                    await ParseResponse(response);
                    return null;
                }
            }
        }

        public async Task Post<TItem>(TItem item, string apiPath) where TItem : Item
        {
            using (var client = new HttpClient())
            {
                SetClient(client);              
                var response = await client.PostAsJsonAsync(apiPath, item);
                if (response.IsSuccessStatusCode)
                {

                }
                else
                {
                    await ParseResponse(response);
                }
            }
        }

        public async Task Put<TItem>(TItem item, string apiPath) where TItem : Item
        {
            using (var client = new HttpClient())
            {
                SetClient(client);
                var response = await client.PutAsJsonAsync($"{apiPath}/{item.Id}", item);
                var code = response.StatusCode;
                await ParseResponse(response);
            }
        }

        public async Task Delete<TItem>(TItem item, string apiPath) where TItem : Item
        {
            using (var client = new HttpClient())
            {
                SetClient(client);
                var response = await client.DeleteAsync($"{apiPath}/{item.Id}");
                var code = response.StatusCode;
            }
        }
        #endregion


        protected virtual async Task<bool> ParseResponse(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode && response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var json = JObject.Parse((await response.Content.ReadAsStringAsync()));
            }
            else if (!response.IsSuccessStatusCode)
            {
                Messages.Add(response.ReasonPhrase);
            }
            return response.IsSuccessStatusCode;
        }

        protected void SetClient(HttpClient client)
        {
            client.BaseAddress = CampaignKeeperServiceSettings.ApiBaseUri;
        }


    }
}
