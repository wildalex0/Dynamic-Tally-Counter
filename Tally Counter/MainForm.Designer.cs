﻿namespace Tally_Counter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainLayoutPanel = new FlowLayoutPanel();
            toolStrip1 = new ToolStrip();
            loadToolButton = new ToolStripButton();
            addToolButton = new ToolStripButton();
            saveDataButton = new ToolStripButton();
            clearScreenToolButton = new ToolStripButton();
            settingsToolButton = new ToolStripButton();
            infoToolButton = new ToolStripButton();
            folderBrowserDialog1 = new FolderBrowserDialog();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            mainLayoutPanel.AutoScroll = true;
            mainLayoutPanel.Dock = DockStyle.Fill;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Margin = new Padding(0);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.Size = new Size(1376, 810);
            mainLayoutPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { loadToolButton, addToolButton, saveDataButton, clearScreenToolButton, settingsToolButton, infoToolButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(1376, 25);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "mainToolstrip";
            // 
            // loadToolButton
            // 
            loadToolButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            loadToolButton.Image = (Image)resources.GetObject("loadToolButton.Image");
            loadToolButton.ImageTransparentColor = Color.Magenta;
            loadToolButton.Name = "loadToolButton";
            loadToolButton.Size = new Size(64, 22);
            loadToolButton.Text = "Load Data";
            loadToolButton.Click += loadDataBtn_Click;
            // 
            // addToolButton
            // 
            addToolButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            addToolButton.Image = (Image)resources.GetObject("addToolButton.Image");
            addToolButton.ImageTransparentColor = Color.Magenta;
            addToolButton.Name = "addToolButton";
            addToolButton.Size = new Size(60, 22);
            addToolButton.Text = "Add Data";
            addToolButton.Click += addToolButton_Click;
            // 
            // saveDataButton
            // 
            saveDataButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveDataButton.Image = (Image)resources.GetObject("saveDataButton.Image");
            saveDataButton.ImageTransparentColor = Color.Magenta;
            saveDataButton.Name = "saveDataButton";
            saveDataButton.Size = new Size(62, 22);
            saveDataButton.Text = "Save Data";
            saveDataButton.Click += saveDataButton_Click;
            // 
            // clearScreenToolButton
            // 
            clearScreenToolButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            clearScreenToolButton.Image = (Image)resources.GetObject("clearScreenToolButton.Image");
            clearScreenToolButton.ImageTransparentColor = Color.Magenta;
            clearScreenToolButton.Name = "clearScreenToolButton";
            clearScreenToolButton.Size = new Size(76, 22);
            clearScreenToolButton.Text = "Clear Screen";
            clearScreenToolButton.Click += clearScreenToolButton_Click;
            // 
            // settingsToolButton
            // 
            settingsToolButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            settingsToolButton.Image = (Image)resources.GetObject("settingsToolButton.Image");
            settingsToolButton.ImageTransparentColor = Color.Magenta;
            settingsToolButton.Name = "settingsToolButton";
            settingsToolButton.Size = new Size(53, 22);
            settingsToolButton.Text = "Settings";
            settingsToolButton.Click += settingsToolButton_Click;
            // 
            // infoToolButton
            // 
            infoToolButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            infoToolButton.Image = (Image)resources.GetObject("infoToolButton.Image");
            infoToolButton.ImageTransparentColor = Color.Magenta;
            infoToolButton.Name = "infoToolButton";
            infoToolButton.Size = new Size(32, 22);
            infoToolButton.Text = "Info";
            infoToolButton.Click += infoToolButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 810);
            Controls.Add(toolStrip1);
            Controls.Add(mainLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Counter";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel mainLayoutPanel;
        private ToolStrip toolStrip1;
        private ToolStripButton loadToolButton;
        private ToolStripButton addToolButton;
        private ToolStripButton settingsToolButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolStripButton saveDataButton;
        private ToolStripButton clearScreenToolButton;
        private ToolStripButton infoToolButton;
    }
}
