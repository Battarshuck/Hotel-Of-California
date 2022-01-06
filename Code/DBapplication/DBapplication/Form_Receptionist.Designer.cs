namespace DBapplication
{
    partial class Form_Receptionist
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
            this.CheckRoomTypeCombo = new System.Windows.Forms.ComboBox();
            this.CheckRoomViewCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckRoomAvailableBTN = new System.Windows.Forms.Button();
            this.CheckStartDate = new System.Windows.Forms.DateTimePicker();
            this.CheckEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReserveBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckUSSN = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckRoomNO = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CheckRoomNO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CheckUSSN);
            this.groupBox1.Controls.Add(this.ReserveBTN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CheckEndDate);
            this.groupBox1.Controls.Add(this.CheckStartDate);
            this.groupBox1.Controls.Add(this.CheckRoomAvailableBTN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CheckRoomViewCombo);
            this.groupBox1.Controls.Add(this.CheckRoomTypeCombo);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check and book room";
            // 
            // CheckRoomTypeCombo
            // 
            this.CheckRoomTypeCombo.FormattingEnabled = true;
            this.CheckRoomTypeCombo.Location = new System.Drawing.Point(77, 33);
            this.CheckRoomTypeCombo.Name = "CheckRoomTypeCombo";
            this.CheckRoomTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.CheckRoomTypeCombo.TabIndex = 0;
            // 
            // CheckRoomViewCombo
            // 
            this.CheckRoomViewCombo.FormattingEnabled = true;
            this.CheckRoomViewCombo.Location = new System.Drawing.Point(329, 33);
            this.CheckRoomViewCombo.Name = "CheckRoomViewCombo";
            this.CheckRoomViewCombo.Size = new System.Drawing.Size(121, 21);
            this.CheckRoomViewCombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room view";
            // 
            // CheckRoomAvailableBTN
            // 
            this.CheckRoomAvailableBTN.Location = new System.Drawing.Point(86, 125);
            this.CheckRoomAvailableBTN.Name = "CheckRoomAvailableBTN";
            this.CheckRoomAvailableBTN.Size = new System.Drawing.Size(127, 30);
            this.CheckRoomAvailableBTN.TabIndex = 4;
            this.CheckRoomAvailableBTN.Text = "Check availablity";
            this.CheckRoomAvailableBTN.UseVisualStyleBackColor = true;
            this.CheckRoomAvailableBTN.Click += new System.EventHandler(this.CheckRoomAvailableBTN_Click);
            // 
            // CheckStartDate
            // 
            this.CheckStartDate.CustomFormat = "yyyy-MM-dd";
            this.CheckStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckStartDate.Location = new System.Drawing.Point(77, 71);
            this.CheckStartDate.Name = "CheckStartDate";
            this.CheckStartDate.Size = new System.Drawing.Size(121, 20);
            this.CheckStartDate.TabIndex = 5;
            // 
            // CheckEndDate
            // 
            this.CheckEndDate.CustomFormat = "yyyy-MM-dd";
            this.CheckEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckEndDate.Location = new System.Drawing.Point(329, 71);
            this.CheckEndDate.Name = "CheckEndDate";
            this.CheckEndDate.Size = new System.Drawing.Size(121, 20);
            this.CheckEndDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Date";
            // 
            // ReserveBTN
            // 
            this.ReserveBTN.Location = new System.Drawing.Point(268, 125);
            this.ReserveBTN.Name = "ReserveBTN";
            this.ReserveBTN.Size = new System.Drawing.Size(127, 30);
            this.ReserveBTN.TabIndex = 9;
            this.ReserveBTN.Text = "Reserve room";
            this.ReserveBTN.UseVisualStyleBackColor = true;
            this.ReserveBTN.Click += new System.EventHandler(this.ReserveBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "User SSN";
            // 
            // CheckUSSN
            // 
            this.CheckUSSN.FormattingEnabled = true;
            this.CheckUSSN.Location = new System.Drawing.Point(551, 33);
            this.CheckUSSN.Name = "CheckUSSN";
            this.CheckUSSN.Size = new System.Drawing.Size(131, 21);
            this.CheckUSSN.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Room Number";
            this.label6.VisibleChanged += new System.EventHandler(this.label6_VisibleChanged);
            // 
            // CheckRoomNO
            // 
            this.CheckRoomNO.FormattingEnabled = true;
            this.CheckRoomNO.Location = new System.Drawing.Point(551, 68);
            this.CheckRoomNO.Name = "CheckRoomNO";
            this.CheckRoomNO.Size = new System.Drawing.Size(131, 21);
            this.CheckRoomNO.TabIndex = 12;
            this.CheckRoomNO.VisibleChanged += new System.EventHandler(this.label6_VisibleChanged);
            // 
            // Form_Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 608);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Receptionist";
            this.Text = "Form_Receptionist";
            this.Load += new System.EventHandler(this.Form_Receptionist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CheckRoomViewCombo;
        private System.Windows.Forms.ComboBox CheckRoomTypeCombo;
        private System.Windows.Forms.Button CheckRoomAvailableBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker CheckEndDate;
        private System.Windows.Forms.DateTimePicker CheckStartDate;
        private System.Windows.Forms.Button ReserveBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CheckUSSN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CheckRoomNO;
    }
}