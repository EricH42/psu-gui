namespace GUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Volt = new System.Windows.Forms.TextBox();
            this.txtBoxComport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_Current = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.txtSubscibe = new System.Windows.Forms.TextBox();
            this.txtPubText = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelPSUID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.txtSubscription = new System.Windows.Forms.TextBox();
            this.buttonSubscribe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Volt: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "SelectComport";
            // 
            // txtBox_Volt
            // 
            this.txtBox_Volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Volt.Location = new System.Drawing.Point(155, 101);
            this.txtBox_Volt.Name = "txtBox_Volt";
            this.txtBox_Volt.Size = new System.Drawing.Size(125, 20);
            this.txtBox_Volt.TabIndex = 6;
            // 
            // txtBoxComport
            // 
            this.txtBoxComport.Location = new System.Drawing.Point(155, 176);
            this.txtBoxComport.Name = "txtBoxComport";
            this.txtBoxComport.Size = new System.Drawing.Size(125, 27);
            this.txtBoxComport.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "PSU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 12;
            // 
            // txtBox_Current
            // 
            this.txtBox_Current.Location = new System.Drawing.Point(155, 133);
            this.txtBox_Current.Name = "txtBox_Current";
            this.txtBox_Current.Size = new System.Drawing.Size(125, 27);
            this.txtBox_Current.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Set volt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 15;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(552, 66);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(125, 27);
            this.txtConnectionString.TabIndex = 16;
            // 
            // txtSubscibe
            // 
            this.txtSubscibe.Location = new System.Drawing.Point(552, 116);
            this.txtSubscibe.Name = "txtSubscibe";
            this.txtSubscibe.Size = new System.Drawing.Size(125, 27);
            this.txtSubscibe.TabIndex = 17;
            // 
            // txtPubText
            // 
            this.txtPubText.Location = new System.Drawing.Point(552, 160);
            this.txtPubText.Name = "txtPubText";
            this.txtPubText.Size = new System.Drawing.Size(125, 27);
            this.txtPubText.TabIndex = 18;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(453, 69);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(93, 20);
            this.labelServer.TabIndex = 19;
            this.labelServer.Text = "MQTT Server";
            // 
            // labelPSUID
            // 
            this.labelPSUID.AutoSize = true;
            this.labelPSUID.Location = new System.Drawing.Point(467, 116);
            this.labelPSUID.Name = "labelPSUID";
            this.labelPSUID.Size = new System.Drawing.Size(54, 20);
            this.labelPSUID.TabIndex = 20;
            this.labelPSUID.Text = "PSU ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Topic to pub";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(703, 70);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(94, 29);
            this.buttonConnect.TabIndex = 22;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonPublish
            // 
            this.buttonPublish.Location = new System.Drawing.Point(703, 163);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(94, 29);
            this.buttonPublish.TabIndex = 23;
            this.buttonPublish.Text = "Publish";
            this.buttonPublish.UseVisualStyleBackColor = true;
            this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
            // 
            // txtSubscription
            // 
            this.txtSubscription.Location = new System.Drawing.Point(552, 215);
            this.txtSubscription.Name = "txtSubscription";
            this.txtSubscription.Size = new System.Drawing.Size(125, 27);
            this.txtSubscription.TabIndex = 25;
            // 
            // buttonSubscribe
            // 
            this.buttonSubscribe.Location = new System.Drawing.Point(703, 116);
            this.buttonSubscribe.Name = "buttonSubscribe";
            this.buttonSubscribe.Size = new System.Drawing.Size(94, 29);
            this.buttonSubscribe.TabIndex = 27;
            this.buttonSubscribe.Text = "Subscribe";
            this.buttonSubscribe.UseVisualStyleBackColor = true;
            this.buttonSubscribe.Click += new System.EventHandler(this.buttonSubscribe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.buttonSubscribe);
            this.Controls.Add(this.txtSubscription);
            this.Controls.Add(this.buttonPublish);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelPSUID);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.txtPubText);
            this.Controls.Add(this.txtSubscibe);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBox_Current);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxComport);
            this.Controls.Add(this.txtBox_Volt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label4;
        private TextBox txtBox_Volt;
        private TextBox txtBoxComport;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtBox_Current;
        private Button button2;
        private TextBox textBox1;
        private TextBox txtConnectionString;
        private TextBox txtSubscibe;
        private TextBox txtPubText;
        private Label labelServer;
        private Label labelPSUID;
        private Label label9;
        private Button buttonConnect;
        private Button buttonPublish;
        private TextBox txtSubscription;
        private Button buttonSubscribe;
    }
}