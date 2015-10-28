using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Practice_exercise_4
{

    public enum Gender { Male, Female, Other }
    public abstract class SportsPlayer
    {
        public string PlayerName { get; set; }
        public int Age { get; set; }
        public Gender PlayerGender { get; set; }

        protected SportsPlayer(string name, int age, Gender gender)
        {
            PlayerName = name;
            this.Age = age;
            PlayerGender = gender;
        }

        public override string ToString()
        {
            return "\n" + "Name: \t" + PlayerName + "\nAge: \t"
                + Age +
                   "\nGender: \t" + PlayerGender.ToString();
        }
    }
}
