using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ListTaskLab.Models;
using ListTaskLab.Options;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ListTasks
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            StoreAllTasks.listTasks = await returnTasks();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static async Task<List<Data>> returnTasks()
        {
            using (var client = new HttpClient())
            {
                var url = new Uri($"https://jsonplaceholder.typicode.com/todos");
                var response = await client.GetAsync(url);
                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                return JsonConvert.DeserializeObject<List<Data>>(json);
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
