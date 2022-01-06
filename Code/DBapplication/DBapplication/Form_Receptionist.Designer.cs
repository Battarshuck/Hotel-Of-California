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
            this.label6 = new System.Windows.Forms.Label();
            this.CheckRoomNO = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckUSSN = new System.Windows.Forms.ComboBox();
            this.ReserveBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckEndDate = new System.Windows.Forms.DateTimePicker();
            this.CheckStartDate = new System.Windows.Forms.DateTimePicker();
            this.CheckRoomAvailableBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckRoomViewCombo = new System.Windows.Forms.ComboBox();
            this.CheckRoomTypeCombo = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Location = new System.Drawing.Point(19, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(936, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check and book room";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Room Number";
            this.label6.VisibleChanged += new System.EventHandler(this.label6_VisibleChanged);
            // 
            // CheckRoomNO
            // 
            this.CheckRoomNO.FormattingEnabled = true;
            this.CheckRoomNO.Location = new System.Drawing.Point(735, 84);
            this.CheckRoomNO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckRoomNO.Name = "CheckRoomNO";
            this.CheckRoomNO.Size = new System.Drawing.Size(173, 24);
            this.CheckRoomNO.TabIndex = 12;
            this.CheckRoomNO.VisibleChanged += new System.EventHandler(this.label6_VisibleChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "User SSN";
            // 
            // CheckUSSN
            // 
            this.CheckUSSN.FormattingEnabled = true;
            this.CheckUSSN.Location = new System.Drawing.Point(735, 41);
            this.CheckUSSN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckUSSN.Name = "CheckUSSN";
            this.CheckUSSN.Size = new System.Drawing.Size(173, 24);
            this.CheckUSSN.TabIndex = 10;
            // 
            // ReserveBTN
            // 
            this.ReserveBTN.Location = new System.Drawing.Point(356, 154);
            this.ReserveBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReserveBTN.Name = "ReserveBTN";
            this.ReserveBTN.Size = new System.Drawing.Size(169, 37);
            this.ReserveBTN.TabIndex = 9;
            this.ReserveBTN.Text = "Reserve room";
            this.ReserveBTN.UseVisualStyleBackColor = true;
            this.ReserveBTN.Click += new System.EventHandler(this.ReserveBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Date";
            // 
            // CheckEndDate
            // 
            this.CheckEndDate.CustomFormat = "yyyy-MM-dd";
            this.CheckEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckEndDate.Location = new System.Drawing.Point(439, 87);
            this.CheckEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckEndDate.Name = "CheckEndDate";
            this.CheckEndDate.Size = new System.Drawing.Size(160, 22);
            this.CheckEndDate.TabIndex = 6;
            // 
            // CheckStartDate
            // 
            this.CheckStartDate.CustomFormat = "yyyy-MM-dd";
            this.CheckStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckStartDate.Location = new System.Drawing.Point(103, 87);
            this.CheckStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckStartDate.Name = "CheckStartDate";
            this.CheckStartDate.Size = new System.Drawing.Size(160, 22);
            this.CheckStartDate.TabIndex = 5;
            // 
            // CheckRoomAvailableBTN
            // 
            this.CheckRoomAvailableBTN.Location = new System.Drawing.Point(115, 154);
            this.CheckRoomAvailableBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckRoomAvailableBTN.Name = "CheckRoomAvailableBTN";
            this.CheckRoomAvailableBTN.Size = new System.Drawing.Size(169, 37);
            this.CheckRoomAvailableBTN.TabIndex = 4;
            this.CheckRoomAvailableBTN.Text = "Check availablity";
            this.CheckRoomAvailableBTN.UseVisualStyleBackColor = true;
            this.CheckRoomAvailableBTN.Click += new System.EventHandler(this.CheckRoomAvailableBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room view";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room type";
            // 
            // CheckRoomViewCombo
            // 
            this.CheckRoomViewCombo.FormattingEnabled = true;
            this.CheckRoomViewCombo.Location = new System.Drawing.Point(439, 41);
            this.CheckRoomViewCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckRoomViewCombo.Name = "CheckRoomViewCombo";
            this.CheckRoomViewCombo.Size = new System.Drawing.Size(160, 24);
            this.CheckRoomViewCombo.TabIndex = 1;
            // 
            // CheckRoomTypeCombo
            // 
            this.CheckRoomTypeCombo.FormattingEnabled = true;
            this.CheckRoomTypeCombo.Location = new System.Drawing.Point(103, 41);
            this.CheckRoomTypeCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckRoomTypeCombo.Name = "CheckRoomTypeCombo";
            this.CheckRoomTypeCombo.Size = new System.Drawing.Size(160, 24);
            this.CheckRoomTypeCombo.TabIndex = 0;
            // 
            // Form_Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 748);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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