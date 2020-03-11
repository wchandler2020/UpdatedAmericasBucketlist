using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using updated_group_project.Interfaces;
using updated_group_project.Models;
using updated_group_project.Views;

namespace updated_group_project.Services
{
    public class EventServices: IEventService
    {
        public EventServices()
        {

        }

        public async Task<EventObject> GetEvent()
        {
<<<<<<< HEAD

=======
>>>>>>> 6a405484ccd804595022bb4a73dfc52c686cd8a4
            var City = "Chicago";
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                await client.GetAsync($"http://api.eventful" +
                $".com/json/events/search?...&location={City}"+
                $"&date=Future &app_key={APIKeys.EventfulApiKey}");
<<<<<<< HEAD

=======
>>>>>>> 6a405484ccd804595022bb4a73dfc52c686cd8a4

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<EventObject>(json);
            }
            return null;
        }
    }
}
