namespace UI
{
    partial class BrowserUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserUserControl));
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripForwardButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripReloadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripHomeButton = new System.Windows.Forms.ToolStripButton();
            this.addressBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSearchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripBookmarkButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripBackButton
            // 
            this.toolStripBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBackButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBackButton.Image")));
            this.toolStripBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackButton.Name = "toolStripBackButton";
            this.toolStripBackButton.Size = new System.Drawing.Size(46, 44);
            this.toolStripBackButton.Text = "Back";
            this.toolStripBackButton.Click += new System.EventHandler(this.ToolStripBackButton_Click);
            // 
            // toolStripForwardButton
            // 
            this.toolStripForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripForwardButton.Image")));
            this.toolStripForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripForwardButton.Name = "toolStripForwardButton";
            this.toolStripForwardButton.Size = new System.Drawing.Size(46, 44);
            this.toolStripForwardButton.Text = "Forward";
            this.toolStripForwardButton.ToolTipText = "Forward";
            this.toolStripForwardButton.Click += new System.EventHandler(this.ToolStripForwardButton_Click);
            // 
            // toolStripReloadButton
            // 
            this.toolStripReloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReloadButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReloadButton.Image")));
            this.toolStripReloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReloadButton.Name = "toolStripReloadButton";
            this.toolStripReloadButton.Size = new System.Drawing.Size(46, 44);
            this.toolStripReloadButton.Text = "Refresh";
            this.toolStripReloadButton.Click += new System.EventHandler(this.ToolStripReloadButton_Click);
            // 
            // toolStripHomeButton
            // 
            this.toolStripHomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHomeButton.Image")));
            this.toolStripHomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHomeButton.Name = "toolStripHomeButton";
            this.toolStripHomeButton.Size = new System.Drawing.Size(46, 44);
            this.toolStripHomeButton.Text = "Home";
            this.toolStripHomeButton.Click += new System.EventHandler(this.ToolStripHomeButton_Click);
            // 
            // addressBox
            // 
            this.addressBox.AutoSize = false;
            this.addressBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressBox.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(800, 50);
            this.addressBox.Text = "enter web address";
            this.addressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressBox_KeyDown);
            this.addressBox.Click += new System.EventHandler(this.AddressBox_Click);
            // 
            // toolStripSearchButton
            // 
            this.toolStripSearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSearchButton.Image")));
            this.toolStripSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSearchButton.Name = "toolStripSearchButton";
            this.toolStripSearchButton.Size = new System.Drawing.Size(46, 44);
            this.toolStripSearchButton.Text = "Go";
            this.toolStripSearchButton.Click += new System.EventHandler(this.ToolStripButtonSearch_Click);
            // 
            // toolStripBookmarkButton
            // 
            this.toolStripBookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBookmarkButton.Image")));
            this.toolStripBookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBookmarkButton.Name = "toolStripBookmarkButton";
            this.toolStripBookmarkButton.Size = new System.Drawing.Size(46, 44);
            this.toolStripBookmarkButton.Text = "Bookmark";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton,
            this.toolStripForwardButton,
            this.toolStripReloadButton,
            this.toolStripHomeButton,
            this.addressBox,
            this.toolStripSearchButton,
            this.toolStripBookmarkButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1540, 50);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1540, 572);
            this.webBrowser1.TabIndex = 3;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 50);
            this.webBrowser.MinimumSize = new System.Drawing.Size(1500, 1000);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1540, 1000);
            this.webBrowser.TabIndex = 4;
            // 
            // BrowserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BrowserUserControl";
            this.Size = new System.Drawing.Size(1540, 622);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
        private System.Windows.Forms.ToolStripButton toolStripForwardButton;
        private System.Windows.Forms.ToolStripButton toolStripReloadButton;
        private System.Windows.Forms.ToolStripButton toolStripHomeButton;
        private System.Windows.Forms.ToolStripTextBox addressBox;
        private System.Windows.Forms.ToolStripButton toolStripSearchButton;
        private System.Windows.Forms.ToolStripButton toolStripBookmarkButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}
