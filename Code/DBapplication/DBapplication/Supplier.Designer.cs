namespace DBapplication
{
    partial class Supplier
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
            this.show_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(221, 136);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(322, 86);
            this.show_btn.TabIndex = 0;
            this.show_btn.Text = "Show Database";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(221, 310);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(322, 86);
            this.edit_btn.TabIndex = 1;
            this.edit_btn.Text = "Edit Database";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 579);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.show_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Supplier";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Button edit_btn;
    }
}

