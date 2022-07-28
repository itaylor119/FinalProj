
namespace PubsWinForms
{
    partial class AuthorBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorBooks));
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.auBooksList = new System.Windows.Forms.ListView();
            this.allBooksList = new System.Windows.Forms.ListView();
            this.allBooksLabel = new System.Windows.Forms.Label();
            this.auBooksLabel = new System.Windows.Forms.Label();
            this.booksToAu = new System.Windows.Forms.Button();
            this.auToBooks = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 9);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(251, 25);
            this.AuthorLabel.TabIndex = 0;
            this.AuthorLabel.Text = "Author: _________________________";
            this.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AuthorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // auBooksList
            // 
            this.auBooksList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.auBooksList.BackColor = System.Drawing.SystemColors.Window;
            this.auBooksList.GridLines = true;
            this.auBooksList.HideSelection = false;
            this.auBooksList.Location = new System.Drawing.Point(33, 131);
            this.auBooksList.Name = "auBooksList";
            this.auBooksList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.auBooksList.Size = new System.Drawing.Size(468, 279);
            this.auBooksList.TabIndex = 1;
            this.auBooksList.UseCompatibleStateImageBehavior = false;
            this.auBooksList.View = System.Windows.Forms.View.Details;
            this.auBooksList.SelectedIndexChanged += new System.EventHandler(this.auBooksList_SelectedIndexChanged);
            // 
            // allBooksList
            // 
            this.allBooksList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allBooksList.HideSelection = false;
            this.allBooksList.Location = new System.Drawing.Point(590, 131);
            this.allBooksList.Name = "allBooksList";
            this.allBooksList.Size = new System.Drawing.Size(468, 279);
            this.allBooksList.TabIndex = 2;
            this.allBooksList.UseCompatibleStateImageBehavior = false;
            this.allBooksList.View = System.Windows.Forms.View.Details;
            this.allBooksList.SelectedIndexChanged += new System.EventHandler(this.allBooksList_SelectedIndexChanged);
            // 
            // allBooksLabel
            // 
            this.allBooksLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allBooksLabel.AutoSize = true;
            this.allBooksLabel.Location = new System.Drawing.Point(783, 91);
            this.allBooksLabel.Name = "allBooksLabel";
            this.allBooksLabel.Size = new System.Drawing.Size(86, 25);
            this.allBooksLabel.TabIndex = 3;
            this.allBooksLabel.Text = "All Books";
            // 
            // auBooksLabel
            // 
            this.auBooksLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.auBooksLabel.AutoSize = true;
            this.auBooksLabel.Location = new System.Drawing.Point(204, 91);
            this.auBooksLabel.Name = "auBooksLabel";
            this.auBooksLabel.Size = new System.Drawing.Size(121, 25);
            this.auBooksLabel.TabIndex = 4;
            this.auBooksLabel.Text = "Author Books";
            // 
            // booksToAu
            // 
            this.booksToAu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.booksToAu.Font = new System.Drawing.Font("Wingdings", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.booksToAu.Location = new System.Drawing.Point(520, 185);
            this.booksToAu.Name = "booksToAu";
            this.booksToAu.Size = new System.Drawing.Size(55, 55);
            this.booksToAu.TabIndex = 5;
            this.booksToAu.Text = "E";
            this.booksToAu.UseVisualStyleBackColor = true;
            this.booksToAu.Click += new System.EventHandler(this.booksToAu_Click);
            // 
            // auToBooks
            // 
            this.auToBooks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.auToBooks.Font = new System.Drawing.Font("Wingdings", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.auToBooks.Location = new System.Drawing.Point(520, 306);
            this.auToBooks.Name = "auToBooks";
            this.auToBooks.Size = new System.Drawing.Size(55, 55);
            this.auToBooks.TabIndex = 6;
            this.auToBooks.Text = "F";
            this.auToBooks.UseVisualStyleBackColor = true;
            this.auToBooks.Click += new System.EventHandler(this.auToBooks_Click);
            // 
            // addBook
            // 
            this.addBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addBook.Location = new System.Drawing.Point(742, 35);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(169, 34);
            this.addBook.TabIndex = 7;
            this.addBook.Text = "Add A Book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // AuthorBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.auToBooks);
            this.Controls.Add(this.booksToAu);
            this.Controls.Add(this.auBooksLabel);
            this.Controls.Add(this.allBooksLabel);
            this.Controls.Add(this.allBooksList);
            this.Controls.Add(this.auBooksList);
            this.Controls.Add(this.AuthorLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorBooks";
            this.Text = "AuthorBooks";
            this.Load += new System.EventHandler(this.AuthorBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.ListView auBooksList;
        private System.Windows.Forms.ListView allBooksList;
        private System.Windows.Forms.Label allBooksLabel;
        private System.Windows.Forms.Label auBooksLabel;
        private System.Windows.Forms.Button booksToAu;
        private System.Windows.Forms.Button auToBooks;
        private System.Windows.Forms.Button addBook;
    }
}