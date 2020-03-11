﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using updated_group_project.Interfaces;
using updated_group_project.Models;
using updated_group_project.Views;

namespace updated_group_project.Service
{
    public class WeatherService: IWeatherService 
    {
        public WeatherService()
        {

        }

        public async Task<Weather>GetWeather(User user)
        {
            var city = user.profile.City;
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                await client.GetAsync($"api.openweathermap" +
                $".org/data/2.5/weather?q={city}&appid =" +
                $"{APIKeys.OpenWeatherKey}");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Weather>(json);
            }
            return null;
        }
    }
}