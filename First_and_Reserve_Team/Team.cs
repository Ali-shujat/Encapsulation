using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_Reserve_Team
{
    class Team
    {
        private string name { get; set; }
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public List<Person> FirstTeam { get { return this.firstTeam; } }
        public List<Person> ReserveTeam { get { return this.reserveTeam; } }

        public Team(string nam)
        {
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
            this.name = nam;

        }

        public void AddPlayer(Person player) {
            if (player.Age < 40)
                FirstTeam.Add(player);
            else
                ReserveTeam.Add(player);

        }

        public  string Display()
        {
            return $"First team has {this.FirstTeam.Count()} player, " +
                   $"Reserve team has {this.ReserveTeam.Count()} player";
        }

    }
}
