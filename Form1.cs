using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing;
using System.IO;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        string APIKey = "01cb1f0769f6a1e7c3634ec82dd4c23b";
        string bingApiKey = "1514f1ed5a9d411ea7d3ce5dcd611fcd"; // Replace with your Bing API key

        public Form1()
        {
            InitializeComponent();
        }

        private void lab_Condition_Click(object sender, EventArgs e) { }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void getWeather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=imperial", TbCity.Text, APIKey);
                    var json = web.DownloadString(url);
                    WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    pic_icon.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                    lab_condition.Text = info.weather[0].main;
                    lab_detail.Text = info.weather[0].description;
                    lab_temperature.Text = $"{info.main.temp}°F"; // Display temperature in Fahrenheit
                    lab_sunset.Text = UnixTimeStampToDateTime(info.sys.sunset).ToString();
                    lab_sunrise.Text = UnixTimeStampToDateTime(info.sys.sunrise).ToString();
                    lab_windspeed.Text = info.wind.speed.ToString();
                    lab_pressure.Text = info.main.pressure.ToString();

                    ChangeBackgroundImage(info);
                }
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse response && response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("The city you have entered is incorrect. Please check the city name and try again.", "City Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        string responseText = reader.ReadToEnd();
                        MessageBox.Show("Error: " + responseText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeBackgroundImage(WeatherInfo.root weatherInfo)
        {
            try
            {
                string imageUrl = GetImageUrl(weatherInfo);
                using (WebClient web = new WebClient())
                {
                    byte[] imageBytes = web.DownloadData(imageUrl);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        this.BackgroundImage = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load background image. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set a default background image or color
                this.BackgroundImage = null; // Or set to a default image
                this.BackColor = Color.LightBlue; // Default color
            }
        }

        private string GetImageUrl(WeatherInfo.root weatherInfo)
        {
            string city = TbCity.Text.ToLower();
            string condition = weatherInfo.weather[0].main.ToLower();
            string query = $"{city} {condition} weather";

            string bingUrl = $"https://api.bing.microsoft.com/v7.0/images/search?q={Uri.EscapeDataString(query)}&count=1";

            using (WebClient web = new WebClient())
            {
                web.Headers.Add("Ocp-Apim-Subscription-Key", bingApiKey);
                try
                {
                    var json = web.DownloadString(bingUrl);
                    dynamic result = JsonConvert.DeserializeObject(json);
                    return result.value[0].contentUrl;
                }
                catch (WebException ex)
                {
                    using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        string responseText = reader.ReadToEnd();
                        MessageBox.Show("Error: " + responseText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    throw; // Rethrow the exception after logging
                }
            }
        }

        public DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TbCity_TextChanged(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
