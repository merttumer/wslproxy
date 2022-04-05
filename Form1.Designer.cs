namespace wslproxy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.forwardPortText = new System.Windows.Forms.TextBox();
            this.listenPortText = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addProxyBtn = new System.Windows.Forms.Button();
            this.forwardAddrText = new System.Windows.Forms.TextBox();
            this.listenAddrText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.getWSLIPBtn = new System.Windows.Forms.Button();
            this.wslipText = new System.Windows.Forms.TextBox();
            this.removeProxyBtn = new System.Windows.Forms.Button();
            this.refreshProxyListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.forwardPortText);
            this.panel1.Controls.Add(this.listenPortText);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addProxyBtn);
            this.panel1.Controls.Add(this.forwardAddrText);
            this.panel1.Controls.Add(this.listenAddrText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.getWSLIPBtn);
            this.panel1.Controls.Add(this.wslipText);
            this.panel1.Controls.Add(this.removeProxyBtn);
            this.panel1.Controls.Add(this.refreshProxyListBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 344);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(658, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Port";
            // 
            // forwardPortText
            // 
            this.forwardPortText.Location = new System.Drawing.Point(658, 225);
            this.forwardPortText.Name = "forwardPortText";
            this.forwardPortText.Size = new System.Drawing.Size(74, 23);
            this.forwardPortText.TabIndex = 14;
            // 
            // listenPortText
            // 
            this.listenPortText.Location = new System.Drawing.Point(658, 166);
            this.listenPortText.Name = "listenPortText";
            this.listenPortText.Size = new System.Drawing.Size(74, 23);
            this.listenPortText.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(16, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(504, 244);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Forward Addr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Listen Addr";
            // 
            // addProxyBtn
            // 
            this.addProxyBtn.Location = new System.Drawing.Point(557, 254);
            this.addProxyBtn.Name = "addProxyBtn";
            this.addProxyBtn.Size = new System.Drawing.Size(175, 34);
            this.addProxyBtn.TabIndex = 9;
            this.addProxyBtn.Text = "Add Proxy";
            this.addProxyBtn.UseVisualStyleBackColor = true;
            this.addProxyBtn.Click += new System.EventHandler(this.addProxyBtn_Click);
            // 
            // forwardAddrText
            // 
            this.forwardAddrText.Location = new System.Drawing.Point(557, 225);
            this.forwardAddrText.Name = "forwardAddrText";
            this.forwardAddrText.Size = new System.Drawing.Size(95, 23);
            this.forwardAddrText.TabIndex = 8;
            // 
            // listenAddrText
            // 
            this.listenAddrText.Location = new System.Drawing.Point(557, 166);
            this.listenAddrText.Name = "listenAddrText";
            this.listenAddrText.Size = new System.Drawing.Size(95, 23);
            this.listenAddrText.TabIndex = 7;
            this.listenAddrText.Text = "0.0.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "WSL ip";
            // 
            // getWSLIPBtn
            // 
            this.getWSLIPBtn.Location = new System.Drawing.Point(557, 72);
            this.getWSLIPBtn.Name = "getWSLIPBtn";
            this.getWSLIPBtn.Size = new System.Drawing.Size(175, 33);
            this.getWSLIPBtn.TabIndex = 5;
            this.getWSLIPBtn.Text = "Get IP";
            this.getWSLIPBtn.UseVisualStyleBackColor = true;
            this.getWSLIPBtn.Click += new System.EventHandler(this.getWSLIPBtn_Click);
            // 
            // wslipText
            // 
            this.wslipText.Location = new System.Drawing.Point(557, 43);
            this.wslipText.Name = "wslipText";
            this.wslipText.Size = new System.Drawing.Size(175, 23);
            this.wslipText.TabIndex = 4;
            // 
            // removeProxyBtn
            // 
            this.removeProxyBtn.BackColor = System.Drawing.Color.IndianRed;
            this.removeProxyBtn.Location = new System.Drawing.Point(349, 293);
            this.removeProxyBtn.Name = "removeProxyBtn";
            this.removeProxyBtn.Size = new System.Drawing.Size(82, 29);
            this.removeProxyBtn.TabIndex = 3;
            this.removeProxyBtn.Text = "Clear";
            this.removeProxyBtn.UseVisualStyleBackColor = false;
            this.removeProxyBtn.Click += new System.EventHandler(this.removeProxyBtn_Click);
            // 
            // refreshProxyListBtn
            // 
            this.refreshProxyListBtn.Location = new System.Drawing.Point(16, 293);
            this.refreshProxyListBtn.Name = "refreshProxyListBtn";
            this.refreshProxyListBtn.Size = new System.Drawing.Size(81, 29);
            this.refreshProxyListBtn.TabIndex = 2;
            this.refreshProxyListBtn.Text = "Refresh";
            this.refreshProxyListBtn.UseVisualStyleBackColor = true;
            this.refreshProxyListBtn.Click += new System.EventHandler(this.refreshProxyListBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proxy List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 368);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 407);
            this.MinimumSize = new System.Drawing.Size(800, 407);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wslProxy v0.1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button removeProxyBtn;
        private Button refreshProxyListBtn;
        private Label label2;
        private Button getWSLIPBtn;
        private TextBox wslipText;
        private Label label4;
        private Label label3;
        private Button addProxyBtn;
        private TextBox forwardAddrText;
        private TextBox listenAddrText;
        private RichTextBox richTextBox1;
        private Label label6;
        private Label label5;
        private TextBox forwardPortText;
        private TextBox listenPortText;
    }
}