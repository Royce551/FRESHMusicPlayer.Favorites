using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRESHMusicPlayer.Favorites
{
    public partial class Form1 : Form
    {
        public TrackingFile File;
        public Form1()
        {
            InitializeComponent();
            File = TrackingFile.Read();
            InitFields();
        }
        public void InitFields()
        {
            InitHistoryBox();
            InitFavoriteArtistsBox();
            InitFavoriteAlbumsBox();
            InitFavoriteTracksBox();
            button3_Click(null, EventArgs.Empty);
            infoLabel.Text = $"{File.Entries.Count} entries";
        }
        public void InitHistoryBox()
        {
            historyListBox.BeginUpdate();
            historyListBox.Items.Clear();
            var entries = new List<string>();
            foreach (var entry in File.Entries)
            {
                entries.Add($"{entry.Track.Artist} - {entry.Track.Title} | {entry.DatePlayed}");
            }
            entries.Reverse();
            historyListBox.Items.AddRange(entries.ToArray());
            historyListBox.EndUpdate();
        }
        public void InitFavoriteArtistsBox()
        {
            favoriteArtistsListBox.BeginUpdate();
            favoriteArtistsListBox.Items.Clear();
            var artistOccurences = new Dictionary<string, int>();
            foreach (var entry in File.Entries)
            {
                if (artistOccurences.ContainsKey(entry.Track.Artist)) artistOccurences[entry.Track.Artist]++;
                else artistOccurences.Add(entry.Track.Artist, 1);
            }
            var topArtists = artistOccurences.ToList();
            topArtists.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            topArtists.Reverse();
            foreach (var artist in topArtists)
            {
                favoriteArtistsListBox.Items.Add($"{artist.Key} - {artist.Value} plays");
            }
            favoriteArtistsListBox.EndUpdate();
        }
        public void InitFavoriteAlbumsBox()
        {
            favoriteAlbumsListBox.BeginUpdate();
            favoriteAlbumsListBox.Items.Clear();
            var albumOccurences = new Dictionary<string, int>();
            foreach (var entry in File.Entries)
            {
                if (albumOccurences.ContainsKey(entry.Track.Album)) albumOccurences[entry.Track.Album]++;
                else albumOccurences.Add(entry.Track.Album, 1);
            }
            var topAlbums = albumOccurences.ToList();
            topAlbums.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            topAlbums.Reverse();
            foreach (var album in topAlbums) favoriteAlbumsListBox.Items.Add($"{album.Key} - {album.Value} plays");
            favoriteAlbumsListBox.EndUpdate();
        }
        public void InitFavoriteTracksBox()
        {
            favoriteTracksListBox.BeginUpdate();
            favoriteTracksListBox.Items.Clear();
            var trackOccurences = new Dictionary<string, int>();
            foreach (var entry in File.Entries)
            {
                if (trackOccurences.ContainsKey(entry.Track.Title)) trackOccurences[entry.Track.Title]++;
                else trackOccurences.Add(entry.Track.Title, 1);
            }
            var topAlbums = trackOccurences.ToList();
            topAlbums.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            topAlbums.Reverse();
            foreach (var album in topAlbums) favoriteTracksListBox.Items.Add($"{album.Key} - {album.Value} plays");
            favoriteTracksListBox.EndUpdate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            File = TrackingFile.Read();
            InitFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FRESHMusicPlayer", "Tracking", "tracking.json");
            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var xAxis = new List<double>();
            var yAxis = new List<double>();
            for (int i = -50; i <= -1; i++)
            {
                int entriesForDay = 1;
                var day = DateTime.Now.AddDays(i);
                foreach (var entry in File.Entries)
                {
                    if (entry.DatePlayed.Day == day.Day) entriesForDay++;
                }
                yAxis.Add(entriesForDay);
                xAxis.Add(i);
            }
            formsPlot1.plt.PlotScatter(xAxis.ToArray(), yAxis.ToArray(), label: "amount of FMP listened to over time");
            formsPlot1.Render();
        }
    }
    public enum ListType
    {
        Artist,
        Album,
        Track
    }
}
