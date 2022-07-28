
namespace PubsWinForms
{
    partial class Add_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Edit));
            this.idBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.contractBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.contractLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(15, 54);
            this.idBox.Margin = new System.Windows.Forms.Padding(4);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(155, 31);
            this.idBox.TabIndex = 0;
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(15, 136);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(4);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(155, 31);
            this.fnameBox.TabIndex = 1;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(15, 299);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(155, 31);
            this.phoneBox.TabIndex = 2;
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(15, 218);
            this.lnameBox.Margin = new System.Windows.Forms.Padding(4);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(155, 31);
            this.lnameBox.TabIndex = 3;
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(229, 218);
            this.zipBox.Margin = new System.Windows.Forms.Padding(4);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(155, 31);
            this.zipBox.TabIndex = 6;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(229, 136);
            this.cityBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(155, 31);
            this.cityBox.TabIndex = 5;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(229, 54);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(155, 31);
            this.addressBox.TabIndex = 4;
            // 
            // contractBox
            // 
            this.contractBox.Location = new System.Drawing.Point(229, 299);
            this.contractBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractBox.Name = "contractBox";
            this.contractBox.Size = new System.Drawing.Size(155, 31);
            this.contractBox.TabIndex = 8;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(441, 218);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(156, 36);
            this.save.TabIndex = 9;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(441, 298);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(156, 36);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(15, 25);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(34, 25);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "ID:";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(15, 108);
            this.fnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(98, 25);
            this.fnameLabel.TabIndex = 12;
            this.fnameLabel.Text = "First name:";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(15, 189);
            this.lnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(96, 25);
            this.lnameLabel.TabIndex = 13;
            this.lnameLabel.Text = "Last name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(16, 270);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(66, 25);
            this.phoneLabel.TabIndex = 14;
            this.phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(229, 25);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(81, 25);
            this.addressLabel.TabIndex = 15;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(229, 108);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(46, 25);
            this.cityLabel.TabIndex = 16;
            this.cityLabel.Text = "City:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(229, 189);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(41, 25);
            this.zipLabel.TabIndex = 18;
            this.zipLabel.Text = "ZIP:";
            // 
            // contractLabel
            // 
            this.contractLabel.AutoSize = true;
            this.contractLabel.Location = new System.Drawing.Point(224, 270);
            this.contractLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractLabel.Name = "contractLabel";
            this.contractLabel.Size = new System.Drawing.Size(154, 25);
            this.contractLabel.TabIndex = 19;
            this.contractLabel.Text = "Contract (Yes/No):";
            // 
            // Add_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 348);
            this.Controls.Add(this.contractLabel);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.contractBox);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.idBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Edit";
            this.Text = "temp";
            this.Load += new System.EventHandler(this.Add_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label contractLabel;
        internal System.Windows.Forms.TextBox idBox;
        internal System.Windows.Forms.TextBox fnameBox;
        internal System.Windows.Forms.TextBox phoneBox;
        internal System.Windows.Forms.TextBox lnameBox;
        internal System.Windows.Forms.TextBox zipBox;
        internal System.Windows.Forms.TextBox cityBox;
        internal System.Windows.Forms.TextBox addressBox;
        internal System.Windows.Forms.TextBox contractBox;
    }
}