namespace serialtest
{
    partial class Form2
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
            label2 = new Label();
            rateInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bitsInput = new TextBox();
            paritySelect = new ComboBox();
            stopSelect = new ComboBox();
            label6 = new Label();
            handshakeSelect = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            encodingSelect = new ComboBox();
            wtimeoutInput = new TextBox();
            rtimeoutInput = new TextBox();
            OKButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            newlineSelect = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 22);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "ビットレート";
            // 
            // rateInput
            // 
            rateInput.Location = new Point(131, 22);
            rateInput.Name = "rateInput";
            rateInput.Size = new Size(100, 23);
            rateInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 60);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "データビット";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 98);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "パリティ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 136);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 5;
            label5.Text = "ストップビット";
            // 
            // bitsInput
            // 
            bitsInput.Location = new Point(131, 60);
            bitsInput.Name = "bitsInput";
            bitsInput.Size = new Size(100, 23);
            bitsInput.TabIndex = 7;
            // 
            // paritySelect
            // 
            paritySelect.FormattingEnabled = true;
            paritySelect.Location = new Point(131, 98);
            paritySelect.Name = "paritySelect";
            paritySelect.Size = new Size(121, 23);
            paritySelect.TabIndex = 8;
            // 
            // stopSelect
            // 
            stopSelect.FormattingEnabled = true;
            stopSelect.Location = new Point(131, 136);
            stopSelect.Name = "stopSelect";
            stopSelect.Size = new Size(121, 23);
            stopSelect.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 174);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 10;
            label6.Text = "ハンドシェイク";
            // 
            // handshakeSelect
            // 
            handshakeSelect.FormattingEnabled = true;
            handshakeSelect.Location = new Point(131, 174);
            handshakeSelect.Name = "handshakeSelect";
            handshakeSelect.Size = new Size(121, 23);
            handshakeSelect.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(294, 22);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 13;
            label7.Text = "文字コード";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(294, 60);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 14;
            label8.Text = "Writeタイムアウト";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(294, 98);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 15;
            label9.Text = "Readタイムアウト";
            // 
            // encodingSelect
            // 
            encodingSelect.FormattingEnabled = true;
            encodingSelect.Location = new Point(395, 22);
            encodingSelect.Name = "encodingSelect";
            encodingSelect.Size = new Size(121, 23);
            encodingSelect.TabIndex = 16;
            // 
            // wtimeoutInput
            // 
            wtimeoutInput.Location = new Point(395, 60);
            wtimeoutInput.Name = "wtimeoutInput";
            wtimeoutInput.Size = new Size(100, 23);
            wtimeoutInput.TabIndex = 17;
            // 
            // rtimeoutInput
            // 
            rtimeoutInput.Location = new Point(395, 98);
            rtimeoutInput.Name = "rtimeoutInput";
            rtimeoutInput.Size = new Size(100, 23);
            rtimeoutInput.TabIndex = 18;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(320, 202);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(76, 30);
            OKButton.TabIndex = 19;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(438, 202);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(76, 30);
            cancelButton.TabIndex = 20;
            cancelButton.Text = "キャンセル";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 136);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 21;
            label1.Text = "改行文字";
            // 
            // newlineSelect
            // 
            newlineSelect.FormattingEnabled = true;
            newlineSelect.Location = new Point(395, 136);
            newlineSelect.Name = "newlineSelect";
            newlineSelect.Size = new Size(121, 23);
            newlineSelect.TabIndex = 22;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 256);
            Controls.Add(newlineSelect);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(OKButton);
            Controls.Add(rtimeoutInput);
            Controls.Add(wtimeoutInput);
            Controls.Add(encodingSelect);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(handshakeSelect);
            Controls.Add(label6);
            Controls.Add(stopSelect);
            Controls.Add(paritySelect);
            Controls.Add(bitsInput);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(rateInput);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox rateInput;
        private Label label3;
        private TextBox bitsInput;
        private Label label4;
        private ComboBox paritySelect;
        private Label label5;
        private ComboBox stopSelect;
        private Label label6;
        private ComboBox handshakeSelect;
        private Label label7;
        private ComboBox encodingSelect;
        private Label label8;
        private TextBox wtimeoutInput;
        private Label label9;
        private TextBox rtimeoutInput;
        private Button OKButton;
        private Button cancelButton;
        private Label label1;
        private ComboBox newlineSelect;
    }
}