namespace VMSPD_server
{
    partial class BSK_form
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
            this.groupBox_BSK = new System.Windows.Forms.GroupBox();
            this.button_BSK_OK = new System.Windows.Forms.Button();
            this.statusStrip_BSK = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_BSK = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_bsk = new System.Windows.Forms.Label();
            this.groupBox_CH1 = new System.Windows.Forms.GroupBox();
            this.groupBox_CH2 = new System.Windows.Forms.GroupBox();
            this.groupBox_Plata = new System.Windows.Forms.GroupBox();
            this.groupBox_CH3 = new System.Windows.Forms.GroupBox();
            this.comboBox_BSK_CH1 = new System.Windows.Forms.ComboBox();
            this.comboBox_BSK_CH2 = new System.Windows.Forms.ComboBox();
            this.comboBox_BSK_CH3 = new System.Windows.Forms.ComboBox();
            this.label_t_CH1 = new System.Windows.Forms.Label();
            this.label_t_CH2 = new System.Windows.Forms.Label();
            this.label_t_CH3 = new System.Windows.Forms.Label();
            this.label_t_plata = new System.Windows.Forms.Label();
            this.label_name_s = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_f1 = new System.Windows.Forms.Label();
            this.label_f2 = new System.Windows.Forms.Label();
            this.label_f3 = new System.Windows.Forms.Label();
            this.groupBox_BSK.SuspendLayout();
            this.statusStrip_BSK.SuspendLayout();
            this.groupBox_CH1.SuspendLayout();
            this.groupBox_CH2.SuspendLayout();
            this.groupBox_Plata.SuspendLayout();
            this.groupBox_CH3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_BSK
            // 
            this.groupBox_BSK.Controls.Add(this.groupBox_CH2);
            this.groupBox_BSK.Controls.Add(this.groupBox_CH3);
            this.groupBox_BSK.Controls.Add(this.groupBox_Plata);
            this.groupBox_BSK.Controls.Add(this.groupBox_CH1);
            this.groupBox_BSK.Controls.Add(this.label_bsk);
            this.groupBox_BSK.Location = new System.Drawing.Point(12, 3);
            this.groupBox_BSK.Name = "groupBox_BSK";
            this.groupBox_BSK.Size = new System.Drawing.Size(600, 360);
            this.groupBox_BSK.TabIndex = 0;
            this.groupBox_BSK.TabStop = false;
            // 
            // button_BSK_OK
            // 
            this.button_BSK_OK.Location = new System.Drawing.Point(275, 367);
            this.button_BSK_OK.Name = "button_BSK_OK";
            this.button_BSK_OK.Size = new System.Drawing.Size(80, 50);
            this.button_BSK_OK.TabIndex = 1;
            this.button_BSK_OK.Text = "OK";
            this.button_BSK_OK.UseVisualStyleBackColor = true;
            this.button_BSK_OK.Click += new System.EventHandler(this.button_BSK_OK_Click);
            // 
            // statusStrip_BSK
            // 
            this.statusStrip_BSK.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_BSK});
            this.statusStrip_BSK.Location = new System.Drawing.Point(0, 420);
            this.statusStrip_BSK.Name = "statusStrip_BSK";
            this.statusStrip_BSK.Size = new System.Drawing.Size(624, 22);
            this.statusStrip_BSK.TabIndex = 2;
            this.statusStrip_BSK.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_BSK
            // 
            this.toolStripStatusLabel_BSK.AutoSize = false;
            this.toolStripStatusLabel_BSK.Name = "toolStripStatusLabel_BSK";
            this.toolStripStatusLabel_BSK.Size = new System.Drawing.Size(300, 17);
            this.toolStripStatusLabel_BSK.Text = "The last command is here.";
            // 
            // label_bsk
            // 
            this.label_bsk.AutoSize = true;
            this.label_bsk.Location = new System.Drawing.Point(260, 0);
            this.label_bsk.Name = "label_bsk";
            this.label_bsk.Size = new System.Drawing.Size(102, 13);
            this.label_bsk.TabIndex = 0;
            this.label_bsk.Text = "SETTINGS OF BSK";
            // 
            // groupBox_CH1
            // 
            this.groupBox_CH1.Controls.Add(this.label_f1);
            this.groupBox_CH1.Controls.Add(this.label_t_CH1);
            this.groupBox_CH1.Controls.Add(this.comboBox_BSK_CH1);
            this.groupBox_CH1.Location = new System.Drawing.Point(4, 19);
            this.groupBox_CH1.Name = "groupBox_CH1";
            this.groupBox_CH1.Size = new System.Drawing.Size(590, 80);
            this.groupBox_CH1.TabIndex = 1;
            this.groupBox_CH1.TabStop = false;
            this.groupBox_CH1.Text = "Channel №1";
            // 
            // groupBox_CH2
            // 
            this.groupBox_CH2.Controls.Add(this.label_f2);
            this.groupBox_CH2.Controls.Add(this.label_t_CH2);
            this.groupBox_CH2.Controls.Add(this.comboBox_BSK_CH2);
            this.groupBox_CH2.Location = new System.Drawing.Point(6, 102);
            this.groupBox_CH2.Name = "groupBox_CH2";
            this.groupBox_CH2.Size = new System.Drawing.Size(590, 80);
            this.groupBox_CH2.TabIndex = 2;
            this.groupBox_CH2.TabStop = false;
            this.groupBox_CH2.Text = "Channel №2";
            // 
            // groupBox_Plata
            // 
            this.groupBox_Plata.Controls.Add(this.label_status);
            this.groupBox_Plata.Controls.Add(this.label_name_s);
            this.groupBox_Plata.Controls.Add(this.label_t_plata);
            this.groupBox_Plata.Location = new System.Drawing.Point(4, 271);
            this.groupBox_Plata.Name = "groupBox_Plata";
            this.groupBox_Plata.Size = new System.Drawing.Size(590, 80);
            this.groupBox_Plata.TabIndex = 3;
            this.groupBox_Plata.TabStop = false;
            this.groupBox_Plata.Text = "Board";
            // 
            // groupBox_CH3
            // 
            this.groupBox_CH3.Controls.Add(this.label_f3);
            this.groupBox_CH3.Controls.Add(this.label_t_CH3);
            this.groupBox_CH3.Controls.Add(this.comboBox_BSK_CH3);
            this.groupBox_CH3.Location = new System.Drawing.Point(4, 188);
            this.groupBox_CH3.Name = "groupBox_CH3";
            this.groupBox_CH3.Size = new System.Drawing.Size(590, 80);
            this.groupBox_CH3.TabIndex = 4;
            this.groupBox_CH3.TabStop = false;
            this.groupBox_CH3.Text = "Channel №3";
            // 
            // comboBox_BSK_CH1
            // 
            this.comboBox_BSK_CH1.FormattingEnabled = true;
            this.comboBox_BSK_CH1.Items.AddRange(new object[] {
            "<OFF>",
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
            this.comboBox_BSK_CH1.Location = new System.Drawing.Point(6, 32);
            this.comboBox_BSK_CH1.Name = "comboBox_BSK_CH1";
            this.comboBox_BSK_CH1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BSK_CH1.TabIndex = 0;
            this.comboBox_BSK_CH1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_BSK_CH2
            // 
            this.comboBox_BSK_CH2.FormattingEnabled = true;
            this.comboBox_BSK_CH2.Items.AddRange(new object[] {
            "<OFF>",
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
            this.comboBox_BSK_CH2.Location = new System.Drawing.Point(4, 34);
            this.comboBox_BSK_CH2.Name = "comboBox_BSK_CH2";
            this.comboBox_BSK_CH2.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BSK_CH2.TabIndex = 0;
            // 
            // comboBox_BSK_CH3
            // 
            this.comboBox_BSK_CH3.FormattingEnabled = true;
            this.comboBox_BSK_CH3.Items.AddRange(new object[] {
            "<OFF>",
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
            this.comboBox_BSK_CH3.Location = new System.Drawing.Point(6, 40);
            this.comboBox_BSK_CH3.Name = "comboBox_BSK_CH3";
            this.comboBox_BSK_CH3.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BSK_CH3.TabIndex = 0;
            // 
            // label_t_CH1
            // 
            this.label_t_CH1.AutoSize = true;
            this.label_t_CH1.Location = new System.Drawing.Point(501, 32);
            this.label_t_CH1.Name = "label_t_CH1";
            this.label_t_CH1.Size = new System.Drawing.Size(44, 13);
            this.label_t_CH1.TabIndex = 1;
            this.label_t_CH1.Text = "t = 0 , C";
            // 
            // label_t_CH2
            // 
            this.label_t_CH2.AutoSize = true;
            this.label_t_CH2.Location = new System.Drawing.Point(499, 34);
            this.label_t_CH2.Name = "label_t_CH2";
            this.label_t_CH2.Size = new System.Drawing.Size(44, 13);
            this.label_t_CH2.TabIndex = 1;
            this.label_t_CH2.Text = "t = 0 , C";
            // 
            // label_t_CH3
            // 
            this.label_t_CH3.AutoSize = true;
            this.label_t_CH3.Location = new System.Drawing.Point(501, 40);
            this.label_t_CH3.Name = "label_t_CH3";
            this.label_t_CH3.Size = new System.Drawing.Size(44, 13);
            this.label_t_CH3.TabIndex = 1;
            this.label_t_CH3.Text = "t = 0 , C";
            // 
            // label_t_plata
            // 
            this.label_t_plata.AutoSize = true;
            this.label_t_plata.Location = new System.Drawing.Point(17, 40);
            this.label_t_plata.Name = "label_t_plata";
            this.label_t_plata.Size = new System.Drawing.Size(44, 13);
            this.label_t_plata.TabIndex = 0;
            this.label_t_plata.Text = "t = 0 , C";
            // 
            // label_name_s
            // 
            this.label_name_s.AutoSize = true;
            this.label_name_s.Location = new System.Drawing.Point(428, 40);
            this.label_name_s.Name = "label_name_s";
            this.label_name_s.Size = new System.Drawing.Size(84, 13);
            this.label_name_s.TabIndex = 1;
            this.label_name_s.Text = "Recieve status :";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(518, 40);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(22, 13);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "OK";
            // 
            // label_f1
            // 
            this.label_f1.AutoSize = true;
            this.label_f1.Location = new System.Drawing.Point(154, 39);
            this.label_f1.Name = "label_f1";
            this.label_f1.Size = new System.Drawing.Size(60, 13);
            this.label_f1.TabIndex = 2;
            this.label_f1.Text = "fan rotation";
            // 
            // label_f2
            // 
            this.label_f2.AutoSize = true;
            this.label_f2.Location = new System.Drawing.Point(152, 42);
            this.label_f2.Name = "label_f2";
            this.label_f2.Size = new System.Drawing.Size(60, 13);
            this.label_f2.TabIndex = 2;
            this.label_f2.Text = "fan rotation";
            // 
            // label_f3
            // 
            this.label_f3.AutoSize = true;
            this.label_f3.Location = new System.Drawing.Point(154, 48);
            this.label_f3.Name = "label_f3";
            this.label_f3.Size = new System.Drawing.Size(60, 13);
            this.label_f3.TabIndex = 2;
            this.label_f3.Text = "fan rotation";
            // 
            // BSK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.statusStrip_BSK);
            this.Controls.Add(this.button_BSK_OK);
            this.Controls.Add(this.groupBox_BSK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BSK";
            this.Text = "BSK";
            this.groupBox_BSK.ResumeLayout(false);
            this.groupBox_BSK.PerformLayout();
            this.statusStrip_BSK.ResumeLayout(false);
            this.statusStrip_BSK.PerformLayout();
            this.groupBox_CH1.ResumeLayout(false);
            this.groupBox_CH1.PerformLayout();
            this.groupBox_CH2.ResumeLayout(false);
            this.groupBox_CH2.PerformLayout();
            this.groupBox_Plata.ResumeLayout(false);
            this.groupBox_Plata.PerformLayout();
            this.groupBox_CH3.ResumeLayout(false);
            this.groupBox_CH3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_BSK;
        private System.Windows.Forms.Button button_BSK_OK;
        private System.Windows.Forms.StatusStrip statusStrip_BSK;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_BSK;
        private System.Windows.Forms.Label label_bsk;
        private System.Windows.Forms.GroupBox groupBox_CH2;
        private System.Windows.Forms.Label label_f2;
        private System.Windows.Forms.Label label_t_CH2;
        private System.Windows.Forms.ComboBox comboBox_BSK_CH2;
        private System.Windows.Forms.GroupBox groupBox_CH3;
        private System.Windows.Forms.Label label_f3;
        private System.Windows.Forms.Label label_t_CH3;
        private System.Windows.Forms.ComboBox comboBox_BSK_CH3;
        private System.Windows.Forms.GroupBox groupBox_Plata;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_name_s;
        private System.Windows.Forms.Label label_t_plata;
        private System.Windows.Forms.GroupBox groupBox_CH1;
        private System.Windows.Forms.Label label_f1;
        private System.Windows.Forms.Label label_t_CH1;
        private System.Windows.Forms.ComboBox comboBox_BSK_CH1;
    }
}