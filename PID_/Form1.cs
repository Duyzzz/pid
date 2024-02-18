using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace PID_
{
    public partial class PID_form : Form
    {
        public PID_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort.PortName = cbComSelect.Text;
                serialPort.BaudRate = Convert.ToInt32(bauratCbBox.Text);
                serialPort.Open();
                connectStateLabel.Text = "Connected";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "False to connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PID_form_Load(object sender, EventArgs e)
        {
            cbComSelect.Text = "COM?";
            bauratCbBox.Text = "115200";
            String[] ports = SerialPort.GetPortNames();
            String[] baurates = {"115200" };
            bauratCbBox.Items.AddRange(baurates);
            cbComSelect.Items.AddRange(ports);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string kpValue = "";
        string kiValue = "";
        string kdValue = "";
        string autoSize(string inString)
        {
            short i = 0;
            int len = inString.Length;
            while(len + i < 7) {
                inString = inString + "_";
                i++;
            }
            inString = inString + "_";
            return inString;
        }
        private void sendController_Click(object sender, EventArgs e)
        {
            kpValue = autoSize(kpTb.Text);
            kiValue = autoSize(kiTb.Text);
            kdValue = autoSize(kdTb.Text);
            string data = $"t_{kpValue}{kiValue}{kdValue}";
            int len = data.Length;
            if(serialPort.IsOpen)
            {
                serialPort.WriteLine(data);
            } else
            {
                MessageBox.Show("Đã kết nối đâu");
            }
        }
    }
}
