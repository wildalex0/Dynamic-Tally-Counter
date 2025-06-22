using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkModeForms;

namespace Tally_Counter
{
    public partial class TallyControl : UserControl
    {

        public Tally tallyObj { get; set; }
        public TallyControl(Tally tallyInp)
        {
            InitializeComponent();
            this.tallyObj = tallyInp;
            updateValues();
        }

        public void updateValues()
        {
            tallyTitle.Text = tallyObj.Title;
            updateTallyCountText(tallyObj.Count.ToString());
            tallyPathLabel.Text = tallyObj.SavePath;
        }

        public void updateTallyCountText(string newText)
        {
            tallyCount.Text = newText;

            // Measure string width based on current font
            using (Graphics g = CreateGraphics())
            {
                SizeF textSize = g.MeasureString(newText, tallyCount.Font);

                tallyCount.Width = (int)Math.Ceiling(textSize.Width);
                tallyCount.Height = (int)Math.Ceiling(textSize.Height);

                // Center the label within the UserControl
                tallyCount.Left = (this.Width - tallyCount.Width) / 2;
            }
        }
        public void ApplyScale(int targetWidth)
        {
            // Reference width you designed for (matches your `Size = new Size(210, 439);`)
            const int baseWidth = 210;
            float scale = (float)targetWidth / baseWidth;

            // Scale control size
            this.Width = targetWidth;
            this.Height = (int)(this.Height * scale); // optional — keep fixed if vertical stacking is desired

            // Scale fonts
            tallyTitle.Font = ScaleFont(tallyTitle.Font, scale);
            tallyCount.Font = ScaleFont(tallyCount.Font, scale);
            tallyPathLabel.Font = ScaleFont(tallyPathLabel.Font, scale);
            subOneButton.Font = ScaleFont(subOneButton.Font, scale);
            addOneButton.Font = ScaleFont(addOneButton.Font, scale);
            subThreeButton.Font = ScaleFont(subThreeButton.Font, scale);
            addThreeButton.Font = ScaleFont(addThreeButton.Font, scale);
            subFiveButton.Font = ScaleFont(subFiveButton.Font, scale);
            addFiveButton.Font = ScaleFont(addFiveButton.Font, scale);
            changeSaveButton.Font = ScaleFont(changeSaveButton.Font, scale);

            // Scale buttons and labels (position and size)
            foreach (Control ctrl in Controls)
            {
                ctrl.Location = new Point(
                    (int)(ctrl.Location.X * scale),
                    (int)(ctrl.Location.Y * scale)
                );
                ctrl.Size = new Size(
                    (int)(ctrl.Width * scale),
                    (int)(ctrl.Height * scale)
                );
            }
        }

        private Font ScaleFont(Font original, float scale)
        {
            float newSize = original.Size * scale;
            return new Font(original.FontFamily, newSize, original.Style);
        }

        private void subOneButton_Click(object sender, EventArgs e)
        {
            tallyObj.decrementTally(1);
            updateValues();
        }

        private void addOneButton_Click(object sender, EventArgs e)
        {
            tallyObj.incrementTally(1);
            updateValues();
        }

        private void subThreeButton_Click(object sender, EventArgs e)
        {
            tallyObj.decrementTally(3);
            updateValues();

        }

        private void addThreeButton_Click(object sender, EventArgs e)
        {
            tallyObj.incrementTally(3);
            updateValues();

        }

        private void subFiveButton_Click(object sender, EventArgs e)
        {
            tallyObj.decrementTally(5);
            updateValues();

        }

        private void addFiveButton_Click(object sender, EventArgs e)
        {
            tallyObj.incrementTally(5);
            updateValues();

        }

        private void changeSaveButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    tallyObj.SavePath = folderDialog.SelectedPath;
                    //Ensures that tally creates a new file at the newly set location
                    tallyObj.saveTallyToFile();
                    updateValues();
                }
            }
        }

        public event EventHandler DeleteRequested;

        private void deleteCounterButton_Click(object sender, EventArgs e)
        {
            if (Messenger.MessageBox("Are you sure you want to delete this?\nOnce deleted it cannot be recovered..", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                tallyObj.deleteTally();
                DeleteRequested?.Invoke(this, EventArgs.Empty);
                this.Parent.Controls.Remove(this);
                this.Dispose();

            }
        }

        private void TallyControl_Load(object sender, EventArgs e)
        {

        }
    }
}
