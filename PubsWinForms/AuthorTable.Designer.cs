
namespace PubsWinForms
{
    partial class Authors
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authors));
            this.lvAuthors = new System.Windows.Forms.ListView();
            this.txtTempID = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.booksView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAuthors
            // 
            this.lvAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAuthors.HideSelection = false;
            this.lvAuthors.Location = new System.Drawing.Point(15, 15);
            this.lvAuthors.Margin = new System.Windows.Forms.Padding(4);
            this.lvAuthors.Name = "lvAuthors";
            this.lvAuthors.Size = new System.Drawing.Size(793, 479);
            this.lvAuthors.TabIndex = 0;
            this.lvAuthors.UseCompatibleStateImageBehavior = false;
            this.lvAuthors.SelectedIndexChanged += new System.EventHandler(this.lvAuthors_SelectedIndexChanged);
            // 
            // txtTempID
            // 
            this.txtTempID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTempID.Location = new System.Drawing.Point(56, 504);
            this.txtTempID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempID.Name = "txtTempID";
            this.txtTempID.ReadOnly = true;
            this.txtTempID.Size = new System.Drawing.Size(128, 31);
            this.txtTempID.TabIndex = 1;
            this.txtTempID.TextChanged += new System.EventHandler(this.txtTempID_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(371, 502);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(118, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(530, 502);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(118, 36);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(691, 502);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 36);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(15, 506);
            this.IDlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(34, 25);
            this.IDlabel.TabIndex = 5;
            this.IDlabel.Text = "ID:";
            this.IDlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // booksView
            // 
            this.booksView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.booksView.Location = new System.Drawing.Point(215, 502);
            this.booksView.Margin = new System.Windows.Forms.Padding(4);
            this.booksView.Name = "booksView";
            this.booksView.Size = new System.Drawing.Size(118, 36);
            this.booksView.TabIndex = 6;
            this.booksView.Text = "Books";
            this.booksView.UseVisualStyleBackColor = true;
            this.booksView.Click += new System.EventHandler(this.booksView_Click);
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 548);
            this.Controls.Add(this.booksView);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.txtTempID);
            this.Controls.Add(this.lvAuthors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(841, 592);
            this.Name = "Authors";
            this.Text = "Authors";
            this.Load += new System.EventHandler(this.Authors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTempID;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label IDlabel;
        public System.Windows.Forms.ListView lvAuthors;
        private System.Windows.Forms.Button booksView;
    }
}

