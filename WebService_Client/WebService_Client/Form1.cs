using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebService_Client
{
    public partial class Form1 : Form
    {
        ServiceReference.SendMailInterfaceClient s = new ServiceReference.SendMailInterfaceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            String url = textBox1.Text;
            String[] URL =  url.Split(new char[] {';'});
            for(int i=0;i<URL.Length;i++)
            {
                Console.WriteLine(URL[i]);
            }
            String payload = richTextBox1.Text;
            if(URL.Length==1)
            {
                s.sendEmail(URL[0],payload);
            }
            else if(URL.Length>1)
            {
                s.sendEmailBatch(URL, payload);
            }
            else
            {
                Console.WriteLine("收信地址不能为空!");
            }
        }
    }
}
