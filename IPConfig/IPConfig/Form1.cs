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
using System.Net.NetworkInformation;

namespace IPConfig
{
    public partial class NetworkInterface : Form
    {
        public NetworkInterface()
        {
            InitializeComponent();
        }

        private void GetIP_button_Click(object sender, EventArgs e)
        {
            string url =textBox1.Text.ToString();
            try
            {
                IPHostEntry hostname = Dns.GetHostByName(url);
                IPAddress[] ip = hostname.AddressList;
                GetIP_result.Text = ip[0].ToString();
            }
            catch(Exception er)
            {
                GetIP_result.Text = er.ToString();
            }
        }

        private void GetInfo_button_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text.ToString();
            //Setting credential for the ping to network
            Ping PingSender = new Ping();
            PingOptions options = new PingOptions();
            //Leave the behavior as default
            options.DontFragment = true;
            string Ip4=null;
            try
            {
                IPHostEntry hostname = Dns.GetHostByName(url);
                IPAddress[] ip = hostname.AddressList;
                Ip4 = ip[0].ToString();
            }
            catch (Exception er)
            {
                GetIP_result.Text = er.ToString();
            }
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //Encoding the data to ascii representation
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            //Set timeout for ping Command
            int timeout = 10000;
            PingReply reply = PingSender.Send(Ip4, timeout, buffer, options);
            
            if (reply.Status != IPStatus.Success)
            {
                connStatus_label.Text = "Not Established.";
            }else
            {
                connStatus_label.Text = "Established.";
            }
            if (reply.Status == IPStatus.Success)
            {
                Address_label.Text = reply.Address.ToString();
                RoundTrip_label.Text = reply.RoundtripTime.ToString();
                Time_to_live_label.Text = reply.Options.Ttl.ToString();
                fragment_label.Text = reply.Options.DontFragment.ToString();
                Buffer_size_label.Text = reply.Buffer.Length.ToString();
            }

        }
    }
}
