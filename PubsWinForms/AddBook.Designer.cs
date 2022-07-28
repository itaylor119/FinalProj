
namespace PubsWinForms
{
    partial class addABook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addABook));
            this.publishLabel = new System.Windows.Forms.Label();
            this.publishComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.pubDate = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.salesBox = new System.Windows.Forms.TextBox();
            this.salesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // publishLabel
            // 
            this.publishLabel.AutoSize = true;
            this.publishLabel.Location = new System.Drawing.Point(45, 19);
            this.publishLabel.Name = "publishLabel";
            this.publishLabel.Size = new System.Drawing.Size(84, 25);
            this.publishLabel.TabIndex = 0;
            this.publishLabel.Text = "Publisher";
            this.publishLabel.Click += new System.EventHandler(this.publishLabel_Click);
            // 
            // publishComboBox
            // 
            this.publishComboBox.FormattingEnabled = true;
            this.publishComboBox.Location = new System.Drawing.Point(12, 56);
            this.publishComboBox.Name = "publishComboBox";
            this.publishComboBox.Size = new System.Drawing.Size(152, 33);
            this.publishComboBox.TabIndex = 1;
            this.publishComboBox.SelectedIndexChanged += new System.EventHandler(this.publishComboBox_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(261, 19);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(49, 25);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(212, 56);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(150, 31);
            this.costBox.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 404);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 34);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(250, 404);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 34);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(212, 137);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(150, 31);
            this.titleBox.TabIndex = 9;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(261, 96);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(44, 25);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Title";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(212, 219);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(150, 31);
            this.idBox.TabIndex = 11;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(261, 180);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 25);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "ID";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // pubDate
            // 
            this.pubDate.Location = new System.Drawing.Point(14, 317);
            this.pubDate.Name = "pubDate";
            this.pubDate.Size = new System.Drawing.Size(348, 31);
            this.pubDate.TabIndex = 12;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(30, 274);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(111, 25);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Publish Date";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(14, 137);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(150, 31);
            this.typeBox.TabIndex = 15;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(63, 98);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(49, 25);
            this.typeLabel.TabIndex = 14;
            this.typeLabel.Text = "Type";
            // 
            // salesBox
            // 
            this.salesBox.Location = new System.Drawing.Point(14, 220);
            this.salesBox.Name = "salesBox";
            this.salesBox.Size = new System.Drawing.Size(150, 31);
            this.salesBox.TabIndex = 17;
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Location = new System.Drawing.Point(63, 181);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(52, 25);
            this.salesLabel.TabIndex = 16;
            this.salesLabel.Text = "Sales";
            // 
            // addABook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 461);
            this.Controls.Add(this.salesBox);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.pubDate);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.publishComboBox);
            this.Controls.Add(this.publishLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addABook";
            this.Text = "Add a Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label publishLabel;
        private System.Windows.Forms.ComboBox publishComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DateTimePicker pubDate;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox salesBox;
        private System.Windows.Forms.Label salesLabel;
    }
}