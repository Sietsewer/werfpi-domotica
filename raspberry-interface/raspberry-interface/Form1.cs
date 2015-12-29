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
        public Form1()
        {
            InitializeComponent();
        }
        TemperatureSensor[] sensors;
        Thread updateTimeThread;
        Thread updateTableThread;
        private void Form1_Load(object sender, EventArgs e)
        {
            maximizeScreen();
            updateTimeThread = new Thread(updateTime);
            updateTimeThread.Start();
            sensors = initSensors();
            populateTempTable(sensors);
        }

        BindingSource bindingSource1 = new BindingSource();
        private void populateTempTable(TemperatureSensor[] tableSensors)
        {
            foreach(TemperatureSensor da in tableSensors)
            {
                bindingSource1.Add(da);
            }
			dataGridView1.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            dataGridView1.DataSource = bindingSource1;
            updateTableThread = new Thread(updateTable);
			updateTableThread.Start();
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
                sensorList.Add(new TemperatureSensor(sd.SensorID, sd.Location, sd.Function, 1000));
            }
            return sensorList.ToArray();
        }

        delegate void SetTimeCallback(string time);
        private void setTime(string s)
        {
            clock.Text = s;
        }

        delegate void UpdateTableCallback();
        private void updateTable()
        {
			UpdateTableCallback c = delegate {
				dataGridView1.InvalidateColumn(3);
			};
            while (true)
            {
                Invoke(c);
            }
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
            updateTableThread.Abort();
            foreach(TemperatureSensor s in sensors)
            {
                s.readTempThread.Abort();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
