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

        public async Task<Event> GetEvent(User user)
        {
            var City = user.City;
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                await client.GetAsync($"api.eventful" +
                $".com/json/events/search?...&location={City}"+
                $"{APIKeys.EventfulApiKey}");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Event>(json);
            }
            return null;
        }
    }
}
