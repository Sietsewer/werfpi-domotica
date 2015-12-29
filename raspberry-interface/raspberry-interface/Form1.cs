using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace raspberry_interface
{
    public partial class Form1 : Form
    {
        TemperatureSensor[] sensors;

        public Form1()
        {
            InitializeComponent();
        }

        Thread updateTimeThread;
        private void Form1_Load(object sender, EventArgs e)
        {
            //maximizeScreen();
            updateTimeThread = new Thread(updateTime);
            updateTimeThread.Start();
            sensors = initSensors();
            populateTempTable();
        }

        BindingSource bindingSource1 = new BindingSource();
        private void populateTempTable()
        {
            foreach(TemperatureSensor da in sensors)
            {
                bindingSource1.Add(da);
            }
            dataGridView1.DataSource = bindingSource1;
        }

        private void maximizeScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.Bounds.Size;
        }

        private TemperatureSensor[] initSensors()
        {
            SensorUtils.TemperatureSensorData[] sensors = SensorUtils.allSensors();
            List<TemperatureSensor> sensorList = new List<TemperatureSensor>();
            foreach(SensorUtils.TemperatureSensorData sd in sensors)
            {
                sensorList.Add(new TemperatureSensor(sd.SensorID, sd.Location, sd.Function));
            }
            return sensorList.ToArray();
        }

        delegate void SetTimeCallback(string time);
        private void setTime(string s)
        {
            clock.Text = s;
        }
        
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
