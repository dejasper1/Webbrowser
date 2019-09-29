namespace UI
{
    partial class BookmarkManagerForm
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
            this.bookmarkListBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bookmarkListBox1
            // 
            this.bookmarkListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarkListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookmarkListBox1.FormattingEnabled = true;
            this.bookmarkListBox1.ItemHeight = 31;
            this.bookmarkListBox1.Location = new System.Drawing.Point(0, 0);
            this.bookmarkListBox1.Name = "bookmarkListBox1";
            this.bookmarkListBox1.Size = new System.Drawing.Size(1014, 565);
            this.bookmarkListBox1.TabIndex = 0;
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 565);
            this.Controls.Add(this.bookmarkListBox1);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bookmarkListBox1;
    }
}