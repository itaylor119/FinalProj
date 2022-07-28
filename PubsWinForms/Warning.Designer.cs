
namespace PubsWinForms
{
    partial class Warning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warning));
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.warnSymbol = new System.Windows.Forms.PictureBox();
            this.warnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.warnSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(168, 152);
            this.yes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(118, 36);
            this.yes.TabIndex = 0;
            this.yes.Text = "YES";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(292, 152);
            this.no.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(118, 36);
            this.no.TabIndex = 1;
            this.no.Text = "NO";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // warnSymbol
            // 
            this.warnSymbol.Image = ((System.Drawing.Image)(resources.GetObject("warnSymbol.Image")));
            this.warnSymbol.Location = new System.Drawing.Point(30, 52);
            this.warnSymbol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.warnSymbol.Name = "warnSymbol";
            this.warnSymbol.Size = new System.Drawing.Size(41, 52);
            this.warnSymbol.TabIndex = 2;
            this.warnSymbol.TabStop = false;
            // 
            // warnLabel
            // 
            this.warnLabel.AutoSize = true;
            this.warnLabel.Location = new System.Drawing.Point(79, 52);
            this.warnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warnLabel.Name = "warnLabel";
            this.warnLabel.Size = new System.Drawing.Size(298, 50);
            this.warnLabel.TabIndex = 3;
            this.warnLabel.Text = "Are you sure you want to delete this\r\nauthor listing?";
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 192);
            this.Controls.Add(this.warnLabel);
            this.Controls.Add(this.warnSymbol);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(444, 248);
            this.MinimumSize = new System.Drawing.Size(444, 248);
            this.Name = "Warning";
            this.Text = "Warning";
            this.Load += new System.EventHandler(this.Warning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warnSymbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.PictureBox warnSymbol;
        private System.Windows.Forms.Label warnLabel;
    }
}