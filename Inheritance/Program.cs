using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace InheritanceExample
{
    //Create a class called person
    public class Person  //Base class implicitly derived from object
    {
        public int iAge;
        private string strName;

        public string GetName()
        {
            return strName;
        }
        public void SetName(string Name)
        {
            strName = Name;
        }
    };

    public class CricketPlayer : Person
    {
        public string strNationality;  //Public Member variables
        public string GetNationality() //Methods
        {
            return strNationality;
        }
    };

    public class PlayerTeam : Person
    {
        public string strTeamName;
        public string GetTeamName()
        {
            return strTeamName;
        }
    }

    //Created a class called CricketPlayer derived from the person
    class Program
    {
        [DllImport("msvcrt")]
        static extern int _getch();
        static void Main(string[] args)
        {
            System.Console.WriteLine("InheritanceExample");
            CricketPlayer Player;
            Player = new CricketPlayer();
            Player.iAge = 21;
            Player.SetName("Krishna");
            Player.strNationality = "Indian";
            PlayerTeam Team;
            Team = new PlayerTeam();
            Team.strTeamName = "Mumbai Indians";
            System.Console.WriteLine("Displaying Players details: ");
            System.Console.WriteLine("Nationality = " + Player.GetNationality() + "\t" + "Name = " + Player.GetName() + "\t" + "Team Name = " + Team.GetTeamName());
            _getch();
        }
    }
}
