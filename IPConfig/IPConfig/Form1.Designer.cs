namespace IPConfig
{
    partial class NetworkInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkInterface));
            this.Top_label = new System.Windows.Forms.Label();
            this.GetIP_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetIP_label_information = new System.Windows.Forms.Label();
            this.GetIP_label3 = new System.Windows.Forms.Label();
            this.GetIP_button = new System.Windows.Forms.Button();
            this.ans_lebel = new System.Windows.Forms.Label();
            this.GetIP_result = new System.Windows.Forms.Label();
            this.GetInfo_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.connStatus_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RoundTrip_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Time_to_live_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fragment_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Buffer_size_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Top_label
            // 
            this.Top_label.AutoSize = true;
            this.Top_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top_label.Location = new System.Drawing.Point(12, 9);
            this.Top_label.Name = "Top_label";
            this.Top_label.Size = new System.Drawing.Size(452, 17);
            this.Top_label.TabIndex = 0;
            this.Top_label.Text = "This application help to get the Information related to network interface";
            // 
            // GetIP_label
            // 
            this.GetIP_label.AutoSize = true;
            this.GetIP_label.Location = new System.Drawing.Point(15, 44);
            this.GetIP_label.Name = "GetIP_label";
            this.GetIP_label.Size = new System.Drawing.Size(129, 13);
            this.GetIP_label.TabIndex = 1;
            this.GetIP_label.Text = "Enter the website address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 2;
            // 
            // GetIP_label_information
            // 
            this.GetIP_label_information.AutoSize = true;
            this.GetIP_label_information.ForeColor = System.Drawing.Color.Red;
            this.GetIP_label_information.Location = new System.Drawing.Point(148, 67);
            this.GetIP_label_information.Name = "GetIP_label_information";
            this.GetIP_label_information.Size = new System.Drawing.Size(14, 13);
            this.GetIP_label_information.TabIndex = 3;
            this.GetIP_label_information.Text = "* ";
            // 
            // GetIP_label3
            // 
            this.GetIP_label3.AutoSize = true;
            this.GetIP_label3.Location = new System.Drawing.Point(165, 67);
            this.GetIP_label3.Name = "GetIP_label3";
            this.GetIP_label3.Size = new System.Drawing.Size(228, 13);
            this.GetIP_label3.TabIndex = 4;
            this.GetIP_label3.Text = "use address like www.google.com or 127.0.0.1";
            // 
            // GetIP_button
            // 
            this.GetIP_button.Location = new System.Drawing.Point(391, 41);
            this.GetIP_button.Name = "GetIP_button";
            this.GetIP_button.Size = new System.Drawing.Size(75, 23);
            this.GetIP_button.TabIndex = 5;
            this.GetIP_button.Text = "Get IP";
            this.GetIP_button.UseVisualStyleBackColor = true;
            this.GetIP_button.Click += new System.EventHandler(this.GetIP_button_Click);
            // 
            // ans_lebel
            // 
            this.ans_lebel.AutoSize = true;
            this.ans_lebel.Location = new System.Drawing.Point(15, 98);
            this.ans_lebel.Name = "ans_lebel";
            this.ans_lebel.Size = new System.Drawing.Size(146, 13);
            this.ans_lebel.TabIndex = 6;
            this.ans_lebel.Text = "IP4 address of this website is ";
            // 
            // GetIP_result
            // 
            this.GetIP_result.AutoSize = true;
            this.GetIP_result.Location = new System.Drawing.Point(168, 98);
            this.GetIP_result.Name = "GetIP_result";
            this.GetIP_result.Size = new System.Drawing.Size(0, 13);
            this.GetIP_result.TabIndex = 7;
            // 
            // GetInfo_button
            // 
            this.GetInfo_button.Location = new System.Drawing.Point(473, 40);
            this.GetInfo_button.Name = "GetInfo_button";
            this.GetInfo_button.Size = new System.Drawing.Size(75, 23);
            this.GetInfo_button.TabIndex = 8;
            this.GetInfo_button.Text = "Get Info";
            this.GetInfo_button.UseVisualStyleBackColor = true;
            this.GetInfo_button.Click += new System.EventHandler(this.GetInfo_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Connection Status";
            // 
            // connStatus_label
            // 
            this.connStatus_label.AutoSize = true;
            this.connStatus_label.Location = new System.Drawing.Point(168, 115);
            this.connStatus_label.Name = "connStatus_label";
            this.connStatus_label.Size = new System.Drawing.Size(67, 13);
            this.connStatus_label.TabIndex = 10;
            this.connStatus_label.Text = "not checked";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(168, 138);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(0, 13);
            this.Address_label.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Round Trip Time";
            // 
            // RoundTrip_label
            // 
            this.RoundTrip_label.AutoSize = true;
            this.RoundTrip_label.Location = new System.Drawing.Point(168, 160);
            this.RoundTrip_label.Name = "RoundTrip_label";
            this.RoundTrip_label.Size = new System.Drawing.Size(0, 13);
            this.RoundTrip_label.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Time to live";
            // 
            // Time_to_live_label
            // 
            this.Time_to_live_label.AutoSize = true;
            this.Time_to_live_label.Location = new System.Drawing.Point(168, 183);
            this.Time_to_live_label.Name = "Time_to_live_label";
            this.Time_to_live_label.Size = new System.Drawing.Size(0, 13);
            this.Time_to_live_label.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Don\'t fragment";
            // 
            // fragment_label
            // 
            this.fragment_label.AutoSize = true;
            this.fragment_label.Location = new System.Drawing.Point(168, 205);
            this.fragment_label.Name = "fragment_label";
            this.fragment_label.Size = new System.Drawing.Size(0, 13);
            this.fragment_label.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Buffer size";
            // 
            // Buffer_size_label
            // 
            this.Buffer_size_label.AutoSize = true;
            this.Buffer_size_label.Location = new System.Drawing.Point(168, 233);
            this.Buffer_size_label.Name = "Buffer_size_label";
            this.Buffer_size_label.Size = new System.Drawing.Size(0, 13);
            this.Buffer_size_label.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Get Information is working for only 127.0.0.1 or localhost now ";
            // 
            // NetworkInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Buffer_size_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fragment_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Time_to_live_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RoundTrip_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connStatus_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetInfo_button);
            this.Controls.Add(this.GetIP_result);
            this.Controls.Add(this.ans_lebel);
            this.Controls.Add(this.GetIP_button);
            this.Controls.Add(this.GetIP_label3);
            this.Controls.Add(this.GetIP_label_information);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GetIP_label);
            this.Controls.Add(this.Top_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NetworkInterface";
            this.Text = "Network Interface Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Top_label;
        private System.Windows.Forms.Label GetIP_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label GetIP_label_information;
        private System.Windows.Forms.Label GetIP_label3;
        private System.Windows.Forms.Button GetIP_button;
        private System.Windows.Forms.Label ans_lebel;
        private System.Windows.Forms.Label GetIP_result;
        private System.Windows.Forms.Button GetInfo_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label connStatus_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RoundTrip_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Time_to_live_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label fragment_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Buffer_size_label;
        private System.Windows.Forms.Label label2;
    }
}

