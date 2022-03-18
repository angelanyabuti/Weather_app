using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;


namespace Weather_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string APIKey= "41d82f27b1c5fb6ea164a211413a8964";
        private void button1_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        //function to get weather information
        void getWeather()
        {
             using (WebClient web= new WebClient())
            {
                //url for downloading weather information
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=(0)&appid=(1)", txtcity.Text,APIKey);
                //download weather into JSON object
                string json = web.DownloadString(url);
                Weather.root Info = JsonConvert.DeserializeObject<Weather.root>(json);
                pictureBox1.ImageLocation = "https://home.openweathermap.org/img/W/"+Info.weather[0].icon +".png";
                label4.Text = Info.wind.speed.ToString();
            }
        }
    }
}
