namespace serialtest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            connectButton = new Button();
            messageLog = new ListBox();
            messageInput = new TextBox();
            sendButton = new Button();
            button1 = new Button();
            comSelect = new ComboBox();
            clearButton = new Button();
            SuspendLayout();
            // 
            // connectButton
            // 
            connectButton.Location = new Point(181, 22);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(42, 23);
            connectButton.TabIndex = 1;
            connectButton.Text = "接続";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // messageLog
            // 
            messageLog.FormattingEnabled = true;
            messageLog.ItemHeight = 15;
            messageLog.Location = new Point(50, 68);
            messageLog.Name = "messageLog";
            messageLog.Size = new Size(522, 259);
            messageLog.TabIndex = 2;
            // 
            // messageInput
            // 
            messageInput.Location = new Point(50, 360);
            messageInput.Name = "messageInput";
            messageInput.Size = new Size(473, 23);
            messageInput.TabIndex = 3;
            messageInput.KeyDown += messageInput_KeyDown;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(529, 360);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(43, 23);
            sendButton.TabIndex = 4;
            sendButton.Text = "📩";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_ClickAsync;
            // 
            // button1
            // 
            button1.Location = new Point(529, 22);
            button1.Name = "button1";
            button1.Size = new Size(43, 23);
            button1.TabIndex = 5;
            button1.Text = "設定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comSelect
            // 
            comSelect.FormattingEnabled = true;
            comSelect.Location = new Point(50, 22);
            comSelect.Name = "comSelect";
            comSelect.Size = new Size(121, 23);
            comSelect.TabIndex = 7;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(505, 332);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(67, 22);
            clearButton.TabIndex = 8;
            clearButton.Text = "ログを消去";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 409);
            Controls.Add(clearButton);
            Controls.Add(comSelect);
            Controls.Add(button1);
            Controls.Add(sendButton);
            Controls.Add(messageInput);
            Controls.Add(messageLog);
            Controls.Add(connectButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button connectButton;
        public ListBox messageLog;
        private TextBox messageInput;
        private Button sendButton;
        private Button button1;
        private ComboBox comSelect;
        private Button clearButton;
    }
}