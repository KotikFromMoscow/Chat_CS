namespace MyChat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AutoButton = new System.Windows.Forms.Button();
            this.MyPort = new System.Windows.Forms.TextBox();
            this.MyIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutPort = new System.Windows.Forms.TextBox();
            this.OutIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ReciveTextBox = new System.Windows.Forms.ListBox();
            this.Server = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.AutoButton);
            this.groupBox1.Controls.Add(this.MyPort);
            this.groupBox1.Controls.Add(this.MyIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(74, 58);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(229, 22);
            this.NameBox.TabIndex = 5;
            // 
            // AutoButton
            // 
            this.AutoButton.Location = new System.Drawing.Point(195, 84);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(108, 22);
            this.AutoButton.TabIndex = 4;
            this.AutoButton.Text = "Auto";
            this.AutoButton.UseVisualStyleBackColor = true;
            this.AutoButton.Click += new System.EventHandler(this.AutoButton_Click);
            // 
            // MyPort
            // 
            this.MyPort.Location = new System.Drawing.Point(74, 84);
            this.MyPort.Name = "MyPort";
            this.MyPort.Size = new System.Drawing.Size(115, 22);
            this.MyPort.TabIndex = 3;
            // 
            // MyIP
            // 
            this.MyIP.Location = new System.Drawing.Point(74, 30);
            this.MyIP.Name = "MyIP";
            this.MyIP.Size = new System.Drawing.Size(229, 22);
            this.MyIP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutPort);
            this.groupBox2.Controls.Add(this.OutIP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(327, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outside";
            // 
            // OutPort
            // 
            this.OutPort.Location = new System.Drawing.Point(54, 84);
            this.OutPort.Name = "OutPort";
            this.OutPort.Size = new System.Drawing.Size(125, 22);
            this.OutPort.TabIndex = 4;
            // 
            // OutIP
            // 
            this.OutIP.Location = new System.Drawing.Point(54, 30);
            this.OutIP.Name = "OutIP";
            this.OutIP.Size = new System.Drawing.Size(249, 22);
            this.OutIP.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Connect.Location = new System.Drawing.Point(642, 96);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(129, 47);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SendTextBox
            // 
            this.SendTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendTextBox.Location = new System.Drawing.Point(12, 502);
            this.SendTextBox.Multiline = true;
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(624, 47);
            this.SendTextBox.TabIndex = 4;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.Location = new System.Drawing.Point(642, 502);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(129, 47);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ReciveTextBox
            // 
            this.ReciveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReciveTextBox.FormattingEnabled = true;
            this.ReciveTextBox.ItemHeight = 20;
            this.ReciveTextBox.Location = new System.Drawing.Point(12, 149);
            this.ReciveTextBox.Name = "ReciveTextBox";
            this.ReciveTextBox.Size = new System.Drawing.Size(759, 344);
            this.ReciveTextBox.TabIndex = 6;
            // 
            // Server
            // 
            this.Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Server.Location = new System.Drawing.Point(642, 16);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(130, 48);
            this.Server.TabIndex = 7;
            this.Server.Text = "Start Server";
            this.Server.UseVisualStyleBackColor = true;
            this.Server.Click += new System.EventHandler(this.Server_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.ReciveTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "MyChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button AutoButton;
        public System.Windows.Forms.TextBox MyIP;
        public System.Windows.Forms.TextBox MyPort;
        public System.Windows.Forms.TextBox OutPort;
        public System.Windows.Forms.TextBox OutIP;
        public System.Windows.Forms.ListBox ReciveTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button Server;
    }
}

