using System;
using CA_3_Enterprise_Software_Development;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CA_3_Unit_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateMusicFile()
        {
            MusicFile myFile = new MusicFile("myfile.mp4", "Ticket To Ride", "The Beatles", Genre.Other);
            Assert.AreEqual("Ticket To Ride", myFile.Track);
        }

        [TestMethod]
        public void TestCreateAndIteratePlaylist()
        {
            Playlist myTicketToRidePlaylist = new Playlist("Ticket To Ride");
            for (int i = 0; i < 10; i++)
            {
                MusicFile myFile = new MusicFile("myfile.mp4", "Ticket To Ride", "The Beatles", Genre.Other);
                myTicketToRidePlaylist.MyPlayList.Add(myFile);
            }

            foreach (var file in myTicketToRidePlaylist)
            {
                Assert.AreEqual("Ticket To Ride", file.Track);
            }
        }

        [TestMethod]
        public void TestValidationOnMusicFiles()
        {
            MusicFile myFile = new MusicFile(null,null,null);
            Assert.AreEqual(myFile.Track, "No Title Provided");
        }

        [TestMethod]
        public void TestingMusicFileProperties()
        {
            MusicFile myFile = new MusicFile("f", "a", "b", Genre.Dance);
            Assert.AreEqual(myFile.Track, "a");
            Assert.AreEqual(myFile.FileName, "f");
            Assert.AreEqual(myFile.Artist, "b");
            Assert.AreEqual(myFile.Genre, Genre.Dance);
        }

        [TestMethod]
        public void TestCollectionPlaylist()
        {
            Playlist myPlaylist = new Playlist("Beatles");
            myPlaylist.MyPlayList.Add(new MusicFile("a","b","c"));
            CollectionAssert.AllItemsAreNotNull(myPlaylist.MyPlayList);
        }

        [TestMethod]
        public void TestEnumeratorPlaylist()
        {
            Playlist plist = new Playlist("beatles");
            for (int i = 0; i < 5; i++)
            {
                MusicFile file = new MusicFile("File", String.Empty, String.Empty);
                plist.MyPlayList.Add(file);
            }
            foreach (var track in plist)
                StringAssert.StartsWith(track.ToString(), "File");

        }

        [TestMethod]
        public void TestToString()
        {
            Playlist plist =new Playlist("beatles");
            for (int i = 0; i < 5; i++)
            {
                MusicFile file = new MusicFile("File", String.Empty, String.Empty);
                plist.MyPlayList.Add(file);
                StringAssert.StartsWith(file.ToString(), "File");
            }
        }

        [TestMethod]
        public void TestCreateMediaFile()
        {
            MediaFile myFile = new MusicFile("File1", String.Empty, String.Empty, Genre.Other);
            Assert.AreEqual("File1", myFile.FileName);
        }
    }
}
