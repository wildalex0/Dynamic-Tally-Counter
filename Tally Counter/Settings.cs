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
    public partial class Settings : Form
    {
        private DarkModeCS dm = null;
        public string DataPath => filePathInput.Text;
        public string Filename => filenameInput.Text;
        public Settings(String currentFilename, String currentFilePath)
        {
            InitializeComponent();
            dm = new DarkModeCS(this)
            {
                //[Optional] Choose your preferred color mode here:
                ColorMode = DarkModeCS.DisplayMode.SystemDefault
            };
            filePathInput.Text = currentFilePath;
            filenameInput.Text = currentFilename;
        }
        public event EventHandler SettingsChanged;

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");

                string[] lines = new string[]
                {
                String.Format("dataSavePath={0}", DataPath ),
                String.Format("dataFileName={0}", Filename)
                };

                File.WriteAllLines(configPath, lines);
                //Tells the main page that the settings have been changed.
                SettingsChanged?.Invoke(this, EventArgs.Empty);
                Messenger.MessageBox("Data Saved Successfully", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.Close();
            }


        }
        private bool validateInput()
        {
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
            if (!filenameInput.Text.EndsWith(".json"))
            {
                Messenger.MessageBox("Filename must end with JSON.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                filenameInput.Focus();
                return false;
            }
            return true;
        }

        private void dismissChanges_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
