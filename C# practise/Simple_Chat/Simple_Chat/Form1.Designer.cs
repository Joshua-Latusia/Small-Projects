namespace Simple_Chat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Connect_button = new System.Windows.Forms.Button();
            this.Send_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RemotePort = new System.Windows.Forms.TextBox();
            this.LocalIp = new System.Windows.Forms.TextBox();
            this.RemoteIp = new System.Windows.Forms.TextBox();
            this.LocalPort = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.MessageList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LocalPort);
            this.groupBox1.Controls.Add(this.LocalIp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoteIp);
            this.groupBox2.Controls.Add(this.RemotePort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(240, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(467, 31);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(75, 23);
            this.Connect_button.TabIndex = 0;
            this.Connect_button.Text = "Connect!";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // Send_Btn
            // 
            this.Send_Btn.Location = new System.Drawing.Point(467, 309);
            this.Send_Btn.Name = "Send_Btn";
            this.Send_Btn.Size = new System.Drawing.Size(75, 23);
            this.Send_Btn.TabIndex = 1;
            this.Send_Btn.Text = "Send";
            this.Send_Btn.UseVisualStyleBackColor = true;
            this.Send_Btn.Click += new System.EventHandler(this.Send_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "IP";
            // 
            // RemotePort
            // 
            this.RemotePort.Location = new System.Drawing.Point(79, 64);
            this.RemotePort.Name = "RemotePort";
            this.RemotePort.Size = new System.Drawing.Size(100, 20);
            this.RemotePort.TabIndex = 6;
            // 
            // LocalIp
            // 
            this.LocalIp.Location = new System.Drawing.Point(82, 26);
            this.LocalIp.Name = "LocalIp";
            this.LocalIp.Size = new System.Drawing.Size(100, 20);
            this.LocalIp.TabIndex = 7;
            // 
            // RemoteIp
            // 
            this.RemoteIp.Location = new System.Drawing.Point(79, 25);
            this.RemoteIp.Name = "RemoteIp";
            this.RemoteIp.Size = new System.Drawing.Size(100, 20);
            this.RemoteIp.TabIndex = 8;
            // 
            // LocalPort
            // 
            this.LocalPort.Location = new System.Drawing.Point(82, 64);
            this.LocalPort.Name = "LocalPort";
            this.LocalPort.Size = new System.Drawing.Size(100, 20);
            this.LocalPort.TabIndex = 9;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 309);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(428, 20);
            this.messageBox.TabIndex = 9;
            // 
            // MessageList
            // 
            this.MessageList.FormattingEnabled = true;
            this.MessageList.Location = new System.Drawing.Point(12, 140);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(428, 147);
            this.MessageList.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 352);
            this.Controls.Add(this.MessageList);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Send_Btn);
            this.Controls.Add(this.Connect_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LocalPort;
        private System.Windows.Forms.TextBox LocalIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox RemoteIp;
        private System.Windows.Forms.TextBox RemotePort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.Button Send_Btn;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.ListBox MessageList;
    }
}

