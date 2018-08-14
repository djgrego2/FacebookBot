namespace FacebookBot
{
    partial class HomePage
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
            this.OpenBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenBrowser
            // 
            this.OpenBrowser.Location = new System.Drawing.Point(269, 173);
            this.OpenBrowser.Name = "OpenBrowser";
            this.OpenBrowser.Size = new System.Drawing.Size(131, 23);
            this.OpenBrowser.TabIndex = 0;
            this.OpenBrowser.Text = "Open Browser";
            this.OpenBrowser.UseVisualStyleBackColor = true;
            this.OpenBrowser.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.OpenBrowser);
            this.Name = "HomePage";
            this.Text = "Facebook Bot";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenBrowser;
    }
}

