using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        private TCPClient _cli;
        private FileManager _fm;
        public Client()
        {
            InitializeComponent();
            requestButton.Enabled = false;
            disconnectButton.Enabled = false;
            _fm = new FileManager("", "log.txt");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void hostTextBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if(_cli!=null)
            _cli.Close();
            try
            {
                _cli = new TCPClient(hostTextBox.Text, Convert.ToInt32(portTextBox.Text));
            }
            catch
            {
                _cli = null;
            }
            if (_cli != null)
            {
                requestButton.Enabled = true;
                disconnectButton.Enabled = true;
            }

        }

        private void msgTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            try
            {
                _cli.Write(msgTextBox.Text);
                _fm.WriteLine(msgTextBox.Text+" "+DateTime.Now);
                responseTextLabel.Text = _cli.Read();
            }
            catch
            {
                CloseConn();
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            CloseConn();
        }

        private void responseTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void responseTextLabel_Click(object sender, EventArgs e)
        {

        }
        private void CloseConn()
        {
            _cli.Close();
            _cli = null;
            requestButton.Enabled = false;
            disconnectButton.Enabled = false;
            responseTextLabel.Text = "-";
        }
    }
}
