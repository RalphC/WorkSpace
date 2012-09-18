namespace XMLReaderWinForm
{
    partial class XMLReaderMainForm
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
            this.XMLTreeView = new System.Windows.Forms.TreeView();
            this.XMLTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.XMLMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.XMLMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // XMLTreeView
            // 
            this.XMLTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XMLTreeView.Location = new System.Drawing.Point(0, 0);
            this.XMLTreeView.Name = "XMLTreeView";
            this.XMLTreeView.Size = new System.Drawing.Size(607, 199);
            this.XMLTreeView.TabIndex = 0;
            this.XMLTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.XMLTreeView_AfterSelect);
            // 
            // XMLTextBox
            // 
            this.XMLTextBox.AllowDrop = true;
            this.XMLTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XMLTextBox.Location = new System.Drawing.Point(0, 0);
            this.XMLTextBox.Multiline = true;
            this.XMLTextBox.Name = "XMLTextBox";
            this.XMLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.XMLTextBox.Size = new System.Drawing.Size(607, 123);
            this.XMLTextBox.TabIndex = 1;
            this.XMLTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.XMLTextBox_DragDrop);
            this.XMLTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.XMLTextBox_DragEnter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.XMLTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.XMLTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(607, 326);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 2;
            // 
            // XMLMenuStrip
            // 
            this.XMLMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.XMLMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.XMLMenuStrip.Name = "XMLMenuStrip";
            this.XMLMenuStrip.Size = new System.Drawing.Size(607, 25);
            this.XMLMenuStrip.TabIndex = 3;
            this.XMLMenuStrip.Text = "XMLMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // XMLReaderMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 365);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.XMLMenuStrip);
            this.MainMenuStrip = this.XMLMenuStrip;
            this.Name = "XMLReaderMainForm";
            this.Text = "XMLReader";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.XMLMenuStrip.ResumeLayout(false);
            this.XMLMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView XMLTreeView;
        private System.Windows.Forms.TextBox XMLTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip XMLMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

