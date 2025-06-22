namespace Tally_Counter
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            saveChangesButton = new Button();
            label4 = new Label();
            filenameInput = new TextBox();
            selectFolderButton = new Button();
            filePathInput = new TextBox();
            label3 = new Label();
            dismissChanges = new Button();
            SuspendLayout();
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(38, 395);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(166, 23);
            saveChangesButton.TabIndex = 23;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 106);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 20;
            label4.Text = "Data Filename";
            // 
            // filenameInput
            // 
            filenameInput.Location = new Point(6, 124);
            filenameInput.Name = "filenameInput";
            filenameInput.Size = new Size(226, 23);
            filenameInput.TabIndex = 19;
            // 
            // selectFolderButton
            // 
            selectFolderButton.Location = new Point(38, 56);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(166, 23);
            selectFolderButton.TabIndex = 18;
            selectFolderButton.Text = "Select Folder";
            selectFolderButton.UseVisualStyleBackColor = true;
            selectFolderButton.Click += selectFolderButton_Click;
            // 
            // filePathInput
            // 
            filePathInput.Location = new Point(6, 27);
            filePathInput.Name = "filePathInput";
            filePathInput.ReadOnly = true;
            filePathInput.Size = new Size(226, 23);
            filePathInput.TabIndex = 17;
            filePathInput.Text = "No FIle Selected!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 9);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 16;
            label3.Text = "Data Save Path";
            // 
            // dismissChanges
            // 
            dismissChanges.Location = new Point(38, 357);
            dismissChanges.Name = "dismissChanges";
            dismissChanges.Size = new Size(166, 23);
            dismissChanges.TabIndex = 24;
            dismissChanges.Text = "Dismiss Changes";
            dismissChanges.UseVisualStyleBackColor = true;
            dismissChanges.Click += dismissChanges_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 450);
            Controls.Add(dismissChanges);
            Controls.Add(saveChangesButton);
            Controls.Add(label4);
            Controls.Add(filenameInput);
            Controls.Add(selectFolderButton);
            Controls.Add(filePathInput);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(268, 489);
            MinimumSize = new Size(268, 489);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveChangesButton;
        private Label label4;
        private TextBox filenameInput;
        private Button selectFolderButton;
        private TextBox filePathInput;
        private Label label3;
        private Button dismissChanges;
    }
}