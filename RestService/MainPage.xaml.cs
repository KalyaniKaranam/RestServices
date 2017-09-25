using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestService
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetJson();
        }
        public async void GetJson()
        {
            if (NetworkCheck.IsInternet())
            {
                var client = new HttpClient();
                var response = await client.GetAsync("http://www.groupkt.com/post/c9b0ccb9/country-and-other-related-rest-webservices.html");
                string sampleJson = await response.Content.ReadAsStringAsync();
                CountryList con = new CountryList();
                if (sampleJson != "")
                {
                    con = JsonConvert.DeserializeObject<CountryList>(con.Countries.ToString());
                    listviewCountry.ItemsSource = con.Countries;
                }
                else
                {
                    await DisplayAlert("Json Parsing", "No Network is Available", "OK");
                }
                ProgressLoader.IsVisible = false;
            }

        }

        private void listviewCountry_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
