namespace rpi_domotica_controlpanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tijdBlok = new System.Windows.Forms.TabPage();
            this.weer = new System.Windows.Forms.TabPage();
            this.temperatuur = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tijdBlok);
            this.tabControl1.Controls.Add(this.weer);
            this.tabControl1.Controls.Add(this.temperatuur);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 446);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tijdBlok
            // 
            this.tijdBlok.Location = new System.Drawing.Point(4, 22);
            this.tijdBlok.Name = "tijdBlok";
            this.tijdBlok.Padding = new System.Windows.Forms.Padding(3);
            this.tijdBlok.Size = new System.Drawing.Size(801, 420);
            this.tijdBlok.TabIndex = 0;
            this.tijdBlok.Text = "Tijdblok";
            this.tijdBlok.UseVisualStyleBackColor = true;
            // 
            // weer
            // 
            this.weer.Location = new System.Drawing.Point(4, 22);
            this.weer.Name = "weer";
            this.weer.Padding = new System.Windows.Forms.Padding(3);
            this.weer.Size = new System.Drawing.Size(801, 420);
            this.weer.TabIndex = 1;
            this.weer.Text = "Weer";
            this.weer.UseVisualStyleBackColor = true;
            // 
            // temperatuur
            // 
            this.temperatuur.Location = new System.Drawing.Point(4, 22);
            this.temperatuur.Name = "temperatuur";
            this.temperatuur.Size = new System.Drawing.Size(801, 420);
            this.temperatuur.TabIndex = 2;
            this.temperatuur.Text = "Temperatuur";
            this.temperatuur.UseVisualStyleBackColor = true;
            this.temperatuur.Click += new System.EventHandler(this.temperatuur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 470);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tijdBlok;
        private System.Windows.Forms.TabPage weer;
        private System.Windows.Forms.TabPage temperatuur;
    }
}

