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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.temperature = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.times = new System.Windows.Forms.TabPage();
            this.weather = new System.Windows.Forms.TabPage();
            this.system = new System.Windows.Forms.TabPage();
            this.button_exit = new System.Windows.Forms.Button();
            this.gpioTest = new System.Windows.Forms.TabPage();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.temperatureSensorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.temperatureSensorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clock = new System.Windows.Forms.Label();
            this.temperatureSensorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temperatureSensorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.settings = new System.Windows.Forms.TabPage();
            this.input_Hysteresis = new System.Windows.Forms.NumericUpDown();
            this.input_HysteresisOffset = new System.Windows.Forms.NumericUpDown();
            this.input_MinimumTemperature = new System.Windows.Forms.NumericUpDown();
            this.input_MaximumTemperature = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_settings_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boiler_indicator = new System.Windows.Forms.RadioButton();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isConnectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureSensorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.temperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.system.SuspendLayout();
            this.gpioTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource1)).BeginInit();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_Hysteresis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_HysteresisOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_MinimumTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_MaximumTemperature)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.temperature);
            this.tabControl.Controls.Add(this.times);
            this.tabControl.Controls.Add(this.weather);
            this.tabControl.Controls.Add(this.system);
            this.tabControl.Controls.Add(this.gpioTest);
            this.tabControl.Controls.Add(this.settings);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(555, 293);
            this.tabControl.TabIndex = 0;
            // 
            // temperature
            // 
            this.temperature.Controls.Add(this.dataGridView1);
            this.temperature.Location = new System.Drawing.Point(4, 22);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(547, 267);
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.isConnectedDataGridViewCheckBoxColumn,
            this.temperatureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.temperatureSensorBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(4, 22);
            this.times.Name = "times";
            this.times.Padding = new System.Windows.Forms.Padding(3);
            this.times.Size = new System.Drawing.Size(547, 267);
            this.times.TabIndex = 0;
            this.times.Text = "Tijden";
            this.times.UseVisualStyleBackColor = true;
            // 
            // weather
            // 
            this.weather.Location = new System.Drawing.Point(4, 22);
            this.weather.Name = "weather";
            this.weather.Padding = new System.Windows.Forms.Padding(3);
            this.weather.Size = new System.Drawing.Size(547, 267);
            this.weather.TabIndex = 1;
            this.weather.Text = "Weer";
            this.weather.UseVisualStyleBackColor = true;
            // 
            // system
            // 
            this.system.Controls.Add(this.button_exit);
            this.system.Location = new System.Drawing.Point(4, 22);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(547, 267);
            this.system.TabIndex = 3;
            this.system.Text = "Systeem";
            this.system.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.Location = new System.Drawing.Point(398, 3);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(146, 23);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Sluiten";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // gpioTest
            // 
            this.gpioTest.Controls.Add(this.checkBox13);
            this.gpioTest.Controls.Add(this.checkBox6);
            this.gpioTest.Controls.Add(this.checkBox12);
            this.gpioTest.Controls.Add(this.checkBox26);
            this.gpioTest.Controls.Add(this.checkBox19);
            this.gpioTest.Location = new System.Drawing.Point(4, 22);
            this.gpioTest.Name = "gpioTest";
            this.gpioTest.Padding = new System.Windows.Forms.Padding(3);
            this.gpioTest.Size = new System.Drawing.Size(547, 267);
            this.gpioTest.TabIndex = 4;
            this.gpioTest.Text = "GPIO Test";
            this.gpioTest.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(6, 52);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(56, 17);
            this.checkBox13.TabIndex = 4;
            this.checkBox13.Text = "Pin 13";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 29);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(50, 17);
            this.checkBox6.TabIndex = 3;
            this.checkBox6.Text = "Pin 6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(6, 6);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(50, 17);
            this.checkBox12.TabIndex = 2;
            this.checkBox12.Text = "Pin 5";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Enabled = false;
            this.checkBox26.Location = new System.Drawing.Point(6, 98);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(56, 17);
            this.checkBox26.TabIndex = 1;
            this.checkBox26.Text = "Pin 26";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(6, 75);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(56, 17);
            this.checkBox19.TabIndex = 0;
            this.checkBox19.Text = "Pin 19";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // clock
            // 
            this.clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(518, 10);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(49, 13);
            this.clock.TabIndex = 1;
            this.clock.Text = "00:00:00";
            // 
            // settings
            // 
            this.settings.Controls.Add(this.groupBox1);
            this.settings.Controls.Add(this.btn_settings_save);
            this.settings.Location = new System.Drawing.Point(4, 22);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(3);
            this.settings.Size = new System.Drawing.Size(547, 267);
            this.settings.TabIndex = 5;
            this.settings.Text = "Instellingen";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // input_Hysteresis
            // 
            this.input_Hysteresis.DecimalPlaces = 1;
            this.input_Hysteresis.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.input_Hysteresis.Location = new System.Drawing.Point(129, 14);
            this.input_Hysteresis.Name = "input_Hysteresis";
            this.input_Hysteresis.Size = new System.Drawing.Size(120, 20);
            this.input_Hysteresis.TabIndex = 0;
            this.input_Hysteresis.ValueChanged += new System.EventHandler(this.input_Hysteresis_ValueChanged);
            // 
            // input_HysteresisOffset
            // 
            this.input_HysteresisOffset.DecimalPlaces = 1;
            this.input_HysteresisOffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.input_HysteresisOffset.Location = new System.Drawing.Point(129, 40);
            this.input_HysteresisOffset.Name = "input_HysteresisOffset";
            this.input_HysteresisOffset.Size = new System.Drawing.Size(120, 20);
            this.input_HysteresisOffset.TabIndex = 1;
            this.input_HysteresisOffset.ValueChanged += new System.EventHandler(this.input_HysteresisOffset_ValueChanged);
            // 
            // input_MinimumTemperature
            // 
            this.input_MinimumTemperature.DecimalPlaces = 1;
            this.input_MinimumTemperature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.input_MinimumTemperature.Location = new System.Drawing.Point(129, 66);
            this.input_MinimumTemperature.Name = "input_MinimumTemperature";
            this.input_MinimumTemperature.Size = new System.Drawing.Size(120, 20);
            this.input_MinimumTemperature.TabIndex = 2;
            this.input_MinimumTemperature.ValueChanged += new System.EventHandler(this.input_MinimumTemperature_ValueChanged);
            // 
            // input_MaximumTemperature
            // 
            this.input_MaximumTemperature.DecimalPlaces = 1;
            this.input_MaximumTemperature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.input_MaximumTemperature.Location = new System.Drawing.Point(129, 92);
            this.input_MaximumTemperature.Name = "input_MaximumTemperature";
            this.input_MaximumTemperature.Size = new System.Drawing.Size(120, 20);
            this.input_MaximumTemperature.TabIndex = 3;
            this.input_MaximumTemperature.ValueChanged += new System.EventHandler(this.input_MaximumTemperature_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hysteresis";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hysteresis Offset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minimum Temperatuur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maximum Temperatuur";
            // 
            // btn_settings_save
            // 
            this.btn_settings_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings_save.Location = new System.Drawing.Point(466, 6);
            this.btn_settings_save.Name = "btn_settings_save";
            this.btn_settings_save.Size = new System.Drawing.Size(75, 23);
            this.btn_settings_save.TabIndex = 8;
            this.btn_settings_save.Text = "Opslaan";
            this.btn_settings_save.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.input_Hysteresis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.input_HysteresisOffset);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.input_MinimumTemperature);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.input_MaximumTemperature);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 253);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // boiler_indicator
            // 
            this.boiler_indicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boiler_indicator.AutoSize = true;
            this.boiler_indicator.Checked = true;
            this.boiler_indicator.Enabled = false;
            this.boiler_indicator.Location = new System.Drawing.Point(500, 10);
            this.boiler_indicator.Name = "boiler_indicator";
            this.boiler_indicator.Size = new System.Drawing.Size(14, 13);
            this.boiler_indicator.TabIndex = 5;
            this.boiler_indicator.TabStop = true;
            this.boiler_indicator.UseVisualStyleBackColor = true;
            this.boiler_indicator.CheckedChanged += new System.EventHandler(this.boiler_indicator_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SensorID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SensorID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn3.HeaderText = "Location";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Function";
            this.dataGridViewTextBoxColumn4.HeaderText = "Function";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // isConnectedDataGridViewCheckBoxColumn
            // 
            this.isConnectedDataGridViewCheckBoxColumn.DataPropertyName = "IsConnected";
            this.isConnectedDataGridViewCheckBoxColumn.HeaderText = "IsConnected";
            this.isConnectedDataGridViewCheckBoxColumn.Name = "isConnectedDataGridViewCheckBoxColumn";
            this.isConnectedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temperatureSensorBindingSource3
            // 
            this.temperatureSensorBindingSource3.DataSource = typeof(raspberry_interface.TemperatureSensor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 317);
            this.Controls.Add(this.boiler_indicator);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.temperature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.system.ResumeLayout(false);
            this.gpioTest.ResumeLayout(false);
            this.gpioTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource1)).EndInit();
            this.settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.input_Hysteresis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_HysteresisOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_MinimumTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_MaximumTemperature)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSensorBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
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
        private System.Windows.Forms.BindingSource temperatureSensorBindingSource2;
        private System.Windows.Forms.TabPage gpioTest;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isConnectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource temperatureSensorBindingSource3;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.NumericUpDown input_Hysteresis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown input_MaximumTemperature;
        private System.Windows.Forms.NumericUpDown input_MinimumTemperature;
        private System.Windows.Forms.NumericUpDown input_HysteresisOffset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_settings_save;
        private System.Windows.Forms.RadioButton boiler_indicator;
    }
}

