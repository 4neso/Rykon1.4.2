namespace RykonServer.Forms
{
    partial class FormIps
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelcopyip = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabelcopyip);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 169);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(52, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(249, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(255, 38);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(44, 13);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Refresh";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GetIp_LinkClicked);
            // 
            // linkLabelcopyip
            // 
            this.linkLabelcopyip.AutoSize = true;
            this.linkLabelcopyip.Location = new System.Drawing.Point(217, 38);
            this.linkLabelcopyip.Name = "linkLabelcopyip";
            this.linkLabelcopyip.Size = new System.Drawing.Size(31, 13);
            this.linkLabelcopyip.TabIndex = 1;
            this.linkLabelcopyip.TabStop = true;
            this.linkLabelcopyip.Text = "Copy";
            this.linkLabelcopyip.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelcopyip_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Global";
            // 
            // FormIps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 176);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormIps";
            this.Text = "Ips";
            this.Load += new System.EventHandler(this.FormIps_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabelcopyip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}