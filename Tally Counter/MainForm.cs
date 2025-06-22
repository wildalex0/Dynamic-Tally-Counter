using System.IO;
using System.Windows.Forms;
using DarkModeForms;

namespace Tally_Counter
{
    public partial class MainForm : Form
    {
        private DarkModeCS dm = null;
        internal List<Tally> tallyList = new List<Tally>();
        public MainForm()
        {
            InitializeComponent();
            dm = new DarkModeCS(this)
            {
                //[Optional] Choose your preferred color mode here:
                ColorMode = DarkModeCS.DisplayMode.SystemDefault
            };
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
            
        }
  
        private void saveDataButton_Click(object sended, EventArgs e)
        {

        }
        private void addToolButton_Click(object sender, EventArgs e)
        {
            using(var tallyForm = new CreateTally())
            {
                if(tallyForm.ShowDialog() == DialogResult.OK)
                {
                    string title = tallyForm.TallyName;
                    int count = tallyForm.TallyCount;
                    string path = tallyForm.TallyPath;
                    string fileName = tallyForm.Filename;
                    string fileExtension = tallyForm.FileExtension;
                    int index = tallyList.Count;
                    Tally newTally = new Tally(title, count, path, fileName, fileExtension,index, false);
                    CreateTallyControl(newTally);
                    tallyList.Add(newTally);
                }
            }
    
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
            for(int i = 0; i < tallyList.Count; i++)
            {
                tallyList[i].index = i;
            }
        }

    }

}

