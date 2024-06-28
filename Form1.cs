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
        // API keys for OpenWeatherMap and Bing
        string APIKey = "01cb1f0769f6a1e7c3634ec82dd4c23b";
        string bingApiKey = "1514f1ed5a9d411ea7d3ce5dcd611fcd"; // Bing API key

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for label click (currently empty)
        private void lab_Condition_Click(object sender, EventArgs e) { }

        // Event handler for the search button click
        private void btn_Search_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        // Method to fetch weather data
        private void getWeather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    // Construct the API URL
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=imperial", TbCity.Text, APIKey);
                    // Download the JSON response
                    var json = web.DownloadString(url);
                    // Deserialize the JSON into a WeatherInfo object
                    WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    // Update UI elements with the weather data
                    pic_icon.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                    lab_condition.Text = info.weather[0].main;
                    lab_detail.Text = info.weather[0].description;
                    lab_temperature.Text = $"{info.main.temp}°F"; // Display temperature in Fahrenheit
                    lab_sunset.Text = UnixTimeStampToDateTime(info.sys.sunset).ToString();
                    lab_sunrise.Text = UnixTimeStampToDateTime(info.sys.sunrise).ToString();
                    lab_windspeed.Text = info.wind.speed.ToString();
                    lab_pressure.Text = info.main.pressure.ToString();

                    // Change the background image based on the weather
                    ChangeBackgroundImage(info);
                }
            }
            catch (WebException ex)
            {
                // Handle errors such as incorrect city names
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
                // Handle unexpected errors
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to change the background image based on weather conditions
        private void ChangeBackgroundImage(WeatherInfo.root weatherInfo)
        {
            try
            {
                // Get the image URL based on the weather
                string imageUrl = GetImageUrl(weatherInfo);
                using (WebClient web = new WebClient())
                {
                    // Download the image data
                    byte[] imageBytes = web.DownloadData(imageUrl);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        // Set the background image of the form
                        this.BackgroundImage = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors and set a default background or color
                MessageBox.Show("Could not load background image. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BackgroundImage = null; // Or set to a default image
                this.BackColor = Color.LightBlue; // Default color
            }
        }

        // Method to get the image URL based on weather conditions using Bing Search API
        private string GetImageUrl(WeatherInfo.root weatherInfo)
        {
            string city = TbCity.Text.ToLower();
            string condition = weatherInfo.weather[0].main.ToLower();
            string query = $"{city} {condition} weather";

            // Construct the Bing Search API URL
            string bingUrl = $"https://api.bing.microsoft.com/v7.0/images/search?q={Uri.EscapeDataString(query)}&count=1";

            using (WebClient web = new WebClient())
            {
                web.Headers.Add("Ocp-Apim-Subscription-Key", bingApiKey);
                try
                {
                    // Download the JSON response
                    var json = web.DownloadString(bingUrl);
                    // Deserialize the JSON to get the image URL
                    dynamic result = JsonConvert.DeserializeObject(json);
                    return result.value[0].contentUrl;
                }
                catch (WebException ex)
                {
                    // Handle errors and show the error message
                    using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        string responseText = reader.ReadToEnd();
                        MessageBox.Show("Error: " + responseText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    throw; // Rethrow the exception after logging
                }
            }
        }

        // Method to convert Unix timestamp to DateTime
        public DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        // Event handler for the close button click
        private void btn_close_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Event handler for city text box text change (currently empty)
        private void TbCity_TextChanged(object sender, EventArgs e) { }

        // Event handler for form load (currently empty)
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
