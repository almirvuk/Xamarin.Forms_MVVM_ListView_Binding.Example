using CarsExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace CarsExample.Utils {

    public class MyHTTP {

        // Get new data rows
        public static async Task GetAllNewsAsync(Action<IEnumerable<Car>> action) {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://api.myjson.com/bins/jly7p");

            if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                var list = JsonConvert.DeserializeObject<IEnumerable<Car>>(await response.Content.ReadAsStringAsync());
                action(list);
            }

        }
    }
}
