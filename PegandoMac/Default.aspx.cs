using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PegandoMac
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl.Text = GetMAC();
        }

        private string GetMAC()
        {
            string macAddresses = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddresses;
        }
    }
}