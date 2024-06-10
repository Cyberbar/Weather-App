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
            InitializeComponent();
        }
        string APIKey = "01cb1f0769f6a1e7c3634ec82dd4c23b";
        private void lab_Condition_Click(object sender, EventArgs e)
        {

        }

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
                lab_sunset.Text = info.sys.sunset.ToString();
                lab_sunrise.Text = info.sys.sunrise.ToString();
                lab_windspeed.Text = info.wind.Speed.ToString();
                lab_pressure.Text = info.main.pressure.ToString();
            }
        }
    }
}
