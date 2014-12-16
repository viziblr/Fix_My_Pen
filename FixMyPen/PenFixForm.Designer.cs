namespace PenFix
{
    partial class PenFixForm
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
            this.buttonrefresh = new System.Windows.Forms.Button();
            this.buttonset = new System.Windows.Forms.Button();
            this.buttonenable = new System.Windows.Forms.Button();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonrefresh
            // 
            this.buttonrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonrefresh.Location = new System.Drawing.Point(12, 235);
            this.buttonrefresh.Name = "buttonrefresh";
            this.buttonrefresh.Size = new System.Drawing.Size(75, 56);
            this.buttonrefresh.TabIndex = 3;
            this.buttonrefresh.Text = "Refresh status";
            this.buttonrefresh.UseVisualStyleBackColor = true;
            this.buttonrefresh.Click += new System.EventHandler(this.buttonrefresh_Click);
            // 
            // buttonset
            // 
            this.buttonset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonset.Location = new System.Drawing.Point(316, 228);
            this.buttonset.Name = "buttonset";
            this.buttonset.Size = new System.Drawing.Size(75, 62);
            this.buttonset.TabIndex = 4;
            this.buttonset.Text = "Make everything bad";
            this.buttonset.UseVisualStyleBackColor = true;
            this.buttonset.Click += new System.EventHandler(this.button_make_bad);
            // 
            // buttonenable
            // 
            this.buttonenable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonenable.Location = new System.Drawing.Point(397, 228);
            this.buttonenable.Name = "buttonenable";
            this.buttonenable.Size = new System.Drawing.Size(75, 62);
            this.buttonenable.TabIndex = 6;
            this.buttonenable.Text = "Make everything good";
            this.buttonenable.UseVisualStyleBackColor = true;
            this.buttonenable.Click += new System.EventHandler(this.button_make_good);
            // 
            // textBox_status
            // 
            this.textBox_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_status.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_status.Location = new System.Drawing.Point(15, 25);
            this.textBox_status.Multiline = true;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.ReadOnly = true;
            this.textBox_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_status.Size = new System.Drawing.Size(457, 197);
            this.textBox_status.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Status";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(441, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(27, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 303);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.buttonenable);
            this.Controls.Add(this.buttonset);
            this.Controls.Add(this.buttonrefresh);
            this.Name = "PenFixForm";
            this.Text = "Fix My Pen!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonrefresh;
        private System.Windows.Forms.Button buttonset;
        private System.Windows.Forms.Button buttonenable;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

