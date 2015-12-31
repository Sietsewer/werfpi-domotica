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
            this.temperature = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sensorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureSensorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.times = new System.Windows.Forms.TabPage();
            this.weather = new System.Windows.Forms.TabPage();
            this.system = new System.Windows.Forms.TabPage();
            this.button_exit = new System.Windows.Forms.Button();
            this.temperatureSensorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clock = new System.Windows.Forms.Label();
            this.temperatureSensorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temperatureSensorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gpioTest = new System.Windows.Forms.TabPage();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.temperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource2)).BeginInit();
            this.system.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource1)).BeginInit();
            this.gpioTest.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.system);
            this.tabControl1.Controls.Add(this.gpioTest);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 510);
            this.tabControl1.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sensorIDDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.functionDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.temperatureSensorBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(888, 481);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sensorIDDataGridViewTextBoxColumn
            // 
            this.sensorIDDataGridViewTextBoxColumn.DataPropertyName = "SensorID";
            this.sensorIDDataGridViewTextBoxColumn.HeaderText = "SensorID";
            this.sensorIDDataGridViewTextBoxColumn.Name = "sensorIDDataGridViewTextBoxColumn";
            this.sensorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // functionDataGridViewTextBoxColumn
            // 
            this.functionDataGridViewTextBoxColumn.DataPropertyName = "Function";
            this.functionDataGridViewTextBoxColumn.HeaderText = "Function";
            this.functionDataGridViewTextBoxColumn.Name = "functionDataGridViewTextBoxColumn";
            this.functionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Temperature";
            this.dataGridViewTextBoxColumn1.HeaderText = "Temperature";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // temperatureSensorBindingSource2
            // 
            this.temperatureSensorBindingSource2.DataSource = typeof(raspberry_interface.TemperatureSensor);
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
            this.weather.Size = new System.Drawing.Size(894, 484);
            this.weather.TabIndex = 1;
            this.weather.Text = "Weer";
            this.weather.UseVisualStyleBackColor = true;
            // 
            // system
            // 
            this.system.Controls.Add(this.button_exit);
            this.system.Location = new System.Drawing.Point(4, 22);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(894, 484);
            this.system.TabIndex = 3;
            this.system.Text = "Systeem";
            this.system.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.Location = new System.Drawing.Point(745, 3);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(146, 23);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Sluiten";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // temperatureSensorDataBindingSource
            // 
            this.temperatureSensorDataBindingSource.DataSource = typeof(raspberry_interface.SensorUtils.TemperatureSensorData);
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
            // temperatureSensorBindingSource
            // 
            this.temperatureSensorBindingSource.DataSource = typeof(raspberry_interface.TemperatureSensor);
            // 
            // temperatureSensorBindingSource1
            // 
            this.temperatureSensorBindingSource1.DataSource = typeof(raspberry_interface.TemperatureSensor);
            // 
            // gpioTest
            // 
            this.gpioTest.Controls.Add(this.checkBox26);
            this.gpioTest.Controls.Add(this.checkBox19);
            this.gpioTest.Location = new System.Drawing.Point(4, 22);
            this.gpioTest.Name = "gpioTest";
            this.gpioTest.Padding = new System.Windows.Forms.Padding(3);
            this.gpioTest.Size = new System.Drawing.Size(894, 484);
            this.gpioTest.TabIndex = 4;
            this.gpioTest.Text = "GPIO Test";
            this.gpioTest.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(7, 7);
            this.checkBox19.Name = "checkBox1";
            this.checkBox19.Size = new System.Drawing.Size(56, 17);
            this.checkBox19.TabIndex = 0;
            this.checkBox19.Text = "Pin 19";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Enabled = false;
            this.checkBox26.Location = new System.Drawing.Point(7, 31);
            this.checkBox26.Name = "checkBox2";
            this.checkBox26.Size = new System.Drawing.Size(56, 17);
            this.checkBox26.TabIndex = 1;
            this.checkBox26.Text = "Pin 26";
            this.checkBox26.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource2)).EndInit();
            this.system.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource1)).EndInit();
            this.gpioTest.ResumeLayout(false);
            this.gpioTest.PerformLayout();
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
        private System.Windows.Forms.BindingSource temperatureSensorDataBindingSource;
        private System.Windows.Forms.BindingSource temperatureSensorBindingSource;
        private System.Windows.Forms.BindingSource temperatureSensorBindingSource1;
        private System.Windows.Forms.TabPage system;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource temperatureSensorBindingSource2;
        private System.Windows.Forms.TabPage gpioTest;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox19;
    }
}

