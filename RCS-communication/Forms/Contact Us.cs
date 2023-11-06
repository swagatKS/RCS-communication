using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RCS_communication.Forms
{
    public partial class Contact_Us : Form
    {
        public Contact_Us()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.bastiansolutions.com/about/global-office-locations/#US-locations");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.bastiansolutions.com/about/global-office-locations/mississauga-ontario/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.bastiansolutions.com/about/global-office-locations/asia-pacific/");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.bastiansolutions.com/about/global-office-locations/mexico-headquarters/");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.bastiansolutions.com/about/global-office-locations/south-america/");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com/maps/place/Bastian+Solutions/@39.9407041,-86.1565472,17z/data=!3m1!4b1!4m6!3m5!1s0x8814ac951dd1444f:0xfa3142c76ccf0478!8m2!3d39.9407041!4d-86.1565472!16s%2Fg%2F1tgwbck5?entry=ttu");

        }
    }
}
