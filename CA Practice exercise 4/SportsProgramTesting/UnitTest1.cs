using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA_Practice_exercise_4;
namespace SportsProgramTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreatingASoccerPlayerObject()
        {
            SoccerPlayer player = new SoccerPlayer();
            Assert.IsNotNull(player);
        }

        [TestMethod]
        public void CreatingASoccerTeam()
        {
            SoccerTeam team = new SoccerTeam("Rowdy Roiders", 16, Gender.Male);
            Assert.IsNotNull(team);
        }

        [TestMethod]
        public void FillSoccerTeam()
        {
            SoccerTeam team = new SoccerTeam("Rowdy Roiders", 16, Gender.Male);
            team.AddSoccerPlayer(new SoccerPlayer());
            CollectionAssert.AllItemsAreInstancesOfType(team.TeamList, new SoccerPlayer().GetType());
        }

    }
}
