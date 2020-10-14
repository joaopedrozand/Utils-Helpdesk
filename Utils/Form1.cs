using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            if (this.interfaceSelected.Items.Count < 1)
                try
                {
                    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                    foreach (NetworkInterface adapter in nics)
                        this.interfaceSelected.Items.Add(adapter.Name);
                }
                catch (Exception)
                {
                    throw;
                }
            this.interfaceSelected.SelectedIndex = 0;
        }

        private void isDynamic_CheckedChanged(object sender, EventArgs e)
        {
            ipAddr.Enabled = false;
            ipMask.Enabled = false;
            ipGateway.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void isStatic_CheckedChanged(object sender, EventArgs e)
        {
            ipAddr.Enabled = true;
            ipMask.Enabled = true;
            ipGateway.Enabled = true;
            ipAddr.Text = "192.168.1.200";
            ipMask.Text = "255.255.255.0";
            ipGateway.Text = "192.168.1.1";
        }

        private void keyNum(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 46|| e.KeyChar == 3 || e.KeyChar == 22)
            {
                e.Handled = false;
            }
        }

        private void setIpAddr_Click(object sender, EventArgs e)
        {
            try
            {
                if (isStatic.Checked)
                {
                    if (Program.IpVerif(ipAddr.Text) && Program.IpVerif(ipMask.Text) && Program.IpVerif(ipGateway.Text))
                    {
                        if (Program.SetIP(interfaceSelected.Text, ipAddr.Text, ipMask.Text, ipGateway.Text))
                            MessageBox.Show("Sucesso!");                      
                    }
                }
                if (isDynamic.Checked)
                {
                    if (Program.SetDHCP(interfaceSelected.Text))
                        MessageBox.Show("Sucesso!");                 
                }
            }
            catch (Exception)
            {

            }
            statusBox.Text = Program.ShowNetworkInterfaces().ToUpper();
        }

        private void ipAddr_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void boxIP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addbox(object sender, EventArgs e)
        {
            if (this.interfaceSelected.Items.Count < 1)
                try
                {
                    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                    foreach (NetworkInterface adapter in nics)
                        this.interfaceSelected.Items.Add(adapter.Name);
                }
                catch (Exception)
                {
                    throw;
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.IpVerif(textBox3.Text))
                resultBox.Text = Program.Api("http://ip-api.com/json/" + textBox3.Text).Replace(",", "\n").Replace("{", "").Replace("}", "").Replace(":", ": ").Replace("\"", "");
            else
                MessageBox.Show("Digite um endereço de IP Válido");
        }

       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (macBox.TextLength >= 12)
                resultMac.Text = Program.Api("https://api.macvendors.com/" + macBox.Text);
            else
                MessageBox.Show("MAC Inválido");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var num = "0123456798";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 2)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            passwd.Text = result.ToString();
            result = new string(
                Enumerable.Repeat(num, 6)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            passwd.Text += result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var num = "0123456798";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(num, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            wpawpa.Text = result.ToString();
            result = new string(
                Enumerable.Repeat(chars, 4)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            wpawpa.Text += result.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void loadStatus(object sender, EventArgs e)
        {
            statusBox.Text = Program.ShowNetworkInterfaces().ToUpper();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
