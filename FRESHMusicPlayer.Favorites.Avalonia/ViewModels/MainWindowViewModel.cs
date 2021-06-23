using FRESHMusicPlayer.Favorites.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Linq;

namespace FRESHMusicPlayer.Favorites.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public TrackingFile File;

        public MainWindowViewModel()
        {
            File = TrackingFile.Read();
            Initialize();
           
        }

        public void UpdateCommand() => Initialize();

        private string totalEntries;
        public string TotalEntries
        {
            get => totalEntries;
            set => this.RaiseAndSetIfChanged(ref totalEntries, value);
        }

        public void Initialize()
        {
            UpdateHistoryBox();
            UpdateArtistBox();
            UpdateAlbumBox();
            UpdateTrackBox();
            TotalEntries = $"{File.Entries.Count} entries";
        }

        public ObservableCollection<string> HistoryItems { get; set; } = new();
        public void UpdateHistoryBox()
        {
            HistoryItems.Clear();
            var entries = new List<string>();
            foreach (var entry in File.Entries)
            {
                entries.Add($"{entry.Track.Artist} - {entry.Track.Title} | {entry.DatePlayed}");
            }

            entries.Reverse();
            foreach (var entry in entries)
                HistoryItems.Add(entry);
        }

        public ObservableCollection<string> ArtistItems { get; set; } = new();
        public void UpdateArtistBox()
        {
            ArtistItems.Clear();
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
                ArtistItems.Add($"{artist.Key} - {artist.Value} plays");
            }
        }

        public ObservableCollection<string> AlbumItems { get; set; } = new();
        public void UpdateAlbumBox()
        {
            AlbumItems.Clear();
            var albumOccurences = new Dictionary<string, int>();
            foreach (var entry in File.Entries)
            {
                if (albumOccurences.ContainsKey(entry.Track.Album)) albumOccurences[entry.Track.Album]++;
                else albumOccurences.Add(entry.Track.Album, 1);
            }
            var topAlbums = albumOccurences.ToList();
            topAlbums.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            topAlbums.Reverse();
            foreach (var album in topAlbums) AlbumItems.Add($"{album.Key} - {album.Value} plays");
        }

        public ObservableCollection<string> TrackItems { get; set; } = new();
        public void UpdateTrackBox()
        {
            TrackItems.Clear();
            var trackOccurences = new Dictionary<string, int>();
            foreach (var entry in File.Entries)
            {
                if (trackOccurences.ContainsKey(entry.Track.Title)) trackOccurences[entry.Track.Title]++;
                else trackOccurences.Add(entry.Track.Title, 1);
            }
            var topAlbums = trackOccurences.ToList();
            topAlbums.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            topAlbums.Reverse();
            foreach (var album in topAlbums) TrackItems.Add($"{album.Key} - {album.Value} plays");
        }
    }
}
