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
using Newtonsoft.Json.Linq;
using Geolocation;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ProjectJASC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Longitutde of ISS", 120);
            listView1.Columns.Add("Latitude of ISS", 120);
            listView1.Columns.Add("TimeStamp", 150);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            this.BackgroundImage = Properties.Resources.sapce2;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public static double ISSLat(double ISSLati)
        {
            var wc = new WebClient();
            var jsonData = wc.DownloadString("http://api.open-notify.org/iss-now.json");
            dynamic jsonObject = JValue.Parse(jsonData);
            ISSLati = Convert.ToDouble($"{jsonObject.iss_position.latitude}");
            return ISSLati;
        }
        public static double ISSLon(double ISSLong)
        {
            var wc = new WebClient();
            var jsonData = wc.DownloadString("http://api.open-notify.org/iss-now.json");
            dynamic jsonObject = JValue.Parse(jsonData);
            ISSLong = Convert.ToDouble($"{jsonObject.iss_position.longitude}");
            return ISSLong;
        }
        private void ISSLocationButton_Click(object sender, EventArgs e)
        {
            var lon = 0.0;
            var lat = 0.0;
            var wc = new WebClient();
            var jsonData = wc.DownloadString("http://api.open-notify.org/iss-now.json");
            dynamic jsonObject = JValue.Parse(jsonData);
            ISSLonText.Text = "" + ISSLat(lat);
            ISSLatText.Text = "" + ISSLon(lon);
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var wc = new WebClient();
            var jsonData = wc.DownloadString("http://api.open-notify.org/iss-now.json");
            dynamic jsonObject = JValue.Parse(jsonData);
            linkLabel2.LinkArea = new LinkArea(0, 57);
            System.Diagnostics.Process.Start($"https://google-developers.appspot.com/maps/documentation/utils/geocoder/#q%3D{jsonObject.iss_position.latitude}%252C{jsonObject.iss_position.longitude}");
           //webBrowser1.Navigate($"https://google-developers.appspot.com/maps/documentation/utils/geocoder/#q%3D{jsonObject.iss_position.latitude}%252C{jsonObject.iss_position.longitude}");
        }

        private void yourLocationButton_Click(object sender, EventArgs e)
        {
            var userLon = 0.0;
            var userLat = 0.0;
            YourLonText.Text = "" + myLon(userLon);
            YourLatText.Text = "" + myLat(userLat);
        }

        public static double myLon(double userLon)
        {
            var wc = new WebClient();
            string myIP = wc.DownloadString("http://icanhazip.com/");
            var jsonData = wc.DownloadString($"http://ip-api.com/json/{myIP}");
            dynamic jsonObject = JValue.Parse(jsonData);
            userLon = Convert.ToDouble($"{jsonObject.lon}");
            return userLon;
        }

        public static double myLat(double userLat)
        {
            var wc = new WebClient();
            string myIP = wc.DownloadString("http://icanhazip.com/");
            var jsonData = wc.DownloadString($"http://ip-api.com/json/{myIP}");
            dynamic jsonObject = JValue.Parse(jsonData);
            userLat = Convert.ToDouble($"{jsonObject.lat}");
            return userLat;
        }
        private void DistanceFromISSToYouButton_Click(object sender, EventArgs e)
        {
            var userLat = 0.0;
            var userLon = 0.0;
            var ISSLati = 0.0;
            var ISSLong = 0.0;
            DistanceFromISSToYouText.Text = "" + (GeoCalculator.GetDistance(myLat(userLat), myLon(userLon), ISSLat(ISSLati), ISSLon(ISSLong))+ " miles.");           
            //save here
        }

        private void ListOfISSLonAndLat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void DisplayInfoButton_Click(object sender, EventArgs e)
        {
            var ISSLati = 0.0;
            var ISSLong = 0.0;
            string[] arr = new string[4];
            var time = 0;

            var wc = new WebClient();
            var jsonData = wc.DownloadString("http://api.open-notify.org/iss-now.json");
            dynamic jsonObject = JValue.Parse(jsonData);
            time = (int)Convert.ToInt64($"{jsonObject.timestamp}");

            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(time);
            DateTime dateTime = dateTimeOffset.LocalDateTime;
            
            ListViewItem itm;
            arr[0] = $"{ISSLon(ISSLong)}";
            arr[1] = $"{ISSLat(ISSLati)}";
            arr[2] = $"{dateTime}";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
            if (File.Exists(@"C:\Intel\ISSd.txt"))
            {
                StreamWriter file = new StreamWriter(@"C:\Intel\ISSd.txt", true);
                file.WriteLine($"{ISSLon(ISSLong)},{ISSLat(ISSLati)},{dateTime}");
                //file.Write(",");
                file.Close();
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Intel\ISSd.txt");
                file.WriteLine($"{ISSLon(ISSLong)},{ISSLat(ISSLati)},{dateTime}");
                //file.Write(",");
                file.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] words = new string[4];
            
            string[] arr = new string[4];
            if (File.Exists(@"C:\Intel\ISSd.txt"))
            {
                using (StreamReader sr = new StreamReader(@"C:\Intel\ISSd.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string info = (sr.ReadLine());
                        words = info.Split(new char[] { ',' });

                        ListViewItem itm;
                        itm = new ListViewItem(words);
                        listView1.Items.Add(itm);
                    }
                }

                
                //needs to load files correctly, reading new lines starts a new entry
            }
        }
    }
}
