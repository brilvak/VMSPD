namespace VMSPD_server
{
    partial class RPDU_form
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
            this.groupBox_RPDU = new System.Windows.Forms.GroupBox();
            this.label_name1 = new System.Windows.Forms.Label();
            this.label_RPDU_rec = new System.Windows.Forms.Label();
            this.label_rpduN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_RPDU_power = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_power = new System.Windows.Forms.ComboBox();
            this.groupBox_RPDU_class = new System.Windows.Forms.GroupBox();
            this.label_class = new System.Windows.Forms.Label();
            this.button_RPDU_class = new System.Windows.Forms.Button();
            this.groupBox_RPDU_freq = new System.Windows.Forms.GroupBox();
            this.label_freq = new System.Windows.Forms.Label();
            this.button_RPDU_freq = new System.Windows.Forms.Button();
            this.groupBox_RPDU_set = new System.Windows.Forms.GroupBox();
            this.button_IZL_ON = new System.Windows.Forms.Button();
            this.button_UM_ON = new System.Windows.Forms.Button();
            this.button_RPDU_ON = new System.Windows.Forms.Button();
            this.groupBox_RPDU_state = new System.Windows.Forms.GroupBox();
            this.label_state = new System.Windows.Forms.Label();
            this.button_RPDU_OK = new System.Windows.Forms.Button();
            this.statusStrip_RPDU = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_RPDU = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_RPDU.SuspendLayout();
            this.groupBox_RPDU_power.SuspendLayout();
            this.groupBox_RPDU_class.SuspendLayout();
            this.groupBox_RPDU_freq.SuspendLayout();
            this.groupBox_RPDU_set.SuspendLayout();
            this.groupBox_RPDU_state.SuspendLayout();
            this.statusStrip_RPDU.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_RPDU
            // 
            this.groupBox_RPDU.Controls.Add(this.label_name1);
            this.groupBox_RPDU.Controls.Add(this.label_RPDU_rec);
            this.groupBox_RPDU.Controls.Add(this.label_rpduN);
            this.groupBox_RPDU.Controls.Add(this.label1);
            this.groupBox_RPDU.Controls.Add(this.groupBox_RPDU_power);
            this.groupBox_RPDU.Controls.Add(this.groupBox_RPDU_class);
            this.groupBox_RPDU.Controls.Add(this.groupBox_RPDU_freq);
            this.groupBox_RPDU.Controls.Add(this.groupBox_RPDU_set);
            this.groupBox_RPDU.Controls.Add(this.groupBox_RPDU_state);
            this.groupBox_RPDU.Location = new System.Drawing.Point(12, 3);
            this.groupBox_RPDU.Name = "groupBox_RPDU";
            this.groupBox_RPDU.Size = new System.Drawing.Size(600, 351);
            this.groupBox_RPDU.TabIndex = 0;
            this.groupBox_RPDU.TabStop = false;
            // 
            // label_name1
            // 
            this.label_name1.AutoSize = true;
            this.label_name1.Location = new System.Drawing.Point(452, 332);
            this.label_name1.Name = "label_name1";
            this.label_name1.Size = new System.Drawing.Size(84, 13);
            this.label_name1.TabIndex = 8;
            this.label_name1.Text = "Recieve status :";
            // 
            // label_RPDU_rec
            // 
            this.label_RPDU_rec.AutoSize = true;
            this.label_RPDU_rec.Location = new System.Drawing.Point(542, 332);
            this.label_RPDU_rec.Name = "label_RPDU_rec";
            this.label_RPDU_rec.Size = new System.Drawing.Size(22, 13);
            this.label_RPDU_rec.TabIndex = 7;
            this.label_RPDU_rec.Text = "OK";
            // 
            // label_rpduN
            // 
            this.label_rpduN.Location = new System.Drawing.Point(352, 16);
            this.label_rpduN.Name = "label_rpduN";
            this.label_rpduN.Size = new System.Drawing.Size(50, 15);
            this.label_rpduN.TabIndex = 6;
            this.label_rpduN.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SETTINGS OF RPDU №";
            // 
            // groupBox_RPDU_power
            // 
            this.groupBox_RPDU_power.Controls.Add(this.label6);
            this.groupBox_RPDU_power.Controls.Add(this.comboBox_power);
            this.groupBox_RPDU_power.Location = new System.Drawing.Point(6, 235);
            this.groupBox_RPDU_power.Name = "groupBox_RPDU_power";
            this.groupBox_RPDU_power.Size = new System.Drawing.Size(290, 90);
            this.groupBox_RPDU_power.TabIndex = 4;
            this.groupBox_RPDU_power.TabStop = false;
            this.groupBox_RPDU_power.Text = "Setting of power";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "P = ";
            // 
            // comboBox_power
            // 
            this.comboBox_power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_power.FormattingEnabled = true;
            this.comboBox_power.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.comboBox_power.Location = new System.Drawing.Point(51, 29);
            this.comboBox_power.Name = "comboBox_power";
            this.comboBox_power.Size = new System.Drawing.Size(121, 21);
            this.comboBox_power.TabIndex = 0;
            this.comboBox_power.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox_RPDU_class
            // 
            this.groupBox_RPDU_class.Controls.Add(this.label_class);
            this.groupBox_RPDU_class.Controls.Add(this.button_RPDU_class);
            this.groupBox_RPDU_class.Location = new System.Drawing.Point(6, 139);
            this.groupBox_RPDU_class.Name = "groupBox_RPDU_class";
            this.groupBox_RPDU_class.Size = new System.Drawing.Size(290, 90);
            this.groupBox_RPDU_class.TabIndex = 3;
            this.groupBox_RPDU_class.TabStop = false;
            this.groupBox_RPDU_class.Text = "Setting of class izluchenia";
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.BackColor = System.Drawing.SystemColors.Control;
            this.label_class.Location = new System.Drawing.Point(19, 43);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(102, 13);
            this.label_class.TabIndex = 1;
            this.label_class.Text = "E = F1B-6000--2400";
            // 
            // button_RPDU_class
            // 
            this.button_RPDU_class.Location = new System.Drawing.Point(224, 19);
            this.button_RPDU_class.Name = "button_RPDU_class";
            this.button_RPDU_class.Size = new System.Drawing.Size(60, 60);
            this.button_RPDU_class.TabIndex = 0;
            this.button_RPDU_class.Text = "SET";
            this.button_RPDU_class.UseVisualStyleBackColor = true;
            this.button_RPDU_class.Click += new System.EventHandler(this.button_RPDU_class_Click);
            // 
            // groupBox_RPDU_freq
            // 
            this.groupBox_RPDU_freq.Controls.Add(this.label_freq);
            this.groupBox_RPDU_freq.Controls.Add(this.button_RPDU_freq);
            this.groupBox_RPDU_freq.Location = new System.Drawing.Point(6, 43);
            this.groupBox_RPDU_freq.Name = "groupBox_RPDU_freq";
            this.groupBox_RPDU_freq.Size = new System.Drawing.Size(290, 90);
            this.groupBox_RPDU_freq.TabIndex = 2;
            this.groupBox_RPDU_freq.TabStop = false;
            this.groupBox_RPDU_freq.Text = "Setting of Frequency";
            // 
            // label_freq
            // 
            this.label_freq.AutoSize = true;
            this.label_freq.Location = new System.Drawing.Point(19, 43);
            this.label_freq.Name = "label_freq";
            this.label_freq.Size = new System.Drawing.Size(95, 13);
            this.label_freq.TabIndex = 1;
            this.label_freq.Text = "F = 10000,00 MHz";
            // 
            // button_RPDU_freq
            // 
            this.button_RPDU_freq.Location = new System.Drawing.Point(224, 19);
            this.button_RPDU_freq.Name = "button_RPDU_freq";
            this.button_RPDU_freq.Size = new System.Drawing.Size(60, 60);
            this.button_RPDU_freq.TabIndex = 0;
            this.button_RPDU_freq.Text = "SET";
            this.button_RPDU_freq.UseVisualStyleBackColor = true;
            this.button_RPDU_freq.Click += new System.EventHandler(this.button_RPDU_freq_Click);
            // 
            // groupBox_RPDU_set
            // 
            this.groupBox_RPDU_set.Controls.Add(this.button_IZL_ON);
            this.groupBox_RPDU_set.Controls.Add(this.button_UM_ON);
            this.groupBox_RPDU_set.Controls.Add(this.button_RPDU_ON);
            this.groupBox_RPDU_set.Location = new System.Drawing.Point(304, 139);
            this.groupBox_RPDU_set.Name = "groupBox_RPDU_set";
            this.groupBox_RPDU_set.Size = new System.Drawing.Size(290, 186);
            this.groupBox_RPDU_set.TabIndex = 1;
            this.groupBox_RPDU_set.TabStop = false;
            this.groupBox_RPDU_set.Text = "RPDU Settings";
            // 
            // button_IZL_ON
            // 
            this.button_IZL_ON.Location = new System.Drawing.Point(208, 66);
            this.button_IZL_ON.Name = "button_IZL_ON";
            this.button_IZL_ON.Size = new System.Drawing.Size(60, 60);
            this.button_IZL_ON.TabIndex = 2;
            this.button_IZL_ON.Text = "IZL OFF";
            this.button_IZL_ON.UseVisualStyleBackColor = true;
            // 
            // button_UM_ON
            // 
            this.button_UM_ON.Location = new System.Drawing.Point(115, 66);
            this.button_UM_ON.Name = "button_UM_ON";
            this.button_UM_ON.Size = new System.Drawing.Size(60, 60);
            this.button_UM_ON.TabIndex = 1;
            this.button_UM_ON.Text = "UM OFF";
            this.button_UM_ON.UseVisualStyleBackColor = true;
            // 
            // button_RPDU_ON
            // 
            this.button_RPDU_ON.Location = new System.Drawing.Point(20, 66);
            this.button_RPDU_ON.Name = "button_RPDU_ON";
            this.button_RPDU_ON.Size = new System.Drawing.Size(60, 60);
            this.button_RPDU_ON.TabIndex = 0;
            this.button_RPDU_ON.Text = "RPDU OFF";
            this.button_RPDU_ON.UseVisualStyleBackColor = true;
            this.button_RPDU_ON.Click += new System.EventHandler(this.button_RPDU_ON_Click);
            // 
            // groupBox_RPDU_state
            // 
            this.groupBox_RPDU_state.Controls.Add(this.label_state);
            this.groupBox_RPDU_state.Location = new System.Drawing.Point(302, 43);
            this.groupBox_RPDU_state.Name = "groupBox_RPDU_state";
            this.groupBox_RPDU_state.Size = new System.Drawing.Size(290, 90);
            this.groupBox_RPDU_state.TabIndex = 0;
            this.groupBox_RPDU_state.TabStop = false;
            this.groupBox_RPDU_state.Text = "RPDU State";
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Location = new System.Drawing.Point(22, 43);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(73, 13);
            this.label_state.TabIndex = 0;
            this.label_state.Text = "ГОТОВ К ДУ";
            // 
            // button_RPDU_OK
            // 
            this.button_RPDU_OK.Location = new System.Drawing.Point(262, 360);
            this.button_RPDU_OK.Name = "button_RPDU_OK";
            this.button_RPDU_OK.Size = new System.Drawing.Size(80, 50);
            this.button_RPDU_OK.TabIndex = 1;
            this.button_RPDU_OK.Text = "OK";
            this.button_RPDU_OK.UseVisualStyleBackColor = true;
            this.button_RPDU_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip_RPDU
            // 
            this.statusStrip_RPDU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_RPDU});
            this.statusStrip_RPDU.Location = new System.Drawing.Point(0, 420);
            this.statusStrip_RPDU.Name = "statusStrip_RPDU";
            this.statusStrip_RPDU.Size = new System.Drawing.Size(624, 22);
            this.statusStrip_RPDU.TabIndex = 2;
            this.statusStrip_RPDU.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_RPDU
            // 
            this.toolStripStatusLabel_RPDU.AutoSize = false;
            this.toolStripStatusLabel_RPDU.Name = "toolStripStatusLabel_RPDU";
            this.toolStripStatusLabel_RPDU.Size = new System.Drawing.Size(300, 17);
            this.toolStripStatusLabel_RPDU.Text = "The last command is here.";
            // 
            // RPDU_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.statusStrip_RPDU);
            this.Controls.Add(this.button_RPDU_OK);
            this.Controls.Add(this.groupBox_RPDU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RPDU_form";
            this.Text = "RPDU";
            this.groupBox_RPDU.ResumeLayout(false);
            this.groupBox_RPDU.PerformLayout();
            this.groupBox_RPDU_power.ResumeLayout(false);
            this.groupBox_RPDU_power.PerformLayout();
            this.groupBox_RPDU_class.ResumeLayout(false);
            this.groupBox_RPDU_class.PerformLayout();
            this.groupBox_RPDU_freq.ResumeLayout(false);
            this.groupBox_RPDU_freq.PerformLayout();
            this.groupBox_RPDU_set.ResumeLayout(false);
            this.groupBox_RPDU_state.ResumeLayout(false);
            this.groupBox_RPDU_state.PerformLayout();
            this.statusStrip_RPDU.ResumeLayout(false);
            this.statusStrip_RPDU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_RPDU;
        private System.Windows.Forms.GroupBox groupBox_RPDU_power;
        private System.Windows.Forms.GroupBox groupBox_RPDU_class;
        private System.Windows.Forms.GroupBox groupBox_RPDU_freq;
        private System.Windows.Forms.GroupBox groupBox_RPDU_set;
        private System.Windows.Forms.GroupBox groupBox_RPDU_state;
        private System.Windows.Forms.Button button_RPDU_OK;
        private System.Windows.Forms.Label label_rpduN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_power;
        private System.Windows.Forms.Button button_RPDU_class;
        private System.Windows.Forms.Button button_RPDU_freq;
        private System.Windows.Forms.Button button_IZL_ON;
        private System.Windows.Forms.Button button_UM_ON;
        private System.Windows.Forms.Button button_RPDU_ON;
        private System.Windows.Forms.Label label_name1;
        private System.Windows.Forms.Label label_RPDU_rec;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Label label_freq;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.StatusStrip statusStrip_RPDU;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_RPDU;
        private System.Windows.Forms.Label label6;
    }
}