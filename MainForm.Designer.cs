namespace CrossWordCraft
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.templateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadContentToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.FilenameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter = new System.Windows.Forms.Splitter();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.Content = new CrossWordCraft.ContentControl();
            this.Template = new CrossWordCraft.TemplateControl();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templateToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.GenerateToolStripButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(796, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // templateToolStripMenuItem
            // 
            this.templateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.templateToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.templateToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.templateToolStripMenuItem.Name = "templateToolStripMenuItem";
            this.templateToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.templateToolStripMenuItem.Text = "Шаблон";
            this.templateToolStripMenuItem.ToolTipText = "Шаблон";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "Новий...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Відкрити";
            this.openToolStripMenuItem.ToolTipText = "Відкрити шаблон";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Зберегти";
            this.saveToolStripMenuItem.ToolTipText = "Зберегти шаблон";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Зберегти як...";
            this.saveAsToolStripMenuItem.ToolTipText = "Зберегти як...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.ToolTipText = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReadContentToolStripButton});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.helpToolStripMenuItem.Text = "Словник";
            // 
            // ReadContentToolStripButton
            // 
            this.ReadContentToolStripButton.Name = "ReadContentToolStripButton";
            this.ReadContentToolStripButton.Size = new System.Drawing.Size(180, 22);
            this.ReadContentToolStripButton.Text = "Задати список слів";
            this.ReadContentToolStripButton.ToolTipText = "Задати список слів";
            this.ReadContentToolStripButton.Click += new System.EventHandler(this.ReadContentToolStripButton_Click);
            // 
            // GenerateToolStripButton
            // 
            this.GenerateToolStripButton.Name = "GenerateToolStripButton";
            this.GenerateToolStripButton.Size = new System.Drawing.Size(142, 20);
            this.GenerateToolStripButton.Text = "Згенерувати кросворд";
            this.GenerateToolStripButton.Click += new System.EventHandler(this.GenerateToolStripButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilenameToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 583);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(796, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // FilenameToolStripStatusLabel
            // 
            this.FilenameToolStripStatusLabel.Name = "FilenameToolStripStatusLabel";
            this.FilenameToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(794, 24);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(2, 559);
            this.splitter.TabIndex = 4;
            this.splitter.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.Content);
            this.LeftPanel.Controls.Add(this.Template);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(0, 24);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(794, 559);
            this.LeftPanel.TabIndex = 5;
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(185, 456);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(427, 83);
            this.Content.TabIndex = 0;
            this.Content.Template = null;
            // 
            // Template
            // 
            this.Template.Location = new System.Drawing.Point(185, 0);
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(427, 429);
            this.Template.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 605);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор кроссвордов ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.ToolStripMenuItem templateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel FilenameToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReadContentToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem GenerateToolStripButton;
        private TemplateControl Template;
        private System.Windows.Forms.Panel LeftPanel;
        private ContentControl Content;
    }
}

