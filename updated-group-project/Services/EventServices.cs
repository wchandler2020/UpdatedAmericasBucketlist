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
>>>>>>> 8377d666caf7da4097235ebd8c68382d6480f4ed
            var City = "Chicago";
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                await client.GetAsync($"http://api.eventful" +
                $".com/json/events/search?...&location={City}"+
                $"&date=Future &app_key={APIKeys.EventfulApiKey}");
<<<<<<< HEAD

=======
>>>>>>> 8377d666caf7da4097235ebd8c68382d6480f4ed

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<EventObject>(json);
            }
            return null;
        }
    }
}
