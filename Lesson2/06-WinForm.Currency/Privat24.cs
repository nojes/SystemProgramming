using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace _06_WinForm.Currency
{
    public class Privat24
    {
        public Thread Thread;
        private ListBox _listBox;
        private DateTime _startDate;

        public Privat24(ListBox listBox, DateTime startDate)
        {
            this._listBox = listBox;
            this._startDate = startDate;
            Thread = new Thread(Run) {
                IsBackground = true,
                CurrentCulture = CultureInfo.CreateSpecificCulture("uk-UA")
            };
            Thread.Start();
        }

        private void Run()
        {
            while (_startDate <= DateTime.Now) {
                string url = "https://api.privatbank.ua/p24api/exchange_rates?json&date=" + _startDate.ToShortDateString();

                var request = (HttpWebRequest) WebRequest.Create(url);
                string answer = string.Empty;
                using (var response = request.GetResponse()) {
                    using (var streamReader = new StreamReader(response.GetResponseStream())) {
                        answer = streamReader.ReadToEnd();
                    }
                }
                var userServices = JsonConvert.DeserializeObject<UserServices>(answer, new IsoDateTimeConverter {
                    DateTimeFormat = "dd.MM.yyyy"
                });

                foreach (var item in userServices.ExchangeRate) {
                    if (item.Currency == "USD") {
                        _listBox.Items.Add($"Date: {_startDate.Date} | PurchaseRate: {item.PurchaseRate}");
                    }
                }
                Thread.Sleep(500);
                _startDate = _startDate.AddDays(1);
            }
        }
    }


    public class ExchangeRate
    {
        public string BaseCurrency { get; set; }
        public string Currency { get; set; }
        public decimal SaleRateNb { get; set; }
        public decimal PurchaseRateNb { get; set; }
        public decimal SaleRate { get; set; }
        public decimal PurchaseRate { get; set; }
    }

    public class UserServices
    {
        public DateTime Date { get; set; }
        public string Bank { get; set; }
        public int BaseCurrency { get; set; }
        public string BaseCurrencyLit { get; set; }

        public List<ExchangeRate> ExchangeRate { get; set; }
    }

    class Data
    {
        public UserServices Response { get; set; }
    }
}