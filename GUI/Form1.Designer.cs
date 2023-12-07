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
            this.txtBox_Volt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_Current = new System.Windows.Forms.TextBox();
            this.txtSetVoltage = new System.Windows.Forms.TextBox();
            this.txtSubscibe = new System.Windows.Forms.TextBox();
            this.txtPSULabel = new System.Windows.Forms.TextBox();
            this.labelPSUID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.txtSubscription = new System.Windows.Forms.TextBox();
            this.buttonSubscribe = new System.Windows.Forms.Button();
            this.txtPubText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TurnOnRemote = new System.Windows.Forms.Button();
            this.LabelRemoteOn = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.btnSetVoltage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get ports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Volt: ";
            // 
            // txtBox_Volt
            // 
            this.txtBox_Volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Volt.Location = new System.Drawing.Point(155, 39);
            this.txtBox_Volt.Name = "txtBox_Volt";
            this.txtBox_Volt.Size = new System.Drawing.Size(125, 20);
            this.txtBox_Volt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "COM";
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
            this.txtBox_Current.Location = new System.Drawing.Point(155, 83);
            this.txtBox_Current.Name = "txtBox_Current";
            this.txtBox_Current.Size = new System.Drawing.Size(125, 27);
            this.txtBox_Current.TabIndex = 13;
            // 
            // txtSetVoltage
            // 
            this.txtSetVoltage.Location = new System.Drawing.Point(155, 136);
            this.txtSetVoltage.Name = "txtSetVoltage";
            this.txtSetVoltage.Size = new System.Drawing.Size(125, 27);
            this.txtSetVoltage.TabIndex = 15;
            // 
            // txtSubscibe
            // 
            this.txtSubscibe.Location = new System.Drawing.Point(587, 36);
            this.txtSubscibe.Name = "txtSubscibe";
            this.txtSubscibe.Size = new System.Drawing.Size(125, 27);
            this.txtSubscibe.TabIndex = 17;
            // 
            // txtPSULabel
            // 
            this.txtPSULabel.Location = new System.Drawing.Point(587, 79);
            this.txtPSULabel.Name = "txtPSULabel";
            this.txtPSULabel.Size = new System.Drawing.Size(125, 27);
            this.txtPSULabel.TabIndex = 18;
            // 
            // labelPSUID
            // 
            this.labelPSUID.AutoSize = true;
            this.labelPSUID.Location = new System.Drawing.Point(513, 39);
            this.labelPSUID.Name = "labelPSUID";
            this.labelPSUID.Size = new System.Drawing.Size(54, 20);
            this.labelPSUID.TabIndex = 20;
            this.labelPSUID.Text = "PSU ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Label on PSU";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(155, 405);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(94, 29);
            this.buttonConnect.TabIndex = 22;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonPublish
            // 
            this.buttonPublish.Location = new System.Drawing.Point(738, 122);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(94, 29);
            this.buttonPublish.TabIndex = 23;
            this.buttonPublish.Text = "Publish";
            this.buttonPublish.UseVisualStyleBackColor = true;
            this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
            // 
            // txtSubscription
            // 
            this.txtSubscription.Location = new System.Drawing.Point(587, 180);
            this.txtSubscription.Name = "txtSubscription";
            this.txtSubscription.Size = new System.Drawing.Size(125, 27);
            this.txtSubscription.TabIndex = 25;
            // 
            // buttonSubscribe
            // 
            this.buttonSubscribe.Location = new System.Drawing.Point(738, 78);
            this.buttonSubscribe.Name = "buttonSubscribe";
            this.buttonSubscribe.Size = new System.Drawing.Size(94, 29);
            this.buttonSubscribe.TabIndex = 27;
            this.buttonSubscribe.Text = "Subscribe";
            this.buttonSubscribe.UseVisualStyleBackColor = true;
            this.buttonSubscribe.Click += new System.EventHandler(this.buttonSubscribe_Click);
            // 
            // txtPubText
            // 
            this.txtPubText.Location = new System.Drawing.Point(587, 124);
            this.txtPubText.Name = "txtPubText";
            this.txtPubText.Size = new System.Drawing.Size(125, 27);
            this.txtPubText.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Topic to pub";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "MQTT local broker";
            // 
            // TurnOnRemote
            // 
            this.TurnOnRemote.Location = new System.Drawing.Point(155, 370);
            this.TurnOnRemote.Name = "TurnOnRemote";
            this.TurnOnRemote.Size = new System.Drawing.Size(94, 29);
            this.TurnOnRemote.TabIndex = 31;
            this.TurnOnRemote.Text = "Press";
            this.TurnOnRemote.UseVisualStyleBackColor = true;
            this.TurnOnRemote.Click += new System.EventHandler(this.TurnOnRemote_Click);
            // 
            // LabelRemoteOn
            // 
            this.LabelRemoteOn.AutoSize = true;
            this.LabelRemoteOn.Location = new System.Drawing.Point(38, 374);
            this.LabelRemoteOn.Name = "LabelRemoteOn";
            this.LabelRemoteOn.Size = new System.Drawing.Size(111, 20);
            this.LabelRemoteOn.TabIndex = 32;
            this.LabelRemoteOn.Text = "Turn on remote";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(513, 183);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(37, 20);
            this.labelPath.TabIndex = 34;
            this.labelPath.Text = "Path";
            // 
            // btnSetVoltage
            // 
            this.btnSetVoltage.Location = new System.Drawing.Point(310, 135);
            this.btnSetVoltage.Name = "btnSetVoltage";
            this.btnSetVoltage.Size = new System.Drawing.Size(94, 29);
            this.btnSetVoltage.TabIndex = 14;
            this.btnSetVoltage.Text = "Set";
            this.btnSetVoltage.UseVisualStyleBackColor = true;
            this.btnSetVoltage.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Volt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.LabelRemoteOn);
            this.Controls.Add(this.TurnOnRemote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPubText);
            this.Controls.Add(this.buttonSubscribe);
            this.Controls.Add(this.txtSubscription);
            this.Controls.Add(this.buttonPublish);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelPSUID);
            this.Controls.Add(this.txtPSULabel);
            this.Controls.Add(this.txtSubscibe);
            this.Controls.Add(this.txtSetVoltage);
            this.Controls.Add(this.btnSetVoltage);
            this.Controls.Add(this.txtBox_Current);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Volt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label label1;
        private TextBox txtBox_Volt;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtBox_Current;
        private TextBox txtSetVoltage;
        private TextBox txtSubscibe;
        private TextBox txtPSULabel;
        private Label labelPSUID;
        private Label label9;
        private Button buttonConnect;
        private Button buttonPublish;
        private TextBox txtSubscription;
        private Button buttonSubscribe;
        private TextBox txtPubText;
        private Label label7;
        private Label label8;
        private Button TurnOnRemote;
        private Label LabelRemoteOn;
        private Label labelPath;
        private Button btnSetVoltage;
        private Label label4;
    }
}