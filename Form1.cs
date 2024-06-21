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
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "01cb1f0769f6a1e7c3634ec82dd4c23b";
        string unsplashApiKey = "nr57jTxmbhSsPRgMrU1P_nP3h-OOeoQ0ZTObjqtm-2o";

        private void lab_Condition_Click(object sender, EventArgs e) { }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                pic_icon.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                lab_condition.Text = info.weather[0].main;
                lab_detail.Text = info.weather[0].description;
                lab_sunset.Text = UnixTimeStampToDateTime(info.sys.sunset).ToString();
                lab_sunrise.Text = UnixTimeStampToDateTime(info.sys.sunrise).ToString();
                lab_windspeed.Text = info.wind.speed.ToString();
                lab_pressure.Text = info.main.pressure.ToString();

                ChangeBackgroundImage(info);
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
            // Determine the part of the day and weather condition
            DateTime sunrise = UnixTimeStampToDateTime(weatherInfo.sys.sunrise);
            DateTime sunset = UnixTimeStampToDateTime(weatherInfo.sys.sunset);
            DateTime now = DateTime.Now;
            string timeOfDay;

            if (now >= sunrise && now < sunset)
            {
                timeOfDay = "day";
            }
            else
            {
                timeOfDay = "night";
            }

            string condition = weatherInfo.weather[0].main.ToLower();
            string description = weatherInfo.weather[0].description.ToLower();
            string query = $"{TbCity.Text} {condition} {description} {timeOfDay}";

            // Unsplash API
            string unsplashUrl = $"https://api.unsplash.com/photos/random?query={query}&client_id={unsplashApiKey}";

            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(unsplashUrl);
                dynamic result = JsonConvert.DeserializeObject(json);
                return result.urls.full;
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
