using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var list = new List<string>
            {"vk.com","fb.com","twitter.com", "instagram.com","google.com"};

            var newlist = list.Select(x => $"{x} {new Ping().Send(x).RoundtripTime}");
            label1.Text = string.Join(Environment.NewLine, newlist);


//Enumerable Range(0, 3) AsParallel() ForAll(x => File Delete(list[x])).

//Parallel ForEach(list, x => File Delete(x)), //Parallel For(0, 3, x => MessageBox Show(list[x])),

        /*    var list = new List<string>
            {
             "vk.com",
             "fb.com",
             "twitter.com",
             "instagram.com",
            };



            *//*
                        list.AsParallel().ForAll(x => File.Delete(x));
                        Enumerable.Range(0, 3).AsParallel().ForAll(x => File.Delete(list[x]));
                        Parallel.ForEach(list, x => File.Delete(x));
                        Parallel.For(0, 3, x => MessageBox.Show(list[x]));
            */
        }
}
}
