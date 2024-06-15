using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Initialize the form components
            InitializeComponent();
        }

        // API key for accessing OpenWeatherMap
        string APIKey = "01cb1f0769f6a1e7c3634ec82dd4c23b";
        private void lab_Condition_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            // Call the getWeather method to fetch weather data
            getWeather();
        }

        private void getWeather()
        {
            // Create a WebClient instance to handle the request
            using (WebClient web = new WebClient())
            {
                // Format the URL with the city name and API key
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKey);
                // Download the JSON response from the API
                var json = web.DownloadString(url);
                // Deserialize the JSON response into a WeatherInfo.root object
                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                // Update the UI components with the weather data
                pic_icon.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                lab_condition.Text = info.weather[0].main;
                lab_pressure.Text = info.main.pressure.ToString();
            }
        }

        public DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            // Convert Unix timestamp to DateTime
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            {
                // Prompt the user with a confirmation message
                var result = MessageBox.Show("Are you sure you want to close the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicks 'Yes', close the application
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
