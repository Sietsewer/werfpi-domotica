namespace raspberry_interface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.times = new System.Windows.Forms.TabPage();
            this.weather = new System.Windows.Forms.TabPage();
            this.temperature = new System.Windows.Forms.TabPage();
            this.clock = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.temperatureSensorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SensorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.temperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.temperature);
            this.tabControl1.Controls.Add(this.times);
            this.tabControl1.Controls.Add(this.weather);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(4, 22);
            this.times.Name = "times";
            this.times.Padding = new System.Windows.Forms.Padding(3);
            this.times.Size = new System.Drawing.Size(894, 484);
            this.times.TabIndex = 0;
            this.times.Text = "Tijden";
            this.times.UseVisualStyleBackColor = true;
            // 
            // weather
            // 
            this.weather.Location = new System.Drawing.Point(4, 22);
            this.weather.Name = "weather";
            this.weather.Padding = new System.Windows.Forms.Padding(3);
            this.weather.Size = new System.Drawing.Size(932, 461);
            this.weather.TabIndex = 1;
            this.weather.Text = "Weer";
            this.weather.UseVisualStyleBackColor = true;
            // 
            // temperature
            // 
            this.temperature.Controls.Add(this.dataGridView1);
            this.temperature.Location = new System.Drawing.Point(4, 22);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(894, 484);
            this.temperature.TabIndex = 2;
            this.temperature.Text = "Temperatuur";
            this.temperature.UseVisualStyleBackColor = true;
            // 
            // clock
            // 
            this.clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(865, 10);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(49, 13);
            this.clock.TabIndex = 1;
            this.clock.Text = "00:00:00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SensorID,
            this.location,
            this.function,
            this.sensorTemperature});
            this.dataGridView1.DataSource = this.temperatureSensorDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(888, 478);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // temperatureSensorDataBindingSource
            // 
            this.temperatureSensorDataBindingSource.DataSource = typeof(raspberry_interface.SensorUtils.TemperatureSensorData);
            // 
            // SensorID
            // 
            this.SensorID.FillWeight = 0.6988913F;
            this.SensorID.HeaderText = "Sensor ID";
            this.SensorID.MinimumWidth = 100;
            this.SensorID.Name = "SensorID";
            // 
            // location
            // 
            this.location.FillWeight = 69.88913F;
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            // 
            // function
            // 
            this.function.FillWeight = 69.88913F;
            this.function.HeaderText = "Functie";
            this.function.Name = "function";
            // 
            // sensorTemperature
            // 
            this.sensorTemperature.FillWeight = 1F;
            this.sensorTemperature.HeaderText = "Temp.";
            this.sensorTemperature.MinimumWidth = 60;
            this.sensorTemperature.Name = "sensorTemperature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 534);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.temperature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage times;
        private System.Windows.Forms.TabPage weather;
        private System.Windows.Forms.TabPage temperature;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn function;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorTemperature;
        private System.Windows.Forms.BindingSource temperatureSensorDataBindingSource;
    }
}

