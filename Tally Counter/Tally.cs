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
        public int Index { get; set; }
        public string SaveSubfolder { get; set; } = ""; // Relative to dataSavePath
        public string Title { get; set; }
        public string Filename { get; set; }
        public string SaveExtension { get; set; }

        [JsonIgnore]
        public string BasePath { get; set; } = "";

        [JsonIgnore]
        public string FullFilePath => Path.Combine(BasePath, SaveSubfolder, Filename + SaveExtension);


        public Tally() { }

        public Tally(string title, int count, string basePath, string subfolder, string fileName, string fileExt, int index = 0, bool isLoading = false)
        {
            Title = title;
            Count = count;
            BasePath = basePath;
            SaveSubfolder = subfolder;
            Filename = fileName;
            SaveExtension = fileExt;
            Index = index;

            if (!isLoading)
                saveTallyToFile();
        }

        public void incrementTally(int val)
        {
            this.Count += val;
            saveTallyToFile();
        }

        public void decrementTally(int val)
        {
            this.Count -= val;
            saveTallyToFile();
        }

        public void saveTallyToFile()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FullFilePath));
            File.WriteAllText(FullFilePath, Count.ToString());
        }

        public void deleteTally()
        {
            if (File.Exists(FullFilePath))
                File.Delete(FullFilePath);
        }
    } 

}
