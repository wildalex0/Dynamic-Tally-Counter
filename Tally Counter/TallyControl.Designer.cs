namespace Tally_Counter
{
    partial class TallyControl
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
            subOneButton = new Button();
            addOneButton = new Button();
            subThreeButton = new Button();
            addThreeButton = new Button();
            subFiveButton = new Button();
            addFiveButton = new Button();
            changeSaveButton = new Button();
            tallyTitle = new Label();
            tallyCount = new Label();
            deleteCounterButton = new Button();
            tallyPathLabel = new TextBox();
            SuspendLayout();
            // 
            // subOneButton
            // 
            subOneButton.BackColor = SystemColors.ScrollBar;
            subOneButton.FlatStyle = FlatStyle.Flat;
            subOneButton.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            subOneButton.Location = new Point(3, 150);
            subOneButton.Name = "subOneButton";
            subOneButton.Size = new Size(98, 79);
            subOneButton.TabIndex = 0;
            subOneButton.Text = "- 1";
            subOneButton.UseVisualStyleBackColor = false;
            subOneButton.Click += subOneButton_Click;
            // 
            // addOneButton
            // 
            addOneButton.BackColor = SystemColors.ScrollBar;
            addOneButton.FlatStyle = FlatStyle.Flat;
            addOneButton.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            addOneButton.Location = new Point(111, 150);
            addOneButton.Name = "addOneButton";
            addOneButton.Size = new Size(98, 79);
            addOneButton.TabIndex = 1;
            addOneButton.Text = "+ 1";
            addOneButton.UseVisualStyleBackColor = false;
            addOneButton.Click += addOneButton_Click;
            // 
            // subThreeButton
            // 
            subThreeButton.BackColor = SystemColors.ScrollBar;
            subThreeButton.FlatStyle = FlatStyle.Flat;
            subThreeButton.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            subThreeButton.Location = new Point(3, 235);
            subThreeButton.Name = "subThreeButton";
            subThreeButton.Size = new Size(98, 39);
            subThreeButton.TabIndex = 2;
            subThreeButton.Text = "- 3";
            subThreeButton.UseVisualStyleBackColor = false;
            subThreeButton.Click += subThreeButton_Click;
            // 
            // addThreeButton
            // 
            addThreeButton.BackColor = SystemColors.ScrollBar;
            addThreeButton.FlatStyle = FlatStyle.Flat;
            addThreeButton.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            addThreeButton.Location = new Point(111, 235);
            addThreeButton.Name = "addThreeButton";
            addThreeButton.Size = new Size(98, 39);
            addThreeButton.TabIndex = 3;
            addThreeButton.Text = "+ 3";
            addThreeButton.UseVisualStyleBackColor = false;
            addThreeButton.Click += addThreeButton_Click;
            // 
            // subFiveButton
            // 
            subFiveButton.BackColor = SystemColors.ScrollBar;
            subFiveButton.FlatStyle = FlatStyle.Flat;
            subFiveButton.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            subFiveButton.Location = new Point(3, 280);
            subFiveButton.Name = "subFiveButton";
            subFiveButton.Size = new Size(98, 39);
            subFiveButton.TabIndex = 4;
            subFiveButton.Text = "- 5";
            subFiveButton.UseVisualStyleBackColor = false;
            subFiveButton.Click += subFiveButton_Click;
            // 
            // addFiveButton
            // 
            addFiveButton.BackColor = SystemColors.ScrollBar;
            addFiveButton.FlatStyle = FlatStyle.Flat;
            addFiveButton.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            addFiveButton.Location = new Point(111, 280);
            addFiveButton.Name = "addFiveButton";
            addFiveButton.Size = new Size(98, 39);
            addFiveButton.TabIndex = 5;
            addFiveButton.Text = "+ 5";
            addFiveButton.UseVisualStyleBackColor = false;
            addFiveButton.Click += addFiveButton_Click;
            // 
            // changeSaveButton
            // 
            changeSaveButton.BackColor = SystemColors.ScrollBar;
            changeSaveButton.FlatStyle = FlatStyle.Flat;
            changeSaveButton.Location = new Point(3, 383);
            changeSaveButton.Name = "changeSaveButton";
            changeSaveButton.Size = new Size(206, 39);
            changeSaveButton.TabIndex = 6;
            changeSaveButton.Text = "Change Save Path";
            changeSaveButton.UseVisualStyleBackColor = false;
            changeSaveButton.Click += changeSaveButton_Click;
            // 
            // tallyTitle
            // 
            tallyTitle.Anchor = AnchorStyles.Top;
            tallyTitle.Font = new Font("Segoe UI", 13F);
            tallyTitle.Location = new Point(68, -1);
            tallyTitle.Name = "tallyTitle";
            tallyTitle.Size = new Size(76, 25);
            tallyTitle.TabIndex = 8;
            tallyTitle.Text = "tallyTitle";
            tallyTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tallyCount
            // 
            tallyCount.AutoSize = true;
            tallyCount.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            tallyCount.Location = new Point(87, 59);
            tallyCount.Name = "tallyCount";
            tallyCount.Size = new Size(40, 46);
            tallyCount.TabIndex = 9;
            tallyCount.Text = "0";
            tallyCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteCounterButton
            // 
            deleteCounterButton.BackColor = SystemColors.ScrollBar;
            deleteCounterButton.FlatStyle = FlatStyle.Flat;
            deleteCounterButton.Location = new Point(3, 428);
            deleteCounterButton.Name = "deleteCounterButton";
            deleteCounterButton.Size = new Size(206, 39);
            deleteCounterButton.TabIndex = 10;
            deleteCounterButton.Text = "Delete Counter";
            deleteCounterButton.UseVisualStyleBackColor = false;
            deleteCounterButton.Click += deleteCounterButton_Click;
            // 
            // tallyPathLabel
            // 
            tallyPathLabel.Location = new Point(3, 354);
            tallyPathLabel.Name = "tallyPathLabel";
            tallyPathLabel.PlaceholderText = "filePath";
            tallyPathLabel.ReadOnly = true;
            tallyPathLabel.Size = new Size(206, 23);
            tallyPathLabel.TabIndex = 11;
            // 
            // TallyControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tallyPathLabel);
            Controls.Add(deleteCounterButton);
            Controls.Add(tallyCount);
            Controls.Add(tallyTitle);
            Controls.Add(changeSaveButton);
            Controls.Add(addFiveButton);
            Controls.Add(subFiveButton);
            Controls.Add(addThreeButton);
            Controls.Add(subThreeButton);
            Controls.Add(addOneButton);
            Controls.Add(subOneButton);
            Margin = new Padding(10, 25, 10, 10);
            Name = "TallyControl";
            Size = new Size(214, 477);
            Load += TallyControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button subOneButton;
        private Button addOneButton;
        private Button subThreeButton;
        private Button addThreeButton;
        private Button subFiveButton;
        private Button addFiveButton;
        private Button changeSaveButton;
        private Label tallyTitle;
        private Label tallyCount;
        private Button deleteCounterButton;
        private TextBox tallyPathLabel;
    }
}
