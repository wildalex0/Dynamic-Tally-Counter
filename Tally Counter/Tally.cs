using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tally_Counter
{
    public class Tally
    {
        public int Count { get; set; }
        public string SavePath { get; set; }
        public int Index { get; set; }
        public string Title { get; set; }
        public string Filename { get; set; }
        public string SaveExtension { get; set; }

        public Tally() { }
        public Tally(string Title = "Null", int Count = 0, string path= "C:/", string fileName= "Test", string fileExtention= ".md", int index = 0, bool isLoading = false)
        {
            this.Title = Title;
            this.Count = Count;
            this.SavePath = path;
            this.Filename = fileName;
            this.SaveExtension = fileExtention;
            this.Index = index;
            if (!isLoading && !string.IsNullOrEmpty(SavePath))
            {
                saveTallyToFile();
            }
        }

        public void incrementTally(int val)
        {
            this.Count += (val);
            saveTallyToFile ();
        }
        public void decrementTally(int val) {
            this.Count -= (val);
            saveTallyToFile();
        }
        public void saveTallyToFile()
        {
            string fullPath = Path.Combine(this.SavePath, this.Filename+this.SaveExtension);
            if (File.Exists(fullPath))
            {
                File.WriteAllText(fullPath, this.Count.ToString());
            }
            else
            {
                File.WriteAllText(fullPath, this.Count.ToString());
            }

        }

        public void deleteTally()
        {
            string fullPath = Path.Combine(this.SavePath, this.Filename + this.SaveExtension);
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }
    }

}
