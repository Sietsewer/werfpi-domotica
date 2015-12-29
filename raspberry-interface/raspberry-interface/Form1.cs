using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace raspberry_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread updateTimeThread;
        private void Form1_Load(object sender, EventArgs e)
        {
            updateTimeThread = new Thread(updateTime);
            updateTimeThread.Start();
        }

        private void setTime(string s)
        {
            clock.Text = s;
        }
        delegate void SetTimeCallback(string time);
        
        private void updateTime()
        {
            SetTimeCallback c = new SetTimeCallback(setTime);
            while (true)
            {
                this.Invoke(c, new object[] { DateTime.Now.ToString("H:mm:ss") });
                clock.Text = DateTime.Now.ToString("H:mm:ss");
                Thread.Sleep(100);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateTimeThread.Abort();
        }
    }
}
