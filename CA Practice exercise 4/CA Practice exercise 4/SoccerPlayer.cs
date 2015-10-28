using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Practice_exercise_4
{
    public enum Position { Goalkeeper, Defender, Midfielder, Striker }
    public class SoccerPlayer : SportsPlayer
    {

        public Position PlayerPosition { get; set; }
        public SoccerPlayer(string name, int age, Gender gender, Position position) : base(name, age, gender)
        {
            this.PlayerPosition = position;
        }

        public SoccerPlayer()
            : base(String.Empty, 0, Gender.Male)
        {
            this.PlayerPosition = Position.Defender;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Position: \t" + PlayerPosition.ToString();
        }
    }
}
