using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Services
{
    public class LocationService : CampaignKeeperService
    {
        public LocationService(CampaignKeeperServiceSettings settings) : base(settings) { }

        public async Task<IList<Location>> GetLocations()
        {
            using (var client = new HttpClient())
            {
                SetClient(client);
                var response = await client.GetAsync(settings.LocationsPath);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IList<Location>>();
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task PostLocation(Location location)
        {
            using (var client = new HttpClient())
            {
                SetClient(client);
                string path = string.Empty;
                HttpResponseMessage response = null;
                path = settings.LocationsPath;
                response = await client.PostAsJsonAsync(path, location);
                var code = response.StatusCode;
            }
        }
    }
}
