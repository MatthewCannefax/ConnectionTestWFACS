namespace ConnectionTestWFACS
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectionFeedListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.savedIPListBox = new System.Windows.Forms.ListBox();
            this.ipNameBox = new System.Windows.Forms.TextBox();
            this.ipAddressBox = new System.Windows.Forms.TextBox();
            this.intervalBOX = new System.Windows.Forms.TextBox();
            this.addIPBTN = new System.Windows.Forms.Button();
            this.removeIPBTN = new System.Windows.Forms.Button();
            this.startTestBTN = new System.Windows.Forms.Button();
            this.stopTestBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectionFeedListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Feed";
            // 
            // connectionFeedListBox
            // 
            this.connectionFeedListBox.FormattingEnabled = true;
            this.connectionFeedListBox.Location = new System.Drawing.Point(7, 20);
            this.connectionFeedListBox.Name = "connectionFeedListBox";
            this.connectionFeedListBox.Size = new System.Drawing.Size(331, 290);
            this.connectionFeedListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.savedIPListBox);
            this.groupBox2.Location = new System.Drawing.Point(362, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saved IPs";
            // 
            // savedIPListBox
            // 
            this.savedIPListBox.FormattingEnabled = true;
            this.savedIPListBox.Location = new System.Drawing.Point(7, 20);
            this.savedIPListBox.Name = "savedIPListBox";
            this.savedIPListBox.Size = new System.Drawing.Size(146, 290);
            this.savedIPListBox.TabIndex = 0;
            // 
            // ipNameBox
            // 
            this.ipNameBox.Location = new System.Drawing.Point(527, 32);
            this.ipNameBox.Name = "ipNameBox";
            this.ipNameBox.Size = new System.Drawing.Size(100, 20);
            this.ipNameBox.TabIndex = 2;
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.Location = new System.Drawing.Point(527, 58);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(100, 20);
            this.ipAddressBox.TabIndex = 3;
            // 
            // intervalBOX
            // 
            this.intervalBOX.Location = new System.Drawing.Point(527, 244);
            this.intervalBOX.Name = "intervalBOX";
            this.intervalBOX.Size = new System.Drawing.Size(100, 20);
            this.intervalBOX.TabIndex = 4;
            this.intervalBOX.TextChanged += new System.EventHandler(this.IntervalBOX_TextChanged);
            // 
            // addIPBTN
            // 
            this.addIPBTN.Location = new System.Drawing.Point(527, 84);
            this.addIPBTN.Name = "addIPBTN";
            this.addIPBTN.Size = new System.Drawing.Size(100, 23);
            this.addIPBTN.TabIndex = 5;
            this.addIPBTN.Text = "Add";
            this.addIPBTN.UseVisualStyleBackColor = true;
            this.addIPBTN.Click += new System.EventHandler(this.AddIPBTN_Click);
            // 
            // removeIPBTN
            // 
            this.removeIPBTN.Location = new System.Drawing.Point(527, 113);
            this.removeIPBTN.Name = "removeIPBTN";
            this.removeIPBTN.Size = new System.Drawing.Size(100, 23);
            this.removeIPBTN.TabIndex = 6;
            this.removeIPBTN.Text = "Remove";
            this.removeIPBTN.UseVisualStyleBackColor = true;
            this.removeIPBTN.Click += new System.EventHandler(this.RemoveIPBTN_Click);
            // 
            // startTestBTN
            // 
            this.startTestBTN.Location = new System.Drawing.Point(527, 270);
            this.startTestBTN.Name = "startTestBTN";
            this.startTestBTN.Size = new System.Drawing.Size(100, 23);
            this.startTestBTN.TabIndex = 7;
            this.startTestBTN.Text = "Start Test";
            this.startTestBTN.UseVisualStyleBackColor = true;
            this.startTestBTN.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopTestBTN
            // 
            this.stopTestBTN.Location = new System.Drawing.Point(527, 299);
            this.stopTestBTN.Name = "stopTestBTN";
            this.stopTestBTN.Size = new System.Drawing.Size(100, 23);
            this.stopTestBTN.TabIndex = 8;
            this.stopTestBTN.Text = "Stop Test";
            this.stopTestBTN.UseVisualStyleBackColor = true;
            this.stopTestBTN.Click += new System.EventHandler(this.StopTestBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Interval (seconds)";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 352);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopTestBTN);
            this.Controls.Add(this.startTestBTN);
            this.Controls.Add(this.removeIPBTN);
            this.Controls.Add(this.addIPBTN);
            this.Controls.Add(this.intervalBOX);
            this.Controls.Add(this.ipAddressBox);
            this.Controls.Add(this.ipNameBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsForm";
            this.Text = "Connection Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox connectionFeedListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox savedIPListBox;
        private System.Windows.Forms.TextBox ipNameBox;
        private System.Windows.Forms.TextBox ipAddressBox;
        private System.Windows.Forms.TextBox intervalBOX;
        private System.Windows.Forms.Button addIPBTN;
        private System.Windows.Forms.Button removeIPBTN;
        private System.Windows.Forms.Button startTestBTN;
        private System.Windows.Forms.Button stopTestBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

