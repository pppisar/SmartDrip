using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NurseSms
{
  public partial class Form1 : Form
  {
    SerialPort port;
    public Form1()
    {
      InitializeComponent();
      try
      {
        port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        port.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
        port.Open();
        port.NewLine = "\r";
      }
      catch (Exception)
      {
        button2.Enabled = richTextBox1.Enabled = false;
      }
    }

    private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      string data = port.ReadLine();
      this.Invoke((MethodInvoker)delegate {
        if (data.Contains("%")) {
          int value;
          int.TryParse(string.Join("", data.Where(c => char.IsDigit(c))), out value);
          progressBar1.Value = value;
        }
        if (data.Contains("Level") || data.Contains("Temp")) {
          richTextBox1.AppendText(data);
        }
      });

    }

    private void button2_Click(object sender, EventArgs e)
    {
      richTextBox1.Clear();
    }
  }
}
