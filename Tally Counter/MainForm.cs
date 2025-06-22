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
        string dataSavePath = null;
        string dataFileName = null;

        public MainForm()
        {
            InitializeComponent();
            dm = new DarkModeCS(this)
            {
                //[Optional] Choose your preferred color mode here:
                ColorMode = DarkModeCS.DisplayMode.SystemDefault
            };
            updateConfig();
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
            string directoryPath = dataSavePath;
            string filePath = Path.Combine(directoryPath, dataFileName);
            if (File.Exists(filePath))
            {
                tallyList.Clear();
                string jsonString = File.ReadAllText(filePath);
                var deserializedList = JsonSerializer.Deserialize<List<Tally>>(jsonString);
                if (deserializedList != null)
                {
                    tallyList = deserializedList;
                }
                foreach (Tally tally in tallyList)
                {
                    CreateTallyControl(tally);
                }
                Messenger.MessageBox("Data Loaded Successfully", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                Messenger.MessageBox("No Data Found", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        private void saveDataButton_Click(object sended, EventArgs e)
        {
            try
            {
                //Until implementation of settings screen, it will use a hardcoded file.
                String jsonString = JsonSerializer.Serialize(tallyList);
                jsonString = System.Text.Json.Nodes.JsonNode.Parse(jsonString).ToString();

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
        private void addToolButton_Click(object sender, EventArgs e)
        {
            using (var tallyForm = new CreateTally())
            {
                if (tallyForm.ShowDialog() == DialogResult.OK)
                {
                    string title = tallyForm.TallyName;
                    int count = tallyForm.TallyCount;
                    string path = tallyForm.TallyPath;
                    string fileName = tallyForm.Filename;
                    string fileExtension = tallyForm.FileExtension;
                    int index = tallyList.Count;
                    Tally newTally = new Tally(title, count, path, fileName, fileExtension, index, false);
                    CreateTallyControl(newTally);
                    tallyList.Add(newTally);
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

        private void settingsToolButton_Click(object sender, EventArgs e)
        {
            using (var Settings = new Settings(dataFileName, dataSavePath)) {
                Settings.SettingsChanged += Settings_SettingsChanged;
                Settings.ShowDialog();
            }
        }
    }

}

