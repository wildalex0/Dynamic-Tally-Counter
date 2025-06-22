namespace Tally_Counter
{
    partial class CreateTally
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
            tallyTitleInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tallyValueInput = new TextBox();
            label3 = new Label();
            filePathInput = new TextBox();
            selectFolderButton = new Button();
            label4 = new Label();
            filenameInput = new TextBox();
            fileExtensionCombo = new ComboBox();
            label5 = new Label();
            saveChangesButton = new Button();
            SuspendLayout();
            // 
            // tallyTitleInput
            // 
            tallyTitleInput.Location = new Point(12, 31);
            tallyTitleInput.Name = "tallyTitleInput";
            tallyTitleInput.Size = new Size(226, 23);
            tallyTitleInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Tally Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Tally Value";
            // 
            // tallyValueInput
            // 
            tallyValueInput.Location = new Point(12, 95);
            tallyValueInput.Name = "tallyValueInput";
            tallyValueInput.Size = new Size(226, 23);
            tallyValueInput.TabIndex = 2;
            tallyValueInput.Text = "0";
            tallyValueInput.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "File Save Path";
            // 
            // filePathInput
            // 
            filePathInput.Location = new Point(12, 172);
            filePathInput.Name = "filePathInput";
            filePathInput.ReadOnly = true;
            filePathInput.Size = new Size(226, 23);
            filePathInput.TabIndex = 5;
            filePathInput.Text = "No FIle Selected!";
            // 
            // selectFolderButton
            // 
            selectFolderButton.Location = new Point(38, 218);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(166, 23);
            selectFolderButton.TabIndex = 6;
            selectFolderButton.Text = "Select Folder";
            selectFolderButton.UseVisualStyleBackColor = true;
            selectFolderButton.Click += selectFolderButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 254);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Filename";
            // 
            // filenameInput
            // 
            filenameInput.Location = new Point(12, 272);
            filenameInput.Name = "filenameInput";
            filenameInput.Size = new Size(226, 23);
            filenameInput.TabIndex = 7;
            // 
            // fileExtensionCombo
            // 
            fileExtensionCombo.FormattingEnabled = true;
            fileExtensionCombo.Items.AddRange(new object[] { ".md", ".txt" });
            fileExtensionCombo.Location = new Point(12, 331);
            fileExtensionCombo.Name = "fileExtensionCombo";
            fileExtensionCombo.Size = new Size(226, 23);
            fileExtensionCombo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 313);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 10;
            label5.Text = "File Extension";
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(38, 396);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(166, 23);
            saveChangesButton.TabIndex = 11;
            saveChangesButton.Text = "Create Tally";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // CreateTally
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 450);
            Controls.Add(saveChangesButton);
            Controls.Add(label5);
            Controls.Add(fileExtensionCombo);
            Controls.Add(label4);
            Controls.Add(filenameInput);
            Controls.Add(selectFolderButton);
            Controls.Add(filePathInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tallyValueInput);
            Controls.Add(label1);
            Controls.Add(tallyTitleInput);
            MaximumSize = new Size(266, 489);
            MinimumSize = new Size(266, 489);
            Name = "CreateTally";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateTally";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tallyTitleInput;
        private Label label1;
        private Label label2;
        private TextBox tallyValueInput;
        private Label label3;
        private TextBox filePathInput;
        private Button selectFolderButton;
        private Label label4;
        private TextBox filenameInput;
        private ComboBox fileExtensionCombo;
        private Label label5;
        private Button saveChangesButton;
    }
}