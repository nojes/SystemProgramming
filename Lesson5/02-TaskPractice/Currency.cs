using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace _02_TaskPractice
{
    public class Currency
    {
        private string url = @"https://api.privatbank.ua/p24api/exchange_rates?json&date=";

        private List<string> currencyList;
        public Task task;
        DateTime startDate;

        public Currency(DateTime startDate)
        {
            this.startDate = startDate;
            currencyList = new List<string>();
        }

        public override string ToString()
        {
            string str = "";

            foreach (string c in currencyList) {
                str += $"{c}\n";
            }

            return str;
        }

        public void ConsoleWrite()
        {
            Console.WriteLine(this.ToString());
        }

        private void GetRates()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                url + startDate.ToShortDateString()
            );

            string answer = string.Empty;

            using (WebResponse response = request.GetResponse()) {
                using (StreamReader rd = new StreamReader(response.GetResponseStream())) {
                    answer = rd.ReadToEnd();
                }
            }

            var servicedata = JsonConvert.DeserializeObject<UserServices>(answer, new IsoDateTimeConverter {
                DateTimeFormat = "dd.MM.yyyy"
            });

            foreach (var item in servicedata.exchangeRate) {
                if (item.currency == "USD") {
                    currencyList.Add($"{startDate.ToShortDateString()} - USD {item.purchaseRate}");
                }
            }

            startDate = startDate.AddDays(1);
        }

        public void Run()
        {
            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}]: Loading purchase rates...");

            while (startDate < DateTime.Now)
            {
                GetRates();
            }

            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}]: Purchase rates successfuly loaded.");
        }
    }
}