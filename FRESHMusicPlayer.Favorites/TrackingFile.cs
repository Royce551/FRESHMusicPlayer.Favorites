using FRESHMusicPlayer.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRESHMusicPlayer.Favorites
{
    public class TrackingFile
    {
        public int Version { get; set; }
        public List<TrackingEntry> Entries { get; set; } = new List<TrackingEntry>();
        public static TrackingFile Read()
        {
            var FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FRESHMusicPlayer", "Tracking");
            if (!File.Exists(Path.Combine(FilePath, "tracking.json")))
            {
                Write(new TrackingFile());
            }
            using (StreamReader file = File.OpenText(Path.Combine(FilePath, "tracking.json")))
            {
                var jsonSerializer = new JsonSerializer();
                return (TrackingFile)jsonSerializer.Deserialize(file, typeof(TrackingFile));
            }
        }
        public static void Write(TrackingFile trackingFile)
        {
            var FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FRESHMusicPlayer", "Tracking");
            if (!Directory.Exists(FilePath)) Directory.CreateDirectory(FilePath);
            using (StreamWriter file = File.CreateText(Path.Combine(FilePath, "tracking.json")))
            {
                new JsonSerializer().Serialize(file, trackingFile);
            }
        }
    }
    public class TrackingEntry
    {
        public DatabaseTrack Track { get; set; }
        public DateTime DatePlayed { get; set; }
    }
}
