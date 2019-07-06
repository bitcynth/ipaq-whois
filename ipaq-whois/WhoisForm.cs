using System;
using System.Net.Sockets;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WHOIS
{
    public partial class WHOIS : Form
    {
        public WHOIS()
        {
            InitializeComponent();
        }

        private string QueryWHOIS(string host, int port, string query)
        {
            TcpClient client = new TcpClient(host, port);
            byte[] data = System.Text.Encoding.ASCII.GetBytes(query + "\r\n");

            NetworkStream stream = client.GetStream();

            stream.Write(data, 0, data.Length);

            String response = "";
            data = new byte[1024];
            try
            {
                while (true)
                {
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    response += System.Text.Encoding.UTF8.GetString(data, 0, bytes);
                    if (bytes <= 0)
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            stream.Close();
            client.Close();

            return response;
        }

        private void DisplayText(string text)
        {
            outputText.Text = text;
        }

        private void SearchWHOIS()
        {
            string res = QueryWHOIS("whois.ripe.net", 43, queryText.Text);
            res = res.Replace("\n", "\r\n");
            DisplayText(res);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
                SearchWHOIS();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchWHOIS();
        }
    }
}