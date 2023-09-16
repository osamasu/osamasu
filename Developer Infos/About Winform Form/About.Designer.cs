namespace My_Calculator_V2
{
    partial class AboutForm
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
            this.LinkLB_Email = new System.Windows.Forms.LinkLabel();
            this.LinkLB_LinkedIN = new System.Windows.Forms.LinkLabel();
            this.linkLB_Github = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LinkLB_Email
            // 
            this.LinkLB_Email.AutoSize = true;
            this.LinkLB_Email.BackColor = System.Drawing.Color.Transparent;
            this.LinkLB_Email.Font = new System.Drawing.Font("Eras Bold ITC", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLB_Email.LinkColor = System.Drawing.SystemColors.Highlight;
            this.LinkLB_Email.Location = new System.Drawing.Point(72, 206);
            this.LinkLB_Email.Name = "LinkLB_Email";
            this.LinkLB_Email.Size = new System.Drawing.Size(352, 26);
            this.LinkLB_Email.TabIndex = 0;
            this.LinkLB_Email.TabStop = true;
            this.LinkLB_Email.Text = "Osamataher306@Outlook.com";
            this.LinkLB_Email.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLB_Email_LinkClicked);
            // 
            // LinkLB_LinkedIN
            // 
            this.LinkLB_LinkedIN.AutoSize = true;
            this.LinkLB_LinkedIN.BackColor = System.Drawing.Color.Transparent;
            this.LinkLB_LinkedIN.Font = new System.Drawing.Font("Eras Bold ITC", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLB_LinkedIN.LinkColor = System.Drawing.SystemColors.Highlight;
            this.LinkLB_LinkedIN.Location = new System.Drawing.Point(72, 275);
            this.LinkLB_LinkedIN.Name = "LinkLB_LinkedIN";
            this.LinkLB_LinkedIN.Size = new System.Drawing.Size(346, 26);
            this.LinkLB_LinkedIN.TabIndex = 1;
            this.LinkLB_LinkedIN.TabStop = true;
            this.LinkLB_LinkedIN.Text = "OSAMA THABIT MOHAMMED";
            this.LinkLB_LinkedIN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLB_LinkedIN_LinkClicked);
            // 
            // linkLB_Github
            // 
            this.linkLB_Github.AutoSize = true;
            this.linkLB_Github.BackColor = System.Drawing.Color.Transparent;
            this.linkLB_Github.Font = new System.Drawing.Font("Eras Bold ITC", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLB_Github.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLB_Github.Location = new System.Drawing.Point(72, 342);
            this.linkLB_Github.Name = "linkLB_Github";
            this.linkLB_Github.Size = new System.Drawing.Size(114, 26);
            this.linkLB_Github.TabIndex = 2;
            this.linkLB_Github.TabStop = true;
            this.linkLB_Github.Text = "Osamasu";
            this.linkLB_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLB_Github_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My_Calculator_V2.Properties.Resources.DESKTOP_IMAGE_MY_INFO;
            this.ClientSize = new System.Drawing.Size(791, 386);
            this.Controls.Add(this.linkLB_Github);
            this.Controls.Add(this.LinkLB_LinkedIN);
            this.Controls.Add(this.LinkLB_Email);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.Click += new System.EventHandler(this.AboutForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkLB_Email;
        private System.Windows.Forms.LinkLabel LinkLB_LinkedIN;
        private System.Windows.Forms.LinkLabel linkLB_Github;
    }
}