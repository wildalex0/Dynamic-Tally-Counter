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
    public partial class CreateTally : Form
    {
        private DarkModeCS dm = null;
        public string TallyName => tallyTitleInput.Text;
        public int TallyCount => int.TryParse(tallyValueInput.Text, out int count) ? count : 0;
        public string TallyPath => filePathInput.Text;
        public string Filename => filenameInput.Text;
        public string FileExtension => fileExtensionCombo.Text;
        public CreateTally()
        {
            InitializeComponent();
            dm = new DarkModeCS(this)
            {
                //[Optional] Choose your preferred color mode here:
                ColorMode = DarkModeCS.DisplayMode.SystemDefault
            };
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                //folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    filePathInput.Text = folderDialog.SelectedPath;
                }
            }
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(tallyTitleInput.Text))
            {
                Messenger.MessageBox("Tally Name cannot be empty.", "Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tallyTitleInput.Focus();
                return false;
            }

            if (!int.TryParse(tallyValueInput.Text, out int count))
            {
                Messenger.MessageBox("Tally Count must be a valid number.", "Validation Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tallyValueInput.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(filePathInput.Text) || filePathInput.Text == "No file selected!")
            {
                Messenger.MessageBox("Please select a valid file path.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                filePathInput.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(filenameInput.Text))
            {
                Messenger.MessageBox("Filename cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                filenameInput.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(fileExtensionCombo.Text)) 
            {
                Messenger.MessageBox("Please select a file extension.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
