using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_3_Enterprise_Software_Development
{
    public class Playlist : IEnumerable<MusicFile>
    {
        public string PlaylistTitle { get; set; }
        private readonly List<MusicFile> myPlaylist;

        public List<MusicFile> MyPlayList => myPlaylist;

        public Playlist(string title)
        {
            this.PlaylistTitle = title;
            myPlaylist = new List<MusicFile>();
        }

        public MusicFile this[Genre myGenre]
        {
            get
            {
                foreach (var track in MyPlayList)
                {
                    if (track.Genre == myGenre)
                    { return track; }
                }
                return null;

            }
        }

        public IEnumerator<MusicFile> GetEnumerator()
        {
            foreach (var file in MyPlayList)
            {
                yield return file;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();

        }
    }
}
