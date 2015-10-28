using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Practice_exercise_4
{
    public class SoccerTeam : IEnumerable<SoccerPlayer>
    {
        public string TeamName { get; set; }
        private int _ageLimit;

        public int AgeLimit
        {
            get { return _ageLimit; }
            set
            {
                if (value > 0)
                    _ageLimit = value;
            }
        }

        public Gender TeamGender { get; set; }

        private List<SoccerPlayer> teamList;
        public List<SoccerPlayer> TeamList => teamList;

        public SoccerPlayer this[string name]
        {
            get
            {
                SoccerPlayer playerA = null;
                foreach (var player in TeamList.Where(player => player.PlayerName.ToLower(CultureInfo.CurrentCulture) == name.ToLower(CultureInfo.CurrentCulture)))
                {
                    playerA = player;
                }
                if (playerA == null)
                {
                    throw new ArgumentException("There is no player with that name");
                }
                else
                {
                    return playerA;
                }
            }
        }


        public SoccerTeam(string name, int age, Gender gender)
        {
            teamList = new List<SoccerPlayer>();
            TeamName = name;
            AgeLimit = age;
            TeamGender = gender;
        }

        public IEnumerator<SoccerPlayer> GetEnumerator()
        {
            return TeamList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();

        }

        public void AddSoccerPlayer(SoccerPlayer newPlayer)
        {
            if (newPlayer != null && newPlayer.PlayerGender == TeamGender && newPlayer.Age <= AgeLimit)
            {
                TeamList.Add(newPlayer);
            }
        }
    }
}
