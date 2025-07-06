using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using DarkModeForms;

namespace Tally_Counter
{
    public partial class MainForm : Form
    {
        private DarkModeCS dm = null;
        internal List<Tally> tallyList = new List<Tally>();
        string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");
        public string dataSavePath = string.Empty;
        string dataFileName = null;
        string latestSavedData = string.Empty;
        public MainForm()
        {
            InitializeComponent();
            dm = new DarkModeCS(this)
            {
                //[Optional] Choose your preferred color mode here:
                ColorMode = DarkModeCS.DisplayMode.SystemDefault
            };
            updateConfig();
            loadData(true);
        }
        private void CreateTallyControl(Tally tallyObj)
        {
            using Graphics g = this.CreateGraphics();
            float dpiScale = g.DpiX / 96f;
            int scaledWidth = (int)(210 * dpiScale);
            TallyControl tally = new TallyControl(tallyObj);
            tally.ApplyScale(scaledWidth);
            mainLayoutPanel.Controls.Add(tally);
        }

        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void clearScreen(bool silent = false)
        {
            tallyList.Clear();
            mainLayoutPanel.Controls.Clear();
            if (!silent)
            {
                Messenger.MessageBox("Data Cleared Successfully", "Data Clearing Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        private void updateConfig()
        {

            if (File.Exists(configPath))
            {
                var configLines = File.ReadAllLines(configPath);


                foreach (var line in configLines)
                {
                    if (line.StartsWith("dataSavePath="))
                    {
                        dataSavePath = line.Substring("dataSavePath=".Length).Trim();
                    }
                    else if (line.StartsWith("dataFileName="))
                    {
                        dataFileName = line.Substring("dataFileName=".Length).Trim();
                    }
                }

            }
            else
            {
                dataSavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dataFileName = "savedData.json";
            }
        }
        private void loadData(bool silent = false)
        {
            try
            {
                string directoryPath = dataSavePath;
                string filePath = Path.Combine(directoryPath, dataFileName);
                if (File.Exists(filePath))
                {
                    clearScreen(true);
                    string jsonString = File.ReadAllText(filePath);
                    var deserializedList = JsonSerializer.Deserialize<List<Tally>>(jsonString);
                    if (deserializedList != null)
                    {
                        tallyList = deserializedList;
                    }
                    foreach (Tally tally in tallyList)
                    {
                        tally.BasePath = dataSavePath;
                        CreateTallyControl(tally);
                    }

                    if (!silent)
                    {
                        Messenger.MessageBox("Data Loaded Successfully", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                else
                {
                    if (!silent)
                    {
                        Messenger.MessageBox("No Data Found", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                Messenger.MessageBox(string.Format("Something went wrong! {ex.message}", ex.Message), "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string getJsonString()
        {
            String jsonString = JsonSerializer.Serialize(tallyList);
            jsonString = System.Text.Json.Nodes.JsonNode.Parse(jsonString).ToString();
            return jsonString;
        }
        private void saveData()
        {
            try
            {
                String jsonString = getJsonString();
                latestSavedData = jsonString;
                string directoryPath = Path.GetFullPath(dataSavePath);
                string filePath = Path.Combine(directoryPath, dataFileName);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                File.WriteAllText(filePath, jsonString);
                Messenger.MessageBox("Data Saved Successfully", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                Messenger.MessageBox(string.Format("Something went wrong! {ex.message}", ex.Message), "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveDataButton_Click(object sended, EventArgs e)
        {
            saveData();

        }
        private void addToolButton_Click(object sender, EventArgs e)
        {
            using (var tallyForm = new CreateTally())
            {
                if (tallyForm.ShowDialog() == DialogResult.OK)
                {
                    string title = tallyForm.TallyName;
                    int count = tallyForm.TallyCount;
                    string fileName = tallyForm.Filename;
                    string fileExtension = tallyForm.FileExtension;
                    int index = tallyList.Count;
                    string subfolder = ""; 

                    var newTally = new Tally(title, count, dataSavePath, subfolder, fileName, fileExtension, index, false);
                    tallyList.Add(newTally);
                    CreateTallyControl(newTally);

                }
            }

        }
        private void Settings_SettingsChanged(object sender, EventArgs e)
        {
            updateConfig();
        }
        private void TallyControl_DeleteRequested(object sender, EventArgs e)
        {
            try
            {
                var control = sender as TallyControl;
                if (control != null)
                {
                    tallyList.RemoveAt(control.tallyObj.Index);
                    ReindexTallies();
                }
            }
            catch (Exception ex)
            {
                Messenger.MessageBox(string.Format("Something went wrong! {ex.message}", ex.Message), "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReindexTallies()
        {
            for (int i = 0; i < tallyList.Count; i++)
            {
                tallyList[i].Index = i;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!String.Equals(getJsonString(), latestSavedData))
            {
                if (Messenger.MessageBox("Are you sure you want to close?\nUnsaved data will be lost.", "Unsaved Data Popup", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        private void settingsToolButton_Click(object sender, EventArgs e)
        {
            using (var Settings = new Settings(dataFileName, dataSavePath))
            {
                Settings.SettingsChanged += Settings_SettingsChanged;
                Settings.ShowDialog();
            }
        }

        private void clearScreenToolButton_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void infoToolButton_Click(object sender, EventArgs e)
        {
            Messenger.MessageBox("This program has been made by @wildalex0 on github.\n\nDate Created: 22/06/2025", "General Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}

