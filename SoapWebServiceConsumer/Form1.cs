using SoapWebServiceConsumer.LemonWayWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoapWebServiceConsumer
{
    public partial class Form1 : Form
    {
        LemonWayWebServiceSoap obj = new LemonWayWebServiceSoapClient() ;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Form modalForm = new Form();
            modalForm.ControlBox = false;
            Label label = new Label();
            label.Text = "waiting";
            label.TextAlign = ContentAlignment.MiddleCenter;
            modalForm.Controls.Add(label);
            BeginInvoke((Action)(() => modalForm.ShowDialog()));
    
            string task = await SetOffAsync();
            this.button1.Text = task.ToString();
            modalForm.Close();

  
        }

        public Task<string> SetOffAsync()
        {
            return Task<string>.Factory.StartNew(() =>
            {
                FibonacciRequest request = new FibonacciRequest(new FibonacciRequestBody(10));
                return obj.Fibonacci(request).Body.FibonacciResult;
            });
        }

       
    }
}
