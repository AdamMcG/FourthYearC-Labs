using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_3_Enterprise_Software_Development
{
    public enum Genre
    {
        Pop, Rock, Dance, Hiphop, Rap, Other
    }

    public class MusicFile : MediaFile
    {
        private readonly Genre genre;
        private readonly string track;
        private readonly string artist;
        public string Track
        {
            get
            {
                return track;
            }
        }

        public string Artist
        {
            get
            {
                return artist;
            }
        }

        public Genre Genre
        {
            get
            {
                return genre;
            }
        }

        public MusicFile(string fileName, string trackTitle, string artistName, Genre trackGenre) : base(fileName)
        {
            if (string.IsNullOrEmpty(trackTitle))
                trackTitle = "No Title Provided";
            if (string.IsNullOrEmpty(artistName))
                artistName = "No Artist Provided";
            this.artist = artistName;
            this.track = trackTitle;
            this.genre = trackGenre;
        }

        public MusicFile(string fileName, string trackTitle, string artistName) : base(fileName)
        {
            if (string.IsNullOrEmpty(trackTitle))
                trackTitle = "No Title Provided";
            if (string.IsNullOrEmpty(artistName))
                artistName = "No Artist Provided";
            this.track = trackTitle;
            this.artist = artistName;
            this.genre = Genre.Other;
        }

     

        public override string ToString()
        {
            return base.ToString() + "\nTrack: " + Track + "\nArtist: " + Artist + "\nGenre: " + Genre;
        }
    }
}
